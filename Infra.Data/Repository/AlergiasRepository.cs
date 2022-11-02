using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class AlergiasRepository : RepositoryBase<AlergiasModel, short>, IAlergiasRepository
    {
        private readonly IUnitOfWork<DbContext> _unitOfWork;
        public AlergiasRepository(DbContext context, IUnitOfWork<DbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
