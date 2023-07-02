using AutoMapper;
using FolderExplorer.Models.Dto;
using FolderExplorer.Models.Entities;

namespace FolderExplorer.Models;

public sealed class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Folder, FolderDto>();
    }
}