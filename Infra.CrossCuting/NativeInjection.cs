using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCuting
{
    public static class NativeInjection
    {
        public static IServiceCollection InjetarDependenciasExtensions(this IServiceCollection services)
        {
            //Injeção dos repositórios
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            //Adicionando DB
            services.AddScoped<IUnitOfWork<DbContext>, UnitOfWork<DbContext>>();
            services.AddDbContextFactory<DbContext>();

            return services;
        }
    }
}
