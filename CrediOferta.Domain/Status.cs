using CrediOferta.Domain.Enum;

namespace CrediOferta.Domain
{
    public class Status
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Condicao FinalizaCliente { get; set; }
        public Condicao ContabilizaVenda { get; set; }
        public int CodigoStatus { get; set; }
    }
}
