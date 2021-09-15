using CrediOferta.Domain;
using CrediOferta.Infra.Repositorio;
using CrediOferta.Service.Repositorio;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediOferta.Service.Negocios
{
    public class VendaServico
    {
        private readonly VendaRepositorio _vendaRepositorio;
        private const string _url_api = "https://localhost:44386";
        private RestClient _api;

        public VendaServico()
        {
            _api = new RestClient(_url_api);
            _vendaRepositorio = new VendaRepositorio(new RepositorioBase());
        }

        public RestRequest Requisicao(Method method, object dados, string caminho)
        {
            var request = new RestRequest
            {
                Method = method,
                Timeout = -1,
                Resource = "https://localhost:44386"+caminho
            };

            if(!(dados is null))
            {
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", JsonConvert.SerializeObject(dados), ParameterType.RequestBody);
            }

            return request;
        }

        public object Executar(Method method, object dados, string caminho)
        {
            try
            {
                IRestResponse response = _api.Execute(Requisicao(method, dados, caminho));

                return response.Content;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Venda> BuscarVendas()
            => _vendaRepositorio.BuscarVendas();
    }
}
