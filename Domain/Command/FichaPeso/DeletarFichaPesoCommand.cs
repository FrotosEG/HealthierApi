using Domain.Response;
using MediatR;

namespace Domain.Command.FichaPeso
{
    public class DeletarFichaPesoCommand : IRequest<ResultadoBase>
    {
        public long IdFichaPeso { get; set; }
    }
}
