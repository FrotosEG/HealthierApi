using Domain.Entities;

namespace Domain.Models
{
    public class UsuarioModel : BaseEntity<long>
    {
        public string? Nome{ get; set; }
        public string? Cpf { get; set; }
        public string? TelefoneDDD { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public short Premium { get; set; }
        public string? SenhaCriptografada { get; set; }
    }
}
