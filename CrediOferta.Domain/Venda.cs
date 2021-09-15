namespace CrediOferta.Domain
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Cliente { get; set; }
        public string Cpf { get; set; }
        public double ValorTotal { get; set; }
        public int CodigoOferta { get; set; }
    }
}
