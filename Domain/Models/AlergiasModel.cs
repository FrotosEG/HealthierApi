using Domain.Entities;

namespace Domain.Models
{
    public class AlergiasModel : BaseEntity<short>
    {
        public string? NomeAlergia { get; set; }
        public string? Descricao { get; set; }
        public string? Causas { get; set; }
    }
}
