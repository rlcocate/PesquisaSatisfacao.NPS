using Dapper.FluentMap.Dommel.Mapping;
using PesquisaSatisfacao.NPS.Domain.Entities;

namespace PesquisaSatisfacao.NPS.Data.Mappings
{
    public class DadosClienteMap : DommelEntityMap<DadosCliente>
    {
        public DadosClienteMap()
        {
            Map(m => m.CodDadosCliente).IsIdentity().IsKey();
        }
    }
}
