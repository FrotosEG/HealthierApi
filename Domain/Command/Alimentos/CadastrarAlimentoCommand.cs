using Domain.Response;
using Domain.Response.Alimentos;
using MediatR;

namespace Domain.Command.Alimentos
{
    public class CadastrarAlimentoCommand : IRequest<CadastrarAlimentosResponse>
    {
        public string NomeAlimento { get; set; }
        public decimal ValorCalorico { get; set; }
        public decimal ValorNutricional { get; set; }
        public string Descricao { get; set; }
        public long IdAlimentoSimilar1 { get; set; }
        public long IdAlimentoSimilar2 { get; set; }
        public long IdAlimentoSimilar3 { get; set; }

    }
}
