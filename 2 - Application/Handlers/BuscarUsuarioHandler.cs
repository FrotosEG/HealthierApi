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
            var retorno = new BuscarUsuarioResponse();
            try
            {
                var usuario = _usuarioRepository.GetById(request.IdUsuario);
                if(usuario == null)
                {
                    retorno.Sucesso = false;
                    retorno.StatusCode = 400;
                    retorno.MensagemSucesso = "Nenhum usuário encontrado.";
                    return Task.FromResult(retorno);
                }

                retorno.TelefoneDDD = usuario.TelefoneDDD;
                retorno.Telefone = usuario.Telefone;
                retorno.Nome = usuario.Nome;
                retorno.Premium = usuario.Premium;
                retorno.Email = usuario.Email;
                retorno.Cpf = usuario.Cpf;

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = $"Usuário criado com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.StatusCode = 500;
                retorno.MensagemSucesso = $"Exception: {ex}, inner:{ex.InnerException?.Message}";
            }
          
            return Task.FromResult(retorno);
        }
    }
}
