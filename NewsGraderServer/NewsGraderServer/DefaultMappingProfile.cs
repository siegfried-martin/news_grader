using AutoMapper;
using NewsGraderServer.Controllers;
using NewsGraderServer.DTO;
using NewsGraderServer.Models;

namespace NewsGraderServer;

public class DefaultMappingProfile : Profile
{
    public DefaultMappingProfile()
    {
        CreateMap<ArticleEntity, ArticleDto>();
        CreateMap<ArticleDto, ArticleEntity>();
    }
}
