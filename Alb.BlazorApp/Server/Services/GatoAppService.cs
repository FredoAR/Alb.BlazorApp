using Alb.BlazorApp.Shared.Contracts.Comunication;
using Alb.BlazorApp.Shared.Contracts.Gato;
using Alb.BlazorApp.Shared.Contracts.Gato.Dto;
using Alb.Entities.Gato;
using AutoMapper;
using Newtonsoft.Json;

namespace Alb.BlazorApp.Server.Services
{
    public class GatoAppService : IGatoAppService
    {
        private IMapper _mapper { get; set; }

        private readonly IComunication _comunication;



        public GatoAppService(IMapper mapper, IComunication comunication)
        {
            _mapper = mapper;
            _comunication = comunication;
        }


        public async Task<GatoDto> Crear(GatoDto dto)
        {            
            var entity = _mapper.Map<Gato>(dto);

            var json = JsonConvert.SerializeObject(entity);

            var result = await _comunication.SendDtoToMicroservice(json);

            var response = JsonConvert.DeserializeObject<GatoDto>(result);

            return response;
        }




    }
}
