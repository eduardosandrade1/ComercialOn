namespace ComercialOn.Formularios
{
    partial class FrmListaClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.clnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnTelefone,
            this.clnAtivo});
            this.dgvClientes.Location = new System.Drawing.Point(1, 12);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(797, 260);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.AllowUserToAddRows = false;
            this.dgvEnderecos.AllowUserToDeleteRows = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnTipo,
            this.clnCep,
            this.clnEndereco});
            this.dgvEnderecos.Location = new System.Drawing.Point(1, 288);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.ReadOnly = true;
            this.dgvEnderecos.RowHeadersVisible = false;
            this.dgvEnderecos.Size = new System.Drawing.Size(797, 162);
            this.dgvEnderecos.TabIndex = 1;
            // 
            // clnTipo
            // 
            this.clnTipo.Frozen = true;
            this.clnTipo.HeaderText = "Tipo";
            this.clnTipo.Name = "clnTipo";
            this.clnTipo.ReadOnly = true;
            this.clnTipo.Width = 150;
            // 
            // clnCep
            // 
            this.clnCep.Frozen = true;
            this.clnCep.HeaderText = "CEP";
            this.clnCep.Name = "clnCep";
            this.clnCep.ReadOnly = true;
            this.clnCep.Width = 150;
            // 
            // clnEndereco
            // 
            this.clnEndereco.Frozen = true;
            this.clnEndereco.HeaderText = "Endereço";
            this.clnEndereco.Name = "clnEndereco";
            this.clnEndereco.ReadOnly = true;
            this.clnEndereco.Width = 497;
            // 
            // clnId
            // 
            this.clnId.HeaderText = "id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 150;
            // 
            // clnCpf
            // 
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 180;
            // 
            // clnTelefone
            // 
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            this.clnTelefone.Width = 130;
            // 
            // clnAtivo
            // 
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 130;
            // 
            // FrmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEnderecos);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
    }
}