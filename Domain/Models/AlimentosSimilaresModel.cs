using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AlimentosSimilaresModel : BaseEntity<long>
    {
        public string? NomeAlimento { get; set; }
        public decimal ValorCalorico { get; set; }
        public decimal ValorNutricional { get; set; }
        public string? Descricao { get; set; }
        public string? MotivosParaSubstituirOutroAlimento { get; set; }
    }
}
