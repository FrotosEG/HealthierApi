using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Response
{
    public class BuscarUsuarioResponse : ResultadoBase
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? TelefoneDDD { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public short? Premium { get; set; }
    }
}
