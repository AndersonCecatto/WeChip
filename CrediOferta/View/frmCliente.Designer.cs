
namespace CrediOferta.View
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnOferta = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabComponentes = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabEnderecoEntrega = new System.Windows.Forms.TabPage();
            this.lblEnderecoEntrega = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.tabProdutosVinculados = new System.Windows.Forms.TabPage();
            this.dgvProdutosVinculados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabComponentes.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabEnderecoEntrega.SuspendLayout();
            this.tabProdutosVinculados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(380, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(77, 75);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(144, 20);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // txtCredito
            // 
            this.txtCredito.Enabled = false;
            this.txtCredito.Location = new System.Drawing.Point(77, 101);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(144, 20);
            this.txtCredito.TabIndex = 6;
            this.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(77, 127);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(144, 20);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnOferta);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 34);
            this.panel1.TabIndex = 9;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(342, 6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(81, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnOferta
            // 
            this.btnOferta.Location = new System.Drawing.Point(255, 6);
            this.btnOferta.Name = "btnOferta";
            this.btnOferta.Size = new System.Drawing.Size(81, 23);
            this.btnOferta.TabIndex = 3;
            this.btnOferta.Text = "Ofertar";
            this.btnOferta.UseVisualStyleBackColor = true;
            this.btnOferta.Click += new System.EventHandler(this.btnOferta_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(174, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(93, 6);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabComponentes
            // 
            this.tabComponentes.Controls.Add(this.tabCadastro);
            this.tabComponentes.Controls.Add(this.tabEnderecoEntrega);
            this.tabComponentes.Controls.Add(this.tabProdutosVinculados);
            this.tabComponentes.Location = new System.Drawing.Point(12, 50);
            this.tabComponentes.Name = "tabComponentes";
            this.tabComponentes.SelectedIndex = 0;
            this.tabComponentes.Size = new System.Drawing.Size(701, 295);
            this.tabComponentes.TabIndex = 11;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.tabCadastro.Controls.Add(this.lblStatus);
            this.tabCadastro.Controls.Add(this.label13);
            this.tabCadastro.Controls.Add(this.lblCodigo);
            this.tabCadastro.Controls.Add(this.label11);
            this.tabCadastro.Controls.Add(this.txtCredito);
            this.tabCadastro.Controls.Add(this.lblNome);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Controls.Add(this.txtTelefone);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.txtCpf);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(693, 269);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(251, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Status Atual";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(77, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(35, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Código";
            // 
            // tabEnderecoEntrega
            // 
            this.tabEnderecoEntrega.BackColor = System.Drawing.SystemColors.Control;
            this.tabEnderecoEntrega.Controls.Add(this.lblEnderecoEntrega);
            this.tabEnderecoEntrega.Controls.Add(this.label10);
            this.tabEnderecoEntrega.Controls.Add(this.txtEstado);
            this.tabEnderecoEntrega.Controls.Add(this.label9);
            this.tabEnderecoEntrega.Controls.Add(this.txtCidade);
            this.tabEnderecoEntrega.Controls.Add(this.label8);
            this.tabEnderecoEntrega.Controls.Add(this.txtBairro);
            this.tabEnderecoEntrega.Controls.Add(this.label7);
            this.tabEnderecoEntrega.Controls.Add(this.txtComplemento);
            this.tabEnderecoEntrega.Controls.Add(this.label6);
            this.tabEnderecoEntrega.Controls.Add(this.txtNumero);
            this.tabEnderecoEntrega.Controls.Add(this.label5);
            this.tabEnderecoEntrega.Controls.Add(this.txtRua);
            this.tabEnderecoEntrega.Controls.Add(this.label4);
            this.tabEnderecoEntrega.Controls.Add(this.txtCep);
            this.tabEnderecoEntrega.Location = new System.Drawing.Point(4, 22);
            this.tabEnderecoEntrega.Name = "tabEnderecoEntrega";
            this.tabEnderecoEntrega.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnderecoEntrega.Size = new System.Drawing.Size(693, 269);
            this.tabEnderecoEntrega.TabIndex = 1;
            this.tabEnderecoEntrega.Text = "Endereço de Entrega";
            // 
            // lblEnderecoEntrega
            // 
            this.lblEnderecoEntrega.AutoSize = true;
            this.lblEnderecoEntrega.Location = new System.Drawing.Point(94, 7);
            this.lblEnderecoEntrega.Name = "lblEnderecoEntrega";
            this.lblEnderecoEntrega.Size = new System.Drawing.Size(31, 13);
            this.lblEnderecoEntrega.TabIndex = 19;
            this.lblEnderecoEntrega.Text = "0000";
            this.lblEnderecoEntrega.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(94, 191);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(169, 20);
            this.txtEstado.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(94, 165);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(169, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(94, 139);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(169, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(94, 113);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(169, 20);
            this.txtComplemento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(94, 87);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(169, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(94, 61);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(169, 20);
            this.txtRua.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(94, 35);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(169, 20);
            this.txtCep.TabIndex = 6;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // tabProdutosVinculados
            // 
            this.tabProdutosVinculados.BackColor = System.Drawing.SystemColors.Control;
            this.tabProdutosVinculados.Controls.Add(this.dgvProdutosVinculados);
            this.tabProdutosVinculados.Location = new System.Drawing.Point(4, 22);
            this.tabProdutosVinculados.Name = "tabProdutosVinculados";
            this.tabProdutosVinculados.Size = new System.Drawing.Size(693, 269);
            this.tabProdutosVinculados.TabIndex = 2;
            this.tabProdutosVinculados.Text = "Produtos Vinculados";
            // 
            // dgvProdutosVinculados
            // 
            this.dgvProdutosVinculados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutosVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVinculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoProduto,
            this.Descricao,
            this.Preco,
            this.Tipo});
            this.dgvProdutosVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosVinculados.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutosVinculados.Name = "dgvProdutosVinculados";
            this.dgvProdutosVinculados.ReadOnly = true;
            this.dgvProdutosVinculados.Size = new System.Drawing.Size(693, 269);
            this.dgvProdutosVinculados.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "CodigoProduto";
            this.CodigoProduto.HeaderText = "Codigo";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 200;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(618, 40);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(95, 23);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.Text = "Listar Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(495, 40);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(102, 23);
            this.btnCadastrarProduto.TabIndex = 12;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 380);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.tabComponentes);
            this.Controls.Add(this.panel1);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.tabComponentes.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabEnderecoEntrega.ResumeLayout(false);
            this.tabEnderecoEntrega.PerformLayout();
            this.tabProdutosVinculados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabControl tabComponentes;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabEnderecoEntrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOferta;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TabPage tabProdutosVinculados;
        private System.Windows.Forms.DataGridView dgvProdutosVinculados;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Label lblEnderecoEntrega;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnVendas;
    }
}