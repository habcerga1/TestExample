namespace TestExample.Services;

public class FileService
{
    /// <summary>
    /// Wrapper for await function
    /// </summary>
    /// <param name="file">File name</param>
    /// <remarks>
    /// Wrapper function for creating a file read request. When subscribing, an action is passed to EventBus,
    /// which is a callback function and subscribes to the FileReaded event.
    /// The FileReaded event calls action and passes it the result of reading the file, which is set as a
    /// result of TaskCompletionSource.
    /// </remarks>
    /// <returns></returns>
    public Task<string> Request(string file)
    {
        var tcs = new TaskCompletionSource<string>();
        var action = delegate(string e) { tcs.SetResult(e); };
        EventBus.Subscribe(file, action);
        return tcs.Task;
    }
}