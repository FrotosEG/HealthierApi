using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class FichaAlimentacaoRepository : RepositoryBase<FichaAlimentacaoModel, long>, IFichaAlimentacaoRepository
    {
        private readonly IUnitOfWork<DbContext> _unitOfWork;
        public FichaAlimentacaoRepository(DbContext context, IUnitOfWork<DbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
