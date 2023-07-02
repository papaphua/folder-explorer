using System.Globalization;
using System.Text;
using System.Text.Json;
using FolderExplorer.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FolderExplorer.Helpers;

public static class JsonExporter
{
    public static FileContentResult Export(string fileName, List<Folder> folders)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        const string fileType = "application/json";
        
        var content = JsonSerializer.Serialize(folders, options);
        var bytes = Encoding.Default.GetBytes(content);

        var currentTime = DateTime.Now
            .ToString(CultureInfo.CurrentCulture)
            .Replace(" ", "_");

        return new FileContentResult(bytes, fileType)
        {
            FileDownloadName = $"{fileName}_{currentTime}.json"
        };
    }
}