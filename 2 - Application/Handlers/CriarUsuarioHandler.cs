using Domain.Command;
using Domain.Interfaces;
using Domain.Models;
using Domain.Response;
using MediatR;
using System.Security.Cryptography;

namespace _2___Application.Handlers
{
    public class CriarUsuarioHandler : IRequestHandler<CriarUsuarioCommand, CriarUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public CriarUsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<CriarUsuarioResponse> Handle(CriarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var retorno = new CriarUsuarioResponse();
            try
            {
                var usuario = new UsuarioModel();
                usuario.TelefoneDDD = request.TelefoneDDD;
                usuario.Telefone = request.Telefone;
                usuario.Nome = request.Nome;
                usuario.Premium = request.Premium;
                usuario.Email = request.Email;
                usuario.SenhaCriptografada = HashSenha(request.Senha);
                usuario.Cpf = request.Cpf;
                _usuarioRepository.Insert(usuario);
                _usuarioRepository.SaveChanges();

                retorno.Id = usuario.id;
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
