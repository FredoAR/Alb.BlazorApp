using Alb.BlazorApp.Shared.Contracts.Gato.Dto;

namespace Alb.BlazorApp.Shared.Contracts.Gato
{
    public interface IGatoAppService
    {
        Task<GatoDto> Crear(GatoDto dto);
    }
}
