using Domain.Command.Alimentos;
using Domain.Interfaces;
using Domain.Response.Alimentos;
using MediatR;

namespace _2___Application.Handlers.Alimentos
{
    public class BuscarAlimentoHandler : IRequestHandler<BuscarAlimentoCommand, BuscarAlimentoResponse>
    {
        private readonly IAlimentosRepository _alimentoRepository;
        public BuscarAlimentoHandler(IAlimentosRepository alimentosRepository)
        {
            _alimentoRepository = alimentosRepository;
        }

        public Task<BuscarAlimentoResponse> Handle(BuscarAlimentoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new BuscarAlimentoResponse();
            try
            {
                var alimento = _alimentoRepository.GetById(request.IdAlimento);
                if (alimento == null)
                {
                    retorno.Sucesso = false;
                    retorno.StatusCode = 400;
                    retorno.MensagemSucesso = "Nenhum alimento encontrado.";
                    return Task.FromResult(retorno);
                }

                retorno.NomeAlimento = alimento.NomeAlimento;
                retorno.ValorCalorico = alimento.ValorCalorico;
                retorno.ValorNutricional = alimento.ValorNutricional;
                retorno.Descricao = alimento.Descricao;
                retorno.IdAlimentoSimilar1 = alimento.IdAlimentoSimilar1;
                retorno.IdAlimentoSimilar2 = alimento.IdAlimentoSimilar2;
                retorno.IdAlimentoSimilar3 = alimento.IdAlimentoSimilar3;

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = "Alimento encontrado com sucesso.";

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
