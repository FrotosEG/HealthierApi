using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class AlimentosRepository : RepositoryBase<AlimentosModel, long>, IAlimentosRepository
    {
        private readonly IUnitOfWork<DbContext> _unitOfWork;
        public AlimentosRepository(DbContext context, IUnitOfWork<DbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
