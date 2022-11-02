using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class FichaPesoRepository : RepositoryBase<FichaPesoModel, long>, IFichaPesoRepository
    {
        private readonly IUnitOfWork<DbContext> _unitOfWork;
        public FichaPesoRepository(DbContext context, IUnitOfWork<DbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
