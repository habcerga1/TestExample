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
            // For normal work just uncommit row bellow, delete rows 25,26 and replase to result in FileReaded.Invoke(requestedTime);
            //var result = await System.IO.File.ReadAllTextAsync(file);
            var requestedTime = $"File Guid: {Guid.NewGuid()} Requested time: {DateTime.Now}"; 
            await Task.Delay(2000);
            if(FileReaded != null) FileReaded.Invoke(requestedTime);
        }
        else
        {
            if(FileReaded != null)  FileReaded.Invoke("File not exist");
        }
    }
}
