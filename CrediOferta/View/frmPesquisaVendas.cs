using CrediOferta.Service.Negocios;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrediOferta.View
{
    public partial class frmPesquisaVendas : Form
    {
        private readonly VendaServico _vendaServico;

        public frmPesquisaVendas()
        {
            InitializeComponent();
            _vendaServico = new VendaServico();

            var teste = _vendaServico.Executar(Method.GET, null, "/Produto/BuscarProdutos");
        }
    }
}
