using FolderExplorer.Models.Entities;

namespace FolderExplorer.Models.Dto;

public sealed class FolderDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid? ParentFolderId { get; set; }
    public List<Folder>? ChildFolders { get; set; }
}