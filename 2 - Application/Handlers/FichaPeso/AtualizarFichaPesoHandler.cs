using Domain.Command.FichaPeso;
using Domain.Interfaces;
using Domain.Models;
using Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Handlers.FichaPeso
{
    public class AtualizarFichaPesoHandler : IRequestHandler<AtualizarFichaPesoCommand, ResultadoBase>
    {
        private readonly IFichaPesoRepository _fichaPesoRepository;
        public AtualizarFichaPesoHandler(IFichaPesoRepository fichaPesoRepository)
        {
            _fichaPesoRepository = fichaPesoRepository;
        }

        public Task<ResultadoBase> Handle(AtualizarFichaPesoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new ResultadoBase();
            try
            {
                var fichaPeso = _fichaPesoRepository.GetById(request.IdFichaPeso);
                if(fichaPeso == null)
                {
                    retorno.Sucesso = false;
                    retorno.StatusCode = 400;
                    retorno.MensagemSucesso = "Não foi possível encontrar nenhuma ficha para atualizar com esse id.";
                    return Task.FromResult(retorno);

                }
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
                _fichaPesoRepository.Update(fichaPeso);
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