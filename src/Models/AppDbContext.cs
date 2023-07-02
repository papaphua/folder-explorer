using FolderExplorer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FolderExplorer.Models;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Folder> Folders { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var creatingDigitalImages = new Folder("Creating Digital Images");
        var resources = new Folder("Resources", creatingDigitalImages.Id);
        var evidence = new Folder("Evidence", creatingDigitalImages.Id);
        var graphicProducts = new Folder("Graphic Products", creatingDigitalImages.Id);
        var primarySources = new Folder("Primary Sources", resources.Id);
        var secondarySources = new Folder("Secondary Sources", resources.Id);
        var process = new Folder("Process", graphicProducts.Id);
        var finalProduct = new Folder("Final Product", graphicProducts.Id);

        modelBuilder
            .Entity<Folder>()
            .HasData(creatingDigitalImages, resources, evidence, graphicProducts, primarySources, secondarySources,
                process, finalProduct);
    }
}