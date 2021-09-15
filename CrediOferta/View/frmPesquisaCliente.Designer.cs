
namespace CrediOferta.View
{
    partial class frmPesquisaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvEnderecoEntrega = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecoEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Cpf,
            this.Credito,
            this.Telefone,
            this.Descricao,
            this.id_status});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(1284, 659);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // dgvEnderecoEntrega
            // 
            this.dgvEnderecoEntrega.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEnderecoEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecoEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Rua,
            this.Bairro,
            this.Numero,
            this.Complemento,
            this.Cep,
            this.Cidade,
            this.Estado});
            this.dgvEnderecoEntrega.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEnderecoEntrega.Location = new System.Drawing.Point(0, 509);
            this.dgvEnderecoEntrega.Name = "dgvEnderecoEntrega";
            this.dgvEnderecoEntrega.ReadOnly = true;
            this.dgvEnderecoEntrega.Size = new System.Drawing.Size(1284, 150);
            this.dgvEnderecoEntrega.TabIndex = 3;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Id";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 80;
            // 
            // Rua
            // 
            this.Rua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rua.DataPropertyName = "Rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 80;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "Complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 80;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cpf.Width = 120;
            // 
            // Credito
            // 
            this.Credito.DataPropertyName = "Credito";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Credito.DefaultCellStyle = dataGridViewCellStyle1;
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefone.Width = 120;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Status";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id_status
            // 
            this.id_status.DataPropertyName = "id_status";
            this.id_status.HeaderText = "id_status";
            this.id_status.Name = "id_status";
            this.id_status.ReadOnly = true;
            this.id_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_status.Visible = false;
            // 
            // frmPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 659);
            this.Controls.Add(this.dgvEnderecoEntrega);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmPesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesquisaCliente_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecoEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvEnderecoEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status;
    }
}