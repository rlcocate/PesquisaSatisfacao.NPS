using System;
using System.Collections.Generic;
using System.Text;

namespace PesquisaSatisfacao.NPS.Domain.Entities
{
    public class Motivo
    {
        public Int16 CodMotivo { get; set; }
        public string Descricao { get; set; }
        public Int16 Ordenacao { get; set; }
    }
}
