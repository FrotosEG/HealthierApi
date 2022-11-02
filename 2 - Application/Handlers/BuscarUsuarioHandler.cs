using Domain.Command;
using Domain.Interfaces;
using Domain.Models;
using Domain.Response;
using MediatR;

namespace Application.Handlers
{
    public class BuscarUsuarioHandler : IRequestHandler<BuscarUsuarioCommand, BuscarUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public BuscarUsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<BuscarUsuarioResponse> Handle(BuscarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var response = new BuscarUsuarioResponse();
            var usuario = new UsuarioModel();
            usuario.TelefoneDDD = "47";
            usuario.Telefone = "992279870";
            usuario.Nome = "Erick Artur Garcia";
            usuario.Premium = 1;
            usuario.SenhaCriptografada = "SistemaPrivada1@";
            usuario.Cpf = "12776605900";
            _usuarioRepository.InsertAsync(usuario);
            _usuarioRepository.SaveChanges();
            response.teste = 10;
            return Task.FromResult(response);
        }
    }
}
