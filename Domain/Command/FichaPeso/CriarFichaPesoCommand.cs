using Domain.Response.FichaPeso;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command.FichaPeso
{
    public class CriarFichaPesoCommand : IRequest<CriarFichaPesoResponse>
    {
        public long IdUsuario { get; set; }
        public decimal? PesoUsuarioNaCriacao { get; set; }
        public short TipoObjetivoUsuario { get; set; }
        public decimal AlturaUsuario { get; set; }
        public decimal PesoDesejadoUsuario { get; set; }
        public decimal CinturaUsuario { get; set; }
        public long? IdFichaAlimentacao { get; set; }
        public decimal FrequenciaAlimentar { get; set; }
        public short IdAlergia1 { get; set; }
        public short IdAlergia2 { get; set; }
        public short IdAlergia3 { get; set; }
        public short IdAlergia4 { get; set; }
        public short IdAlergia5 { get; set; }
    }
}
