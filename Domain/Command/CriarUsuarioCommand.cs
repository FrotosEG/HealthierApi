using Domain.Response;
using MediatR;

namespace Domain.Command
{
    public class CriarUsuarioCommand : IRequest<CriarUsuarioResponse>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TelefoneDDD { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public short Premium { get; set; }
        public string Senha { get; set; }
    }
}
