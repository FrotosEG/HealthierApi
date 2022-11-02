using Domain.Response;
using MediatR;

namespace Domain.Command
{
    public class BuscarUsuarioCommand : IRequest<BuscarUsuarioResponse>
    {
        public long IdUsuario { get; set; }

        public BuscarUsuarioCommand() { }
        public BuscarUsuarioCommand(long id) 
        {
            IdUsuario = id;
        }

    }
}
