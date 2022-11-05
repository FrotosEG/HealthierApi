using Domain.Response;
using MediatR;

namespace Domain.Command
{
    public class AtualizarUsuarioCommand : IRequest<ResultadoBase>
    {
        public long IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TelefoneDDD { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public short Premium { get; set; }
        public string Senha { get; set; }
    }
}
