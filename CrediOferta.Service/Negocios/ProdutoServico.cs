using CrediOferta.Domain;
using CrediOferta.Infra.Repositorio;
using CrediOferta.Service.Repositorio;
using System.Collections.Generic;

namespace CrediOferta.Service.Negocios
{
    public class ProdutoServico
    {
        private readonly ProdutoRepositorio _produtoRepositorio;
        public ProdutoServico() => _produtoRepositorio = new ProdutoRepositorio(new RepositorioBase());

        public IEnumerable<Produto> BuscarProdutos()
            => _produtoRepositorio.BuscarProdutos();
    }
}
