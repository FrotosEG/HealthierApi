using Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command.Alimentos
{
    public class DeletarAlimentoCommand : IRequest<ResultadoBase>
    {
        public long IdAlimento{ get; set; }
    }
}
