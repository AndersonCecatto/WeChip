using CrediOferta.Domain;
using CrediOferta.Infra.Repositorio;
using System.Collections.Generic;
using System.Text;

namespace CrediOferta.Service.Repositorio
{
    public class VendaRepositorio
    {
        private readonly IRepositorioBase _repositorioBase;

        public VendaRepositorio(IRepositorioBase repositorioBase) => _repositorioBase = repositorioBase;

        public IEnumerable<Venda> BuscarVendas()
        {
            var consulta = new StringBuilder();
            consulta.AppendLine("SELECT");
            consulta.AppendLine("CLIENTEPRODUTO.Id, CLIENTE.NOME as Cliente,");
            consulta.AppendLine("CLIENTE.Cpf, PRODUTO.DESCRICAO as Produto,");
            consulta.AppendLine("ValorTotal, CodigoOferta");
            consulta.AppendLine("FROM CLIENTEPRODUTO");
            consulta.AppendLine("INNER JOIN CLIENTE ON CLIENTE.ID = CLIENTEPRODUTO.ID_CLIENTE");
            consulta.AppendLine("INNER JOIN PRODUTO ON CLIENTEPRODUTO.ID_PRODUTO");

            return _repositorioBase.BuscarTodos<Venda>(consulta.ToString());
        }
    }
}
