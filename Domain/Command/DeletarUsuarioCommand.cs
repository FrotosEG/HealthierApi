using Domain.Response;
using MediatR;

namespace Domain.Command
{
    public class DeletarUsuarioCommand : IRequest<ResultadoBase>
    {
        public long IdUsuario { get; set; }
    }
}
