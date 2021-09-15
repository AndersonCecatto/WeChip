using CrediOferta.Domain;
using CrediOferta.Domain.Enum;
using CrediOferta.Infra.Repositorio;
using System.Collections.Generic;
using System.Text;

namespace CrediOferta.Service.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly IRepositorioBase _repositorioBase;

        public ClienteRepositorio(IRepositorioBase repositorioBase) => _repositorioBase = repositorioBase;

        public IEnumerable<ClientePesquisa> BuscarClientes()
        {
            var consulta = new StringBuilder();
            consulta.AppendLine("SELECT ");
            consulta.AppendLine("   Cliente.Id,");
            consulta.AppendLine("   Cliente.Nome,");
            consulta.AppendLine("   Cliente.Cpf,");
            consulta.AppendLine("   Cliente.Credito,");
            consulta.AppendLine("   Cliente.Telefone,");
            consulta.AppendLine("   Status.Descricao");
            consulta.AppendLine("FROM Cliente");
            consulta.AppendLine("INNER JOIN Status ON Cliente.Id_Status = Status.Id");
            consulta.AppendLine("WHERE Status.FinalizaCliente <> 1 AND Status.ContabilizaVenda <> 1");

            return _repositorioBase.BuscarTodos<ClientePesquisa>(consulta.ToString());
        }

        public IEnumerable<EnderecoEntrega> BuscarEnderecoEntregaCliente(int codigoCliente)
        {
            var consulta = new StringBuilder();
            consulta.AppendLine("SELECT EnderecoEntrega.* FROM EnderecoEntrega ");
            consulta.AppendLine("INNER JOIN Cliente ON Cliente.Id = EnderecoEntrega.Id_Cliente ");
            consulta.AppendLine($"WHERE Cliente.Id = {codigoCliente}");

            return _repositorioBase.BuscarTodos<EnderecoEntrega>(consulta.ToString());
        }

        public void AlterarStatus(StatusContato status, int codigoCliente)
            => _repositorioBase.ExecutarComando($"UPDATE Cliente SET Id_Status = {(int)status} WHERE Cliente.Id = {codigoCliente}");

        public int Inserir<T>(T entidade) where T : class
            => _repositorioBase.Inserir(entidade);

        public void AlterarEnderecoEntrega(EnderecoEntrega entidade)
        {
            var alterar = new StringBuilder();
            alterar.AppendLine($"UPDATE EnderecoEntrega SET ");
            alterar.AppendLine($"Rua = '{entidade.Rua}', Bairro = '{entidade.Bairro}', Numero = '{entidade.Numero}',");
            alterar.AppendLine($"Cep = '{entidade.Cep}', Cidade = '{entidade.Cidade}', Estado = '{entidade.Estado}', Complemento = '{entidade.Complemento}'");
            alterar.AppendLine($"WHERE id = {entidade.Id}");

            _repositorioBase.ExecutarComando(alterar.ToString());
        }

        public void AlterarCliente(Cliente cliente)
        {
            var alterar = new StringBuilder();
            alterar.AppendLine($"UPDATE Cliente SET ");
            alterar.AppendLine($"Nome = '{cliente.Nome}', Cpf = '{cliente.Cpf}', Credito = {cliente.Credito.ToString().Replace(',', '.')}, Telefone = '{cliente.Telefone}'");
            alterar.AppendLine($"WHERE id = {cliente.Id}");

            _repositorioBase.ExecutarComando(alterar.ToString());
        }
    }
}
