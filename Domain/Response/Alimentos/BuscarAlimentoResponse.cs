using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Response.Alimentos
{
    public class BuscarAlimentoResponse : ResultadoBase
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
