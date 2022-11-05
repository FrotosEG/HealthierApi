using Domain.Command;
using Domain.Interfaces;
using Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Handlers
{
    public class DeletarUsuarioHandler : IRequestHandler<DeletarUsuarioCommand, ResultadoBase>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public DeletarUsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<ResultadoBase> Handle(DeletarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var retorno = new ResultadoBase();
            try
            {
                _usuarioRepository.Delete(request.IdUsuario);
                _usuarioRepository.SaveChanges();

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = $"Usuário deletado com sucesso.";
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
