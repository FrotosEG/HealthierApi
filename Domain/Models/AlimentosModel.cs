using Domain.Entities;

namespace Domain.Models
{
    public class AlimentosModel : BaseEntity<long>
    {
        public string? NomeAlimento { get; set; }
        public decimal ValorCalorico { get; set; }
        public decimal ValorNutricional { get; set; }
        public string? Descricao { get; set; }
        public long? IdAlimentoSimilar1 { get; set; }
        public long? IdAlimentoSimilar2 { get; set; }
        public long? IdAlimentoSimilar3 { get; set; }

    }
}
