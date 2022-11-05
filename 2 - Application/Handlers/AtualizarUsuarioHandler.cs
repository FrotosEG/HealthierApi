using Domain.Command;
using Domain.Interfaces;
using Domain.Response;
using MediatR;
using System.Text;
using System.Security.Cryptography;

namespace _2___Application.Handlers
{
    public class AtualizarUsuarioHandler : IRequestHandler<AtualizarUsuarioCommand, ResultadoBase>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public AtualizarUsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<ResultadoBase> Handle(AtualizarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var retorno = new ResultadoBase();
            try
            {
                var usuario = _usuarioRepository.GetById(request.IdUsuario);

                usuario.TelefoneDDD = request.TelefoneDDD;
                usuario.Telefone = request.Telefone;
                usuario.Nome = request.Nome;
                usuario.Premium = request.Premium;
                usuario.Email = request.Email;

                if(HashSenha(request.Senha) != usuario.SenhaCriptografada)
                    usuario.SenhaCriptografada = HashSenha(request.Senha);

                usuario.Cpf = request.Cpf;

                _usuarioRepository.Update(usuario);
                _usuarioRepository.SaveChanges();

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = $"Usuário atualizado com sucesso.";
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.StatusCode = 500;
                retorno.MensagemSucesso = $"Exception: {ex}, inner:{ex.InnerException?.Message}";
            }

            return Task.FromResult(retorno);
        }

        public string HashSenha(string senha)
        {
            var rngCsp = new RNGCryptoServiceProvider();
            byte[] salt = new byte[16];
            rngCsp.GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 1000);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
