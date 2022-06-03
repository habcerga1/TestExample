namespace TestExample.Services;

public class FileService
{
    public Task<string> Request(string file)
    {
        var tcs = new TaskCompletionSource<string>();
        var action = delegate(string e) { tcs.SetResult(e); };
        EventBus.Subscribe(file, action);
        return tcs.Task;
    }
}