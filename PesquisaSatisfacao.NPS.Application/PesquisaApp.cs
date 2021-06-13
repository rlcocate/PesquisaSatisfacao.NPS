using PesquisaSatisfacao.NPS.Domain.Entities;
using PesquisaSatisfacao.NPS.Domain.Interfaces.Application;
using PesquisaSatisfacao.NPS.Domain.Interfaces.Repository;
using PesquisaSatisfacao.NPS.Domain.Interfaces.UoW;
using System;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.Application
{
    public class PesquisaApp : IPesquisaApp
    {
        private readonly IPesquisaRepository _pesquisaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PesquisaApp
        (
            IPesquisaRepository pesquisaRepository,
            IUnitOfWork unitOfWork
        )
        {
            _pesquisaRepository = pesquisaRepository;
            _unitOfWork = unitOfWork;
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
            return await _pesquisaRepository.Obter(id);
        }
    }
}
