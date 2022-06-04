using Microsoft.Extensions.Caching.Memory;

namespace TestExample.Repository;

public class DiskDrive
{
    /// <summary>
    /// The event that is called after reading the file
    /// </summary>
    public event Action<string> FileReaded;
    
    /// <summary>
    /// Read file from Content folder async
    /// </summary>
    /// <param name="fileName">File name</param>
    public async Task GetAsync(string fileName)
    {
        string file = $"{AppDomain.CurrentDomain.BaseDirectory}/Content/{fileName}";
        
        // Check if file exist
        if (System.IO.File.Exists(file))
        {
            var result = await System.IO.File.ReadAllTextAsync(file);
            if(FileReaded != null) FileReaded.Invoke(result);
        }
        else
        {
            if(FileReaded != null)  FileReaded.Invoke("File not exist");
        }
    }
}
