using System.ComponentModel.DataAnnotations.Schema;

namespace CrediOferta.Domain
{
    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Credito { get; set; }
        public string Telefone { get; set; }
        public int Id_Status { get; set; }
    }
}
