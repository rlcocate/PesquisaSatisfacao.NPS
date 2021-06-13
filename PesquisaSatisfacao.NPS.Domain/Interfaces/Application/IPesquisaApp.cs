using PesquisaSatisfacao.NPS.Domain.Entities;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.Domain.Interfaces.Application
{
    public interface IPesquisaApp
    {
        Task<Pesquisa> Obter(int id);
    }
}
