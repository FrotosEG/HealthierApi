using Domain.Command.FichaPeso;
using Domain.Interfaces;
using Domain.Models;
using Domain.Response.FichaPeso;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Handlers.FichaPeso
{
    public class CadastrarFichaPesoHandler : IRequestHandler<CriarFichaPesoCommand, CriarFichaPesoResponse>
    {
        private readonly IFichaPesoRepository _fichaPesoRepository;
        public CadastrarFichaPesoHandler(IFichaPesoRepository fichaPesoRepository)
        {
            _fichaPesoRepository = fichaPesoRepository;
        }

        public Task<CriarFichaPesoResponse> Handle(CriarFichaPesoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new CriarFichaPesoResponse();
            try
            {
                var fichaPeso = new FichaPesoModel();

                fichaPeso.IdUsuario = request.IdUsuario;
                fichaPeso.PesoUsuarioNaCriacao = request.PesoUsuarioNaCriacao;
                fichaPeso.TipoObjetivoUsuario = request.TipoObjetivoUsuario;
                fichaPeso.AlturaUsuario = request.AlturaUsuario;
                fichaPeso.PesoDesejadoUsuario = request.PesoDesejadoUsuario;
                fichaPeso.CinturaUsuario = request.CinturaUsuario;
                fichaPeso.IdFichaAlimentacao = request.IdFichaAlimentacao;
                fichaPeso.FrequenciaAlimentar = request.FrequenciaAlimentar;
                fichaPeso.IdAlergia1 = request.IdAlergia1;
                fichaPeso.IdAlergia2 = request.IdAlergia2;
                fichaPeso.IdAlergia3 = request.IdAlergia3;
                fichaPeso.IdAlergia4 = request.IdAlergia4;
                fichaPeso.IdAlergia5 = request.IdAlergia5;
                _fichaPesoRepository.Insert(fichaPeso);
                _fichaPesoRepository.SaveChanges();

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = "Ficha de peso atualizada com sucesso.";
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
