using System;

namespace PesquisaSatisfacao.NPS.Domain.Entities
{
    public class Pesquisa
    {
        public int CodPesquisa { get; set; }
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public string Protocolo { get; set; }
        public Int16 Nivel { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
