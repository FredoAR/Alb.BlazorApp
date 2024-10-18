using Alb.BlazorApp.Shared.Contracts.Gato.Dto;
using Alb.Entities.Gato;
using AutoMapper;

namespace Alb.BlazorApp.Server
{
    public class AlbAutoMapperProfiles : Profile
    {
        public AlbAutoMapperProfiles()
        {
            CreateMap<GatoDto, Gato>();
            //CreateMap<ConsultaEstatusCfdiResult, ConsultaEstatusCfdiResultDto>();


        }
    
    }
}
