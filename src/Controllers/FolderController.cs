using System.Text.Json;
using AutoMapper;
using FolderExplorer.Helpers;
using FolderExplorer.Models;
using FolderExplorer.Models.Dto;
using FolderExplorer.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FolderExplorer.Controllers;

public sealed class FolderController : Controller
{
    private readonly AppDbContext _db;
    private readonly IMapper _mapper;

    public FolderController(AppDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Index(Guid? id)
    {
        var currentFolder = id == null
            ? _db.Folders
                .First(folder => folder.ParentFolderId == null)
            : _db.Folders
                .First(folder => folder.Id == id);

        var childFolders = _db.Folders
            .Where(folder => folder.ParentFolderId == currentFolder.Id)
            .ToList();

        var response = _mapper.Map<FolderDto>(currentFolder);
        response.ChildFolders = childFolders;

        return View(response);
    }

    [HttpGet]
    public IActionResult ExportAsJson()
    {
        const string fileName = "export";

        var folders = _db.Folders
            .ToList();

        return JsonExporter.Export(fileName, folders);
    }

    [HttpPost]
    public IActionResult ImportAsJson(IFormFile file)
    {
        const string wrongFormat = "File can not be read.";
        
        using var reader = new StreamReader(file.OpenReadStream());

        var content = reader.ReadToEnd();

        var oldData = _db.Folders
            .ToList();
        var newData = JsonSerializer.Deserialize<List<Folder>>(content);

        if (newData is null or { Count: 0 })
        {
            return BadRequest(wrongFormat);
        }
        
        _db.Folders.RemoveRange(oldData);
        _db.Folders.AddRange(newData);
        _db.SaveChanges();
        
        if (oldData.Count == 0)
        {
            return Ok();
        }
        
        return JsonExporter.Export("backup", oldData);
    }
}