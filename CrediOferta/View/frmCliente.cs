using CrediOferta.Domain;
using CrediOferta.Domain.Enum;
using CrediOferta.Service.Negocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrediOferta.View
{
    public partial class frmCliente : Form
    {
        private readonly ClienteServico _clienteServico;

        public frmCliente()
        {
            InitializeComponent();
            _clienteServico = new ClienteServico();
            btnOferta.Enabled = false;
            btnFinalizar.Enabled = false;
            btnNovo_Click(new { }, new EventArgs());
        }

        private void InicializarCliente()
        {
            if (Generic.ClientePesquisa is null)
                return;

            lblCodigo.Text = Generic.ClientePesquisa.Id.ToString();
            lblCodigo.Visible = true;

            lblStatus.Text = Generic.ClientePesquisa.Descricao;
            lblStatus.Visible = true;

            txtNome.Text = Generic.ClientePesquisa.Nome;
            txtCpf.Text = Generic.ClientePesquisa.Cpf;
            txtTelefone.Text = Generic.ClientePesquisa.Telefone;
            txtCredito.Text = Generic.ClientePesquisa.Credito.ToString("N");
        }

        private void InicializarEnderecoEntrega()
        {
            if (Generic.EnderecoEntrega is null)
                return;

            lblEnderecoEntrega.Text = Generic.EnderecoEntrega.Id.ToString();
            txtCep.Text = Generic.EnderecoEntrega.Cep;
            txtRua.Text = Generic.EnderecoEntrega.Rua;
            txtNumero.Text = Generic.EnderecoEntrega.Numero;
            txtComplemento.Text = Generic.EnderecoEntrega.Complemento;
            txtBairro.Text = Generic.EnderecoEntrega.Bairro;
            txtCidade.Text = Generic.EnderecoEntrega.Cidade;
            txtEstado.Text = Generic.EnderecoEntrega.Estado;
        }

        private void PopularGridProdutos()
        {
            if (Generic.Produtos is null)
                return;

            dgvProdutosVinculados.DataSource = Generic.Produtos;
            btnFinalizar.Enabled = true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            new frmPesquisaCliente().ShowDialog();
            LimparCampos();
            InicializarCliente();
            InicializarEnderecoEntrega();
            dgvProdutosVinculados.DataSource = new List<Produto>();
            dgvProdutosVinculados.Refresh();

            if (lblCodigo.Text != "0000")
                btnOferta.Enabled = true;
        }

        private void LimparCampos()
        {
            txtCep.Text = string.Empty;
            txtRua.Text  = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            lblCodigo.Visible = false;
            lblStatus.Visible = false;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = false;
            LimparCampos();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            new frmPesquisaOfertas().ShowDialog();
            PopularGridProdutos();
            tabComponentes.SelectedTab = tabProdutosVinculados;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            dgvProdutosVinculados.DataSource = new List<Produto>(); ;
            dgvProdutosVinculados.Refresh();
            btnOferta.Enabled = false;
            btnFinalizar.Enabled = false;
            tabComponentes.SelectedTab = tabCadastro;
            errorProvider.Clear();
        }

        private bool ValidarCamposVazios(Control control, ErrorProvider error)
        {
            error.Clear();
            if (control.Text != "")
                return false;
            else
            {
                error.SetError(control, $"Campo {control.Name} é Obrigatório!");
                control.Focus();
                return true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposVazios(txtNome, errorProvider))
                    return;
                if (ValidarCamposVazios(txtCpf, errorProvider))
                    return;
                if (ValidarCamposVazios(txtTelefone, errorProvider))
                    return;

                SalvarCliente();

                MessageBox.Show("Salvo com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um Erro! \n{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarCliente()
        {
            var id = 0;

            if (lblCodigo.Text.Equals("0000"))
                id = _clienteServico.Inserir(new Cliente
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Telefone = txtTelefone.Text,
                    Id_Status = 1,
                    //Adicionado numero Randomico para simular o credito do cliente
                    Credito = new Random().Next(1000)
                });
            else
                _clienteServico.AlterarCliente(new Cliente
                {
                    Id = Convert.ToInt32(lblCodigo.Text),
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Telefone = txtTelefone.Text,
                    Id_Status = 1
                });

            SalvarEnderecoEntrega(id);
        }

        private void SalvarEnderecoEntrega(int codigoCliente)
        {
            if (!VerificarEnderecoEntrega())
                return;

            if (codigoCliente == 0)
                codigoCliente = Convert.ToInt32(lblCodigo.Text);

            if (lblEnderecoEntrega.Text.Equals("0000"))
                _clienteServico.Inserir(new EnderecoEntrega
                {
                    Id_Cliente = codigoCliente,
                    Bairro = txtBairro.Text,
                    Cep = txtCep.Text,
                    Cidade = txtCidade.Text,
                    Complemento = txtComplemento.Text,
                    Estado = txtComplemento.Text,
                    Numero = txtNumero.Text,
                    Rua = txtRua.Text
                });
            else
                _clienteServico.AlterarEnderecoEntrega(new EnderecoEntrega
                {
                    Id = Convert.ToInt32(lblEnderecoEntrega.Text),
                    Bairro = txtBairro.Text,
                    Cep = txtCep.Text,
                    Cidade = txtCidade.Text,
                    Complemento = txtComplemento.Text,
                    Estado = txtComplemento.Text,
                    Numero = txtNumero.Text,
                    Rua = txtRua.Text
                });
        }

        private bool VerificarEnderecoEntrega()
        {
            foreach (Control control in tabComponentes.TabPages)
            {
                if (control.Name.Equals("tabEnderecoEntrega"))
                    foreach (Control page in control.Controls)
                    {
                        if (page.GetType().Name.Equals("TextBox") && page.Text != "")
                            return true;
                    }
            }

            return false;
        }

        private bool ValidarCamposEnderecoEntrega()
        {
            if (ValidarCamposVazios(txtCep, errorProvider))
                return true;
            if (ValidarCamposVazios(txtRua, errorProvider))
                return true;
            if (ValidarCamposVazios(txtNumero, errorProvider))
                return true;
            if (ValidarCamposVazios(txtComplemento, errorProvider))
                return true;
            if (ValidarCamposVazios(txtBairro, errorProvider))
                return true;
            if (ValidarCamposVazios(txtCidade, errorProvider))
                return true;
            if (ValidarCamposVazios(txtEstado, errorProvider))
                return true;

            return false;
        }

        //Verifica se existe um produto do tipo HARDWARE para validar se os campos endereco de Entrega estao preenchidos.
        private bool ValidarFinalizacao()
        {
            foreach (DataGridViewRow row in dgvProdutosVinculados.Rows)
            {
                if (row.Cells["Tipo"].Value.ToString().Equals("HARDWARE") && ValidarCamposEnderecoEntrega())
                {
                    MessageBox.Show($"Existe campos não preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabComponentes.SelectedTab = tabEnderecoEntrega;
                    return true;
                }
            }

            if (VerificarValores())
            {
                MessageBox.Show($"Valor Maior que o permitido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            dgvProdutosVinculados.DataSource = new List<Produto>();
            dgvProdutosVinculados.Refresh();
            return false;
        }

        //Valida se a soma dos valores dos itens em tela são maiores que o credito.
        private bool VerificarValores()
        {
            double valor = 0;

            foreach (DataGridViewRow row in dgvProdutosVinculados.Rows)
                valor += (double)row.Cells["Preco"].Value;

            return valor > Convert.ToDouble(txtCredito.Text);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarFinalizacao())
                return;

            _clienteServico.AlterarStatus(StatusContato.ClienteAceitouOferta, Convert.ToInt32(lblCodigo.Text));

            MessageBox.Show("Finalizada com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo_Click(sender, new EventArgs());
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void btnVendas_Click(object sender, EventArgs e)
        {
            new frmPesquisaVendas().ShowDialog();
        }
    }
}
