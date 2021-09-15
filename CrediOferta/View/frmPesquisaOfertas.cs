using CrediOferta.Domain;
using CrediOferta.Service.Negocios;
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
    public partial class frmPesquisaOfertas : Form
    {
        private readonly ProdutoServico _produtoServico;

        public frmPesquisaOfertas()
        {
            InitializeComponent();
            _produtoServico = new ProdutoServico();
            BuscarProdutos();
            btnVincular.Enabled = false;
        }

        public void BuscarProdutos()
            => dgvOfertas.DataSource = _produtoServico.BuscarProdutos();

        private void dgvOfertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvOfertas.Rows[e.RowIndex].Cells["Selecionar"].Value = !(bool)(dgvOfertas.Rows[e.RowIndex].Cells["Selecionar"].Value ?? false);

                btnVincular.Enabled = HabilitarVinculoCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma oferta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool HabilitarVinculoCliente()
        {
            foreach (DataGridViewRow row in dgvOfertas.Rows)
            {
                row.Cells["Selecionar"].Value = row.Cells["Selecionar"].Value ?? false;

                if ((bool)row.Cells["Selecionar"].Value == true)
                    return true;
            }

            return false;
        }
        private void btnVincular_Click(object sender, EventArgs e)
        {
            var produtos = new List<Produto>();

            foreach (DataGridViewRow row in dgvOfertas.Rows)
            {
                row.Cells["Selecionar"].Value = row.Cells["Selecionar"].Value ?? false;

                if ((bool)row.Cells["Selecionar"].Value == true)
                    produtos.Add(new Produto
                    {
                        Id = (int)row.Cells["Id"].Value,
                        CodigoProduto = (int)row.Cells["CodigoProduto"].Value,
                        Descricao = row.Cells["Descricao"].Value.ToString(),
                        Preco = (double)row.Cells["Preco"].Value,
                        Tipo = row.Cells["Tipo"].Value.ToString()
                    });
            }

            Generic.Produtos = produtos;
            this.Close();
        }

        private void frmPesquisaOfertas_FormClosed(object sender, FormClosedEventArgs e)
        => new frmCliente();
    }
}
