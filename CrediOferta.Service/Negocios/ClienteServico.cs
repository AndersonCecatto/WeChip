using CrediOferta.Domain;
using CrediOferta.Domain.Enum;
using CrediOferta.Infra.Repositorio;
using CrediOferta.Service.Repositorio;
using System.Collections.Generic;

namespace CrediOferta.Service.Negocios
{
    public class ClienteServico
    {
        private readonly ClienteRepositorio _clienteRepositorio;

        public ClienteServico()
        {
            _clienteRepositorio = new ClienteRepositorio(new RepositorioBase());
        }

        public int Inserir<T>(T entidade) where T : class
            => _clienteRepositorio.Inserir(entidade);

        public void AlterarEnderecoEntrega(EnderecoEntrega entidade)
            => _clienteRepositorio.AlterarEnderecoEntrega(entidade);

        public void AlterarCliente(Cliente entidade)
            => _clienteRepositorio.AlterarCliente(entidade);

        public IEnumerable<ClientePesquisa> BuscarClientes()
            => _clienteRepositorio.BuscarClientes();

        public IEnumerable<EnderecoEntrega> BuscarEnderecoEntregaCliente(int codigoCliente)
            => _clienteRepositorio.BuscarEnderecoEntregaCliente(codigoCliente);

        public void AlterarStatus(StatusContato status, int codigoCliente)
            => _clienteRepositorio.AlterarStatus(status, codigoCliente);
    }
}
