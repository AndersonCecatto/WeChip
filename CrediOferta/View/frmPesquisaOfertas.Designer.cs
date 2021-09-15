
namespace CrediOferta.View
{
    partial class frmPesquisaOfertas
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
            this.dgvOfertas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVincular = new System.Windows.Forms.Button();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOfertas
            // 
            this.dgvOfertas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Id,
            this.CodigoProduto,
            this.Descricao,
            this.Preco,
            this.Tipo});
            this.dgvOfertas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOfertas.Location = new System.Drawing.Point(0, 48);
            this.dgvOfertas.Name = "dgvOfertas";
            this.dgvOfertas.ReadOnly = true;
            this.dgvOfertas.Size = new System.Drawing.Size(1050, 542);
            this.dgvOfertas.TabIndex = 0;
            this.dgvOfertas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfertas_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVincular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(879, 12);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(159, 23);
            this.btnVincular.TabIndex = 4;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Width = 50;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "CodigoProduto";
            this.CodigoProduto.HeaderText = "Codigo";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            this.CodigoProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tipo.Width = 200;
            // 
            // frmPesquisaOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.dgvOfertas);
            this.Controls.Add(this.panel1);
            this.Name = "frmPesquisaOfertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Ofertas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPesquisaOfertas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfertas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOfertas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}