using PesquisaSatisfacao.NPS.Domain.Entities;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.Domain.Interfaces.Repository
{
    public interface IPesquisaRepository
    {
        Task Incluir(Pesquisa pesquisa);

        Task Alterar(Pesquisa pesquisa);

        Task<Pesquisa> Obter(int id);
    }
}
