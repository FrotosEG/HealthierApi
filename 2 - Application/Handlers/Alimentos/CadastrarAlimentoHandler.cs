using Domain.Command.Alimentos;
using Domain.Interfaces;
using Domain.Models;
using Domain.Response.Alimentos;
using MediatR;

namespace _2___Application.Handlers.Alimentos
{
    public class CadastrarAlimentoHandler : IRequestHandler<CadastrarAlimentoCommand, CadastrarAlimentosResponse>
    {
        private readonly IAlimentosRepository _alimentosRepository;
        public CadastrarAlimentoHandler(IAlimentosRepository alimentosRepository)
        {
            _alimentosRepository = alimentosRepository;
        }

        public Task<CadastrarAlimentosResponse> Handle(CadastrarAlimentoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new CadastrarAlimentosResponse();
            try
            {
                var alimentoModel = new AlimentosModel();
                alimentoModel.NomeAlimento = request.NomeAlimento;
                alimentoModel.ValorCalorico = request.ValorCalorico;
                alimentoModel.ValorNutricional = request.ValorNutricional;
                alimentoModel.Descricao = request.Descricao;
                alimentoModel.IdAlimentoSimilar1 = request.IdAlimentoSimilar1 == 0 ? null : request.IdAlimentoSimilar1;
                alimentoModel.IdAlimentoSimilar2 = request.IdAlimentoSimilar2 == 0 ? null : request.IdAlimentoSimilar2;
                alimentoModel.IdAlimentoSimilar3 = request.IdAlimentoSimilar3 == 0 ? null : request.IdAlimentoSimilar3;
                _alimentosRepository.Insert(alimentoModel);
                _alimentosRepository.SaveChanges();

                retorno.Id = alimentoModel.id; ;
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
