using System;

namespace PesquisaSatisfacao.NPS.Domain.Entities
{
    public class DadosCliente
    {
        public int CodDadosCliente { get; set; }
        public int CodPesquisa { get; set; }
        public Decimal Protocolo { get; set; }
        public Byte Nivel { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
