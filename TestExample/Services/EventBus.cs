using System.Collections.Concurrent;
using TestExample.Repository;

namespace TestExample.Services;

public static class EventBus
{
    // Files requested repository
    private static IDictionary<string, DiskDrive> _subscribers =
        new ConcurrentDictionary<string, DiskDrive>();

    // Mutex for Subscribe
    private static Mutex _mutexSub = new Mutex();
    
    // Mutex for UnSubscribe
    private static Mutex _mutexUnsub = new Mutex();
    
    /// <summary>
    /// Subscribe to event
    /// </summary>
    /// <param name="Key">Event key</param>
    /// <param name="callback">Callback function</param>
    /// <remarks>
    /// Key is the name of the file and callback is a function
    /// that is passed during subscription and must take a value.
    /// </remarks>
    /// <returns></returns>
    public static Task Subscribe(string Key, Action<string> callback)
    {
        _mutexSub.WaitOne();
        // Checking if file not requested
        if (!_subscribers.ContainsKey(Key))
        {
            /// Add key
            _subscribers.Add(new KeyValuePair<string, DiskDrive>(Key,new DiskDrive()));
            
            // First subscribe
            DiskDrive disk;
            _subscribers.TryGetValue(Key, out disk);
            disk.FileReaded += callback;
            
            /*
             We launch the file reading task and after its completion we launch the unsubscribe task,
             it will happen after the event FileReaded  in class DiskDrive notifies all its subscribers 
             */
            Task.Run(  () =>
            {
                DiskDrive reader;
                _subscribers.TryGetValue(Key, out reader);
                 reader.GetAsync(Key);
            }).ContinueWith( t => UnSubscribe(Key) );
        }
        else
        {
            DiskDrive disk;
            _subscribers.TryGetValue(Key, out disk);
            disk.FileReaded += callback;
        }
        _mutexSub.ReleaseMutex();
        return Task.CompletedTask;
    }
    
    private static void UnSubscribe(string Key)
    {
        _mutexUnsub.WaitOne();
        // Checking if file not requested
        if (_subscribers.ContainsKey(Key))
        {
            // Remove key and unsubscribe
            _subscribers.Remove(Key);
        }
        _mutexUnsub.ReleaseMutex();
    }
    
}