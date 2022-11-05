using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data.CrossCuting.Ioc
{
    public static class NativeInjection
    {
        public static IServiceCollection InjetarDependenciasExtensions(this IServiceCollection services)
        {
            //Injeção dos repositórios
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAlimentosRepository, AlimentosRepository>();
            services.AddScoped<IAlimentosSimilaresRepository, AlimentosSimilaresRepository>();
            services.AddScoped<IFichaAlimentacaoRepository, FichaAlimentacaoRepository>();
            services.AddScoped<IFichaPesoRepository, FichaPesoRepository>();
            services.AddScoped<IAlergiasRepository, AlergiasRepository>();

            //Adicionando DB
            services.AddScoped<IUnitOfWork<DbContext>, UnitOfWork<DbContext>>();
            services.AddDbContextFactory<DbContext>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
