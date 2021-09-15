using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace CrediOferta.Infra.Repositorio
{
    public class RepositorioBase : IRepositorioBase
    {
        public SQLiteConnection ConexaoBanco { get; private set; }

        public RepositorioBase()
        {
            this.ConexaoBanco = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CrediOferta"].ConnectionString);
            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.SqliteDialect();
        }

        private void OpenConnection()
        {
            if (ConexaoBanco.State == ConnectionState.Closed && ConexaoBanco.State != ConnectionState.Open)
                ConexaoBanco.Open();
        }

        public IEnumerable<T> BuscarTodos<T>(string query)
        {
            OpenConnection();

            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            return Dapper.SqlMapper.Query<T>(ConexaoBanco, query);
        }

        private void CloseConnection()

        {
            if (ConexaoBanco.State == ConnectionState.Open)
            {
                ConexaoBanco.Close();
                ConexaoBanco.Dispose();
            }
        }

        public void ExecutarComando(string comandoSQL)
        {

            if (comandoSQL.Trim() == "")
                return;

            OpenConnection();
            var comando = ConexaoBanco.CreateCommand();
            comando.Connection = ConexaoBanco;
            comando.CommandText = comandoSQL;
            comando.CommandTimeout = 0;
            comando.ExecuteNonQuery();
        }

        public void Dispose()
            => CloseConnection();

        public int Inserir<T>(T entidade) where T : class
        {
            OpenConnection();
            int.TryParse(ConexaoBanco.Insert(entidade).ToString(), out int retorno);
            return retorno;
        }
    }
}