using Domain.Command.FichaPeso;
using Domain.Interfaces;
using Domain.Response;
using MediatR;

namespace _2___Application.Handlers.FichaPeso
{
    public class DeletarFichaPesoHandler : IRequestHandler<DeletarFichaPesoCommand, ResultadoBase>
    {
        private readonly IFichaPesoRepository _fichaPesoRepository;
        public DeletarFichaPesoHandler(IFichaPesoRepository fichaPesoRepository)
        {
            _fichaPesoRepository = fichaPesoRepository;
        }

        public Task<ResultadoBase> Handle(DeletarFichaPesoCommand request, CancellationToken cancellationToken)
        {
            var retorno = new ResultadoBase();
            try
            {
                var fichaPeso = _fichaPesoRepository.GetById(request.IdFichaPeso);
                if(fichaPeso == null)
                {
                    retorno.Sucesso = false;
                    retorno.StatusCode = 400;
                    retorno.MensagemSucesso = "Não foi possível encontrar uma ficha com esse Id";
                    return Task.FromResult(retorno);
                }
                _fichaPesoRepository.Delete(request.IdFichaPeso);
                _fichaPesoRepository.SaveChanges();

                retorno.Sucesso = true;
                retorno.StatusCode = 200;
                retorno.MensagemSucesso = "Ficha de peso atualizada com sucesso.";
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
