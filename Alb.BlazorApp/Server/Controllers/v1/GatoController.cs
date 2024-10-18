using Alb.BlazorApp.Shared.Contracts.Gato;
using Alb.BlazorApp.Shared.Contracts.Gato.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Alb.BlazorApp.Server.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GatoController : AlbBaseController
    {
        private readonly IGatoAppService _gatoAppService;

        public GatoController(IGatoAppService gatoAppService, IHttpContextAccessor ctxAccesor) : base(ctxAccesor)
        {
            _gatoAppService = gatoAppService;
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GatoDto dto)
        {
            try
            {
                // validate Dto

                var result = await _gatoAppService.Crear(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();                
            }

        }




    }
}
