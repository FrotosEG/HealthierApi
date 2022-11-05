using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Response
{
    public class ResultadoBase
    {
        public string MensagemSucesso { get; set; }
        public int StatusCode { get; set; }
        public bool Sucesso { get; set; }
    }
}
