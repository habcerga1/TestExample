using Microsoft.Extensions.Caching.Memory;

namespace TestExample.Repository;

public class DiskDriveRepository
{
    public event Action<string> FileReaded;
    
    public async Task GetAsync(string fileName)
    {
        string file = $"{AppDomain.CurrentDomain.BaseDirectory}/Content/{fileName}";
        
        if (System.IO.File.Exists(file))
        {
            var result = await System.IO.File.ReadAllTextAsync(file);
            FileReaded.Invoke(result);
        }
        else
        {
            FileReaded.Invoke("File not exist");
        }
    }
}
