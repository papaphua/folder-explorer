using System.ComponentModel.DataAnnotations;

namespace FolderExplorer.Models.Entities;

public sealed class Folder
{
    public Folder()
    {
        
    }
    
    public Folder(string name, Guid? parentFolderId = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        ParentFolderId = parentFolderId;
    }
    
    public Guid Id { get; set; }
    [Required] public string Name { get; set; } = null!;
    public Guid? ParentFolderId { get; set; }
}