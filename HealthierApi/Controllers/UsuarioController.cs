using Domain.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthierApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediatr;

        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, IMediator mediator)
        {
            _mediatr = mediator;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult BuscarUsuario([FromRoute] long id)
        {
            return Ok(_mediatr.Send(new BuscarUsuarioCommand(id)).Result);
        }
    }
}