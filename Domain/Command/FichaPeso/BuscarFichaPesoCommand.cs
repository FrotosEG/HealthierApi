using Domain.Response.FichaPeso;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command.FichaPeso
{
    public class BuscarFichaPesoCommand : IRequest<BuscarFichaPesoResponse>
    {
        public long IdFichaPeso { get; set; }
    }
}
