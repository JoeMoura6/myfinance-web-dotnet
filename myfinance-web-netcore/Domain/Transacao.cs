namespace myfinance_web_netcore.Domain
{
    public class Transacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal valor { get; set; }
        public string Historico { get; set; }
        public string Tipo { get; set; }
        public int PlanoContaId { get; set; }
    }
}