using System;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();

        Task Rollback();
    }
}
