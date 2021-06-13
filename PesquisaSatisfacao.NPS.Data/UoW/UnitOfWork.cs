using PesquisaSatisfacao.NPS.Data.Context;
using PesquisaSatisfacao.NPS.Domain.Interfaces.UoW;
using System;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            _context.Transaction.BeginTransaction();
        }

        public Task<bool> Commit()
        {
            bool success;
            try
            {
                _context.Transaction.CommitTransaction();
                success = true;

                // Dispatch domain events etc
            }
            catch (Exception ex)
            {
                // Log errors
                Rollback();
                success = false;
            }

            return Task.FromResult(success);
        }

        public Task Rollback()
        {
            _context.Transaction.RollbackTransaction();
            return Task.CompletedTask;
        }

        private bool _disposed = false;

        ~UnitOfWork() => Dispose();

        public void Dispose()
        {
            if (!_disposed)
                _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
