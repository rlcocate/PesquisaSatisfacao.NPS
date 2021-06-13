using Dapper.FluentMap.Dommel.Mapping;
using PesquisaSatisfacao.NPS.Domain.Entities;

namespace PesquisaSatisfacao.NPS.Data.Mappings
{
    public class PesquisaMap : DommelEntityMap<Pesquisa>
    {
        public PesquisaMap()
        {
            Map(m => m.CodPesquisa).IsIdentity().IsKey();
        }
    }
}
