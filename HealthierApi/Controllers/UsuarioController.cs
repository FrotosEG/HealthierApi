using Domain.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HealthierApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
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
        [SwaggerOperation(Summary = "Busca um usu�rio por Id.")]
        public IActionResult BuscarUsuario([FromQuery] BuscarUsuarioCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cria um usu�rio novo no banco.")]
        public IActionResult CriarUsuario([FromBody] CriarUsuarioCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Atualiza o usu�rio pelo Id do usu�rio.")]
        public IActionResult AtualizarUsuario([FromBody] AtualizarUsuarioCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpDelete]
        [SwaggerOperation(Summary = "Deleta o usu�rio pelo id.")]
        public IActionResult DeleteUsuario([FromQuery] DeletarUsuarioCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }
    }
}