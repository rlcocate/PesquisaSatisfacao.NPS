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
        public static IServiceCollection _services { get; set; }

        public static void ApplicationRegister()
        {
            _services.AddTransient<IPesquisaApp, PesquisaApp>();
        }

        public static void DomainRegister()
        {
            _services.AddTransient<IPesquisaRepository, PesquisaRepository>();
        }

        public static void InfrasctrutureRegister()
        {
            _services.AddScoped<DataContext>();
            _services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
