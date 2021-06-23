namespace ComercialOn.Formularios
{
    partial class FrmMarca
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
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAbreviacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.btnListarMarcas = new System.Windows.Forms.Button();
            this.listMarcas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(148, 150);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(332, 20);
            this.txtNomeMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(254, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Marca";
            // 
            // txtAbreviacao
            // 
            this.txtAbreviacao.Location = new System.Drawing.Point(185, 196);
            this.txtAbreviacao.Name = "txtAbreviacao";
            this.txtAbreviacao.Size = new System.Drawing.Size(100, 20);
            this.txtAbreviacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(80, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(80, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abreviacao";
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCadastrarMarca.Location = new System.Drawing.Point(84, 277);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(396, 51);
            this.btnCadastrarMarca.TabIndex = 5;
            this.btnCadastrarMarca.Text = "Cadastrar";
            this.btnCadastrarMarca.UseVisualStyleBackColor = true;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // btnListarMarcas
            // 
            this.btnListarMarcas.Location = new System.Drawing.Point(511, 121);
            this.btnListarMarcas.Name = "btnListarMarcas";
            this.btnListarMarcas.Size = new System.Drawing.Size(235, 23);
            this.btnListarMarcas.TabIndex = 7;
            this.btnListarMarcas.Text = "Listar Marcas";
            this.btnListarMarcas.UseVisualStyleBackColor = true;
            this.btnListarMarcas.Click += new System.EventHandler(this.btnListarCategoria_Click);
            // 
            // listMarcas
            // 
            this.listMarcas.FormattingEnabled = true;
            this.listMarcas.Location = new System.Drawing.Point(511, 150);
            this.listMarcas.Name = "listMarcas";
            this.listMarcas.Size = new System.Drawing.Size(235, 134);
            this.listMarcas.TabIndex = 8;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listMarcas);
            this.Controls.Add(this.btnListarMarcas);
            this.Controls.Add(this.btnCadastrarMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAbreviacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeMarca);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbreviacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarMarca;
        private System.Windows.Forms.Button btnListarMarcas;
        private System.Windows.Forms.ListBox listMarcas;
    }
}