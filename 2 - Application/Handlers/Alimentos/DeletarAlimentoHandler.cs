using Domain.Command.Alimentos;
using Domain.Interfaces;
using Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Application.Handlers.Alimentos
{
    public class DeletarAlimentoHandler : IRequestHandler<DeletarAlimentoCommand, ResultadoBase>
    {
        private readonly IAlimentosRepository _alimentoRepository;
        public DeletarAlimentoHandler(IAlimentosRepository alimentosRepository)
        {
            _alimentoRepository = alimentosRepository;
        }

        public Task<ResultadoBase> Handle(DeletarAlimentoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new ResultadoBase();
            try
            {
                _alimentoRepository.Delete(request.IdAlimento);
                _alimentoRepository.SaveChanges();

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = "Alimento deletado com sucesso";
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.StatusCode = 500;
                retorno.MensagemSucesso = $"Exception: {ex}, inner:{ex.InnerException?.Message}";
            }

            return Task.FromResult(retorno);
        }
    }
}
