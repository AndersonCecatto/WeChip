using System.ComponentModel.DataAnnotations.Schema;

namespace CrediOferta.Domain
{
    [Table("EnderecoEntrega")]
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public int Id_Cliente { get; set; }
    }
}
