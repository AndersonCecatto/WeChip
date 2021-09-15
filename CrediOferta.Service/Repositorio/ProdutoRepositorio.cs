using CrediOferta.Domain;
using CrediOferta.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediOferta.Service.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly IRepositorioBase _repositorioBase;

        public ProdutoRepositorio(IRepositorioBase repositorioBase) => _repositorioBase = repositorioBase;

        public IEnumerable<Produto> BuscarProdutos()
        => _repositorioBase.BuscarTodos<Produto>("SELECT * FROM Produto");
        
    }
}
