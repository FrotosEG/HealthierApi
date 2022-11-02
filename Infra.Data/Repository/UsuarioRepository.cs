using Domain.Interfaces;
using Infra.Data.Context;
using Domain.Models;

namespace Infra.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<UsuarioModel, long>, IUsuarioRepository
    {
        private readonly IUnitOfWork<DbContext> _unitOfWork;
        public UsuarioRepository(DbContext context, IUnitOfWork<DbContext> unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
