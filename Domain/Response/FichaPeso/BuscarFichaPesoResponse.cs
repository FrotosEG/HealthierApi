namespace Domain.Response.FichaPeso
{
    public class BuscarFichaPesoResponse : ResultadoBase
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
