using PesquisaSatisfacao.NPS.Data.Context;
using PesquisaSatisfacao.NPS.Domain.Entities;
using PesquisaSatisfacao.NPS.Domain.Interfaces.Repository;
using RepositoryHelpers.DataBaseRepository;
using System;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.Data.Repositories
{
    public class PesquisaRepository : IPesquisaRepository
    {
        private readonly DataContext _context;
        private readonly CustomRepository<Pesquisa> _pesquisaRepository;
        private bool _disposed;

        public PesquisaRepository(DataContext context)
        {
            _context = context;
            _pesquisaRepository = new CustomRepository<Pesquisa>(_context.Connection);
        }

        public Task Alterar(Pesquisa pesquisa)
        {
            throw new NotImplementedException();
        }

        public Task Incluir(Pesquisa pesquisa)
        {
            throw new NotImplementedException();
        }

        public async Task<Pesquisa> Obter(int id)
        {
            // RepositoryHelpers (GetByIdAsync)
            return await _pesquisaRepository.GetByIdAsync(id, _context.Transaction);
        }

        ~PesquisaRepository() => Dispose();

        void Dispose()
        {
            if (!_disposed)
            {
                _pesquisaRepository.DisposeDB(true);
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }

    }
}
