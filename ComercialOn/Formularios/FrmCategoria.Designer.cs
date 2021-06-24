namespace ComercialOn.Formularios
{
    partial class FrmCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.listCategorias = new System.Windows.Forms.ListBox();
            this.btnListCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(230, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Categoria";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(63, 183);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(270, 20);
            this.txtNomeCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(58, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(63, 270);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(376, 45);
            this.btnCadastrarCategoria.TabIndex = 3;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // listCategorias
            // 
            this.listCategorias.FormattingEnabled = true;
            this.listCategorias.Location = new System.Drawing.Point(488, 155);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(260, 160);
            this.listCategorias.TabIndex = 4;
            // 
            // btnListCategoria
            // 
            this.btnListCategoria.Location = new System.Drawing.Point(488, 126);
            this.btnListCategoria.Name = "btnListCategoria";
            this.btnListCategoria.Size = new System.Drawing.Size(260, 23);
            this.btnListCategoria.TabIndex = 5;
            this.btnListCategoria.Text = "Listar Categorias";
            this.btnListCategoria.UseVisualStyleBackColor = true;
            this.btnListCategoria.Click += new System.EventHandler(this.btnListCategoria_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListCategoria);
            this.Controls.Add(this.listCategorias);
            this.Controls.Add(this.btnCadastrarCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.ListBox listCategorias;
        private System.Windows.Forms.Button btnListCategoria;
    }
}