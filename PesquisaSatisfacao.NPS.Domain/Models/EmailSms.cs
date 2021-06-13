namespace Daycoval.Nps.Worker.Model
{
    public class EmailSms
    {
        public int CodPesquisa { get; set; }
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public string Protocolo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string LocalEnvio { get; set; }
    }
}
