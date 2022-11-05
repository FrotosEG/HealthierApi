using Domain.Command.FichaPeso;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HealthierApi.Controllers
{
    [ApiController]
    public class FichaPesoController : ControllerBase
    {
        private readonly IMediator _mediatr;

        private readonly ILogger<FichaPesoController> _logger;

        public FichaPesoController(ILogger<FichaPesoController> logger, IMediator mediator)
        {
            _mediatr = mediator;
            _logger = logger;
        }

        [HttpGet, Route("/buscarFichaPeso")]
        [SwaggerOperation(Summary = "Busca a Ficha de peso do usuário por Id.")]
        public IActionResult BuscarFichaPeso([FromQuery] BuscarFichaPesoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpPost, Route("/criarFichaPeso")]
        [SwaggerOperation(Summary = "Cria uma ficha de peso para o usuário.")]
        public IActionResult CriarFichaPeso([FromBody] CriarFichaPesoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpPut, Route("/atualizarFichaPeso")]
        [SwaggerOperation(Summary = "Atualiza a ficha de peso do usuário por id da ficha de peso.")]
        public IActionResult AtualizarFichaPeso([FromBody] AtualizarFichaPesoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpDelete, Route("/deletarFichaPeso")]
        [SwaggerOperation(Summary = "Deleta a ficha de peso pro id.")]
        public IActionResult DeletarFichaPeso([FromQuery] DeletarFichaPesoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }
    }
}
