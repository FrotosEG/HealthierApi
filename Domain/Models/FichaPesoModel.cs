using Domain.Entities;

namespace Domain.Models
{
    public class FichaPesoModel : BaseEntity<long>
    {
        public long IdUsuario { get; set; }
        public string? PesoUsuarioNaCriacao { get; set; }
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
        public virtual UsuarioModel? Usuario { get; set; }
        public virtual FichaAlimentacaoModel? FichaAlimentacao { get; set; }

    }
}
