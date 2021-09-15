using CrediOferta.Domain;
using CrediOferta.Service.Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrediOferta.View
{
    public partial class frmPesquisaCliente : Form
    {
        private readonly ClienteServico _clienteServico;

        public frmPesquisaCliente()
        {
            try
            {
                InitializeComponent();
                _clienteServico = new ClienteServico();
                dgvClientes.DataSource = BuscarClientes();

                if (dgvClientes.Rows.Count > 0)
                    dgvClientes_CellClick(new { }, new DataGridViewCellEventArgs(0,0));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<ClientePesquisa> BuscarClientes()
        => _clienteServico.BuscarClientes();

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvEnderecoEntrega.DataSource = _clienteServico.BuscarEnderecoEntregaCliente((int)dgvClientes.Rows[e.RowIndex].Cells["Codigo"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Generic.ClientePesquisa = null;
            Generic.EnderecoEntrega = null;

            Generic.ClientePesquisa = new ClientePesquisa
            {
                Id = (int)dgvClientes.Rows[e.RowIndex].Cells["Codigo"].Value,
                Cpf = dgvClientes.Rows[e.RowIndex].Cells["Cpf"].Value.ToString(),
                Credito = (double)dgvClientes.Rows[e.RowIndex].Cells["Credito"].Value,
                Descricao = dgvClientes.Rows[e.RowIndex].Cells["Descricao"].Value.ToString(),
                Nome = dgvClientes.Rows[e.RowIndex].Cells["Nome"].Value.ToString(),
                Telefone = dgvClientes.Rows[e.RowIndex].Cells["Telefone"].Value.ToString()
            };

            if (dgvEnderecoEntrega.Rows.Count > 0)
                Generic.EnderecoEntrega = new EnderecoEntrega
                {
                    Id = (int)dgvEnderecoEntrega.Rows[0].Cells["Código"].Value,
                    Bairro = dgvEnderecoEntrega.Rows[0].Cells["Bairro"].Value.ToString(),
                    Cep = dgvEnderecoEntrega.Rows[0].Cells["Cep"].Value.ToString(),
                    Cidade = dgvEnderecoEntrega.Rows[0].Cells["Cidade"].Value.ToString(),
                    Complemento = dgvEnderecoEntrega.Rows[0].Cells["Complemento"].Value.ToString(),
                    Estado = dgvEnderecoEntrega.Rows[0].Cells["Estado"].Value.ToString(),
                    Numero = dgvEnderecoEntrega.Rows[0].Cells["Numero"].Value.ToString(),
                    Rua = dgvEnderecoEntrega.Rows[0].Cells["Rua"].Value.ToString()
                };

            this.Close();
        }

        private void frmPesquisaCliente_FormClosed(object sender, FormClosedEventArgs e)
         => new frmCliente();
    }
}
