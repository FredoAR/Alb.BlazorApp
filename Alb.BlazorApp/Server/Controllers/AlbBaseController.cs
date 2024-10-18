using Microsoft.AspNetCore.Mvc;

namespace Alb.BlazorApp.Server.Controllers
{
    public class AlbBaseController : ControllerBase
    {
        private readonly IHttpContextAccessor _ctx;


        public AlbBaseController(IHttpContextAccessor ctxAccesor)
        {
            _ctx = ctxAccesor;
        }


        protected string GetIpRequest() => 
            _ctx?.HttpContext?.Connection?.RemoteIpAddress?.ToString() ?? string.Empty;

        
        protected string? GetHostName() => _ctx?.HttpContext?.Request?.Host.Value;


    }
}
