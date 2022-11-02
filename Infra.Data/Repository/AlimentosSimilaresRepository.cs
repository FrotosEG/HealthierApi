using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class AlimentosSimilaresRepository : RepositoryBase<AlimentosSimilaresModel, long>, IAlimentosSimilaresRepository
    {
        private readonly IUnitOfWork<DbContext> _unitOfWork;
        public AlimentosSimilaresRepository(DbContext context, IUnitOfWork<DbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
