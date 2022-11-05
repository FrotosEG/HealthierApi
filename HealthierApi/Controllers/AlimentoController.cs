using Domain.Command.Alimentos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HealthierApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AlimentoController : ControllerBase
    {
        private readonly IMediator _mediatr;

        private readonly ILogger<AlimentoController> _logger;

        public AlimentoController(ILogger<AlimentoController> logger, IMediator mediator)
        {
            _mediatr = mediator;
            _logger = logger;
        }

        [HttpGet, Route("/buscarAlimento")]
        [SwaggerOperation(Summary = "Busca o alimento pelo Id")]
        public IActionResult BuscarAlimento([FromQuery] BuscarAlimentoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpPost, Route("/CadastrarAlimento")]
        [SwaggerOperation(Summary = "Faz o cadastro de um alimento.")]
        public IActionResult CadastrarAlimento([FromBody] CadastrarAlimentoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpPut, Route("/AtualizarAlimento")]
        [SwaggerOperation(Summary = "Atualiza um alimento pelo id do alimento")]
        public IActionResult AtualizarAlimento([FromBody] AtualizarAlimentoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

        [HttpDelete, Route("/DeletarAlimento")]
        [SwaggerOperation(Summary = "Deleta o alimento por id")]
        public IActionResult DeletarAlimento([FromQuery] DeletarAlimentoCommand command)
        {
            return Ok(_mediatr.Send(command).Result);
        }

    }
}
