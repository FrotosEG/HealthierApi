using Domain.Entities;

namespace Domain.Models
{
    public class AlimentosModel : BaseEntity<long>
    {
        public string? NomeAlimento { get; set; }
        public decimal ValorCalorico { get; set; }
        public decimal ValorNutricional { get; set; }
        public string? Descricao { get; set; }
        public string? IdAlimentoSimilar1 { get; set; }
        public string? IdAlimentoSimilar2 { get; set; }
        public string? IdAlimentoSimilar3 { get; set; }

    }
}
