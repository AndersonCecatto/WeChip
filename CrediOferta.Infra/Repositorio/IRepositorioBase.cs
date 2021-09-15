using System;
using System.Collections.Generic;

namespace CrediOferta.Infra.Repositorio
{
    public interface IRepositorioBase : IDisposable
    {
        IEnumerable<T> BuscarTodos<T>(string query);
        int Inserir<T>(T entidade) where T : class;
        void ExecutarComando(string comandoSQL);
    }
}
