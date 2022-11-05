using Domain.Command.Alimentos;
using Domain.Interfaces;
using Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Handlers.Alimentos
{
    public class AtualizarAlimentoHandler : IRequestHandler<AtualizarAlimentoCommand, ResultadoBase>
    {
        private readonly IAlimentosRepository _alimentoRepository;
        public AtualizarAlimentoHandler(IAlimentosRepository alimentosRepository)
        {
            _alimentoRepository = alimentosRepository;
        }

        public Task<ResultadoBase> Handle(AtualizarAlimentoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new ResultadoBase();
            try
            {
                var alimento = _alimentoRepository.GetById(request.IdAlimento);
                if (alimento == null)
                {
                    retorno.Sucesso = false;
                    retorno.StatusCode = 400;
                    retorno.MensagemSucesso = "Nenhum alimento encontrado";
                    return Task.FromResult(retorno);
                }

                alimento.NomeAlimento = request.NomeAlimento;
                alimento.ValorCalorico = request.ValorCalorico != null ? request.ValorCalorico.Value : alimento.ValorCalorico;
                alimento.ValorNutricional = request.ValorNutricional != null ? request.ValorNutricional.Value : alimento.ValorNutricional;
                alimento.Descricao = request.Descricao;
                alimento.IdAlimentoSimilar1 = request.IdAlimentoSimilar1;
                alimento.IdAlimentoSimilar2 = request.IdAlimentoSimilar2;
                alimento.IdAlimentoSimilar3 = request.IdAlimentoSimilar3;
                _alimentoRepository.Update(alimento);
                _alimentoRepository.SaveChanges();

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = $"Alimento cadastrado com sucesso.";
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