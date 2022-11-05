using Domain.Command.FichaPeso;
using Domain.Interfaces;
using Domain.Response.FichaPeso;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Handlers.FichaPeso
{
    public class BuscarFichaPesoHandler : IRequestHandler<BuscarFichaPesoCommand, BuscarFichaPesoResponse>
    {
        private readonly IFichaPesoRepository _fichaPesoRepository;
        public BuscarFichaPesoHandler(IFichaPesoRepository fichaPesoRepository)
        {
            _fichaPesoRepository = fichaPesoRepository;
        }

        public Task<BuscarFichaPesoResponse> Handle(BuscarFichaPesoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new BuscarFichaPesoResponse();
            try
            {
                var fichaPeso = _fichaPesoRepository.GetById(request.IdFichaPeso);
                if (fichaPeso == null)
                {
                    retorno.Sucesso = false;
                    retorno.StatusCode = 400;
                    retorno.MensagemSucesso = "Não foi possível encontrar nenhuma ficha de peso com esse Id";
                    return Task.FromResult(retorno);
                }

                retorno.IdUsuario = fichaPeso.IdUsuario;
                retorno.PesoUsuarioNaCriacao = fichaPeso.PesoUsuarioNaCriacao;
                retorno.TipoObjetivoUsuario = fichaPeso.TipoObjetivoUsuario;
                retorno.AlturaUsuario = fichaPeso.AlturaUsuario;
                retorno.PesoDesejadoUsuario = fichaPeso.PesoDesejadoUsuario;
                retorno.CinturaUsuario = fichaPeso.CinturaUsuario;
                retorno.IdFichaAlimentacao = fichaPeso.IdFichaAlimentacao;
                retorno.FrequenciaAlimentar = fichaPeso.FrequenciaAlimentar;
                retorno.IdAlergia1 = fichaPeso.IdAlergia1;
                retorno.IdAlergia2 = fichaPeso.IdAlergia2;
                retorno.IdAlergia3 = fichaPeso.IdAlergia3;
                retorno.IdAlergia4 = fichaPeso.IdAlergia4;
                retorno.IdAlergia5 = fichaPeso.IdAlergia5;

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
