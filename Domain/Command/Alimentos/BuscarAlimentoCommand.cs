using Domain.Response.Alimentos;
using MediatR;

namespace Domain.Command.Alimentos
{
    public class BuscarAlimentoCommand : IRequest<BuscarAlimentoResponse>
    {
        public long IdAlimento { get; set; }
    }
}
