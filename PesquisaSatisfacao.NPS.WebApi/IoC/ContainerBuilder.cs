using Microsoft.Extensions.DependencyInjection;
using PesquisaSatisfacao.NPS.Application;
using PesquisaSatisfacao.NPS.Data.Context;
using PesquisaSatisfacao.NPS.Data.Repositories;
using PesquisaSatisfacao.NPS.Data.UoW;
using PesquisaSatisfacao.NPS.Domain.Interfaces.Application;
using PesquisaSatisfacao.NPS.Domain.Interfaces.Repository;
using PesquisaSatisfacao.NPS.Domain.Interfaces.UoW;

namespace PesquisaSatisfacao.NPS.WebApi.IoC
{
    public static class ContainerBuilder
    {
        public static IServiceCollection Services { get; set; }

        public static void ApplicationRegister()
        {
            Services.AddTransient<IPesquisaApp, PesquisaApp>();
        }

        public static void DomainRegister()
        {
            Services.AddTransient<IPesquisaRepository, PesquisaRepository>();
        }

        public static void InfrasctrutureRegister()
        {
            Services.AddScoped<DataContext>();
            Services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
