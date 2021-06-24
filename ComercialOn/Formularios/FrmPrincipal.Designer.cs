﻿namespace ComercialOn.Formularios
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsnCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsnOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsnMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsnRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsnConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsnAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroProdutosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroProdutosLista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsnCadastros,
            this.tsnOperacoes,
            this.tsnMovimento,
            this.tsnRelatorio,
            this.tsnConfiguracoes,
            this.tsnAjuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 24);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1007, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsnCadastros
            // 
            this.tsnCadastros.AccessibleName = "";
            this.tsnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroClientes,
            this.tsmCadastroProdutos,
            this.tsmCadastroUsuarios});
            this.tsnCadastros.Name = "tsnCadastros";
            this.tsnCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsnCadastros.Text = "&Cadastros";
            // 
            // tsnOperacoes
            // 
            this.tsnOperacoes.Name = "tsnOperacoes";
            this.tsnOperacoes.Size = new System.Drawing.Size(75, 20);
            this.tsnOperacoes.Text = "&Operações";
            // 
            // tsnMovimento
            // 
            this.tsnMovimento.Name = "tsnMovimento";
            this.tsnMovimento.Size = new System.Drawing.Size(81, 20);
            this.tsnMovimento.Text = "&Movimento";
            // 
            // tsnRelatorio
            // 
            this.tsnRelatorio.Name = "tsnRelatorio";
            this.tsnRelatorio.Size = new System.Drawing.Size(71, 20);
            this.tsnRelatorio.Text = "&Relatórios";
            // 
            // tsnConfiguracoes
            // 
            this.tsnConfiguracoes.Name = "tsnConfiguracoes";
            this.tsnConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.tsnConfiguracoes.Text = "Con&figurações";
            // 
            // tsnAjuda
            // 
            this.tsnAjuda.Name = "tsnAjuda";
            this.tsnAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsnAjuda.Text = "&Ajuda";
            this.tsnAjuda.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsmCadastroClientes
            // 
            this.tsmCadastroClientes.Name = "tsmCadastroClientes";
            this.tsmCadastroClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroClientes.Text = "&Clientes";
            this.tsmCadastroClientes.Click += new System.EventHandler(this.tsmCadastroClientes_Click);
            // 
            // tsmCadastroProdutos
            // 
            this.tsmCadastroProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroProdutosNovo,
            this.tsmCadastroProdutosLista});
            this.tsmCadastroProdutos.Name = "tsmCadastroProdutos";
            this.tsmCadastroProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroProdutos.Text = "&Produtos";
            // 
            // tsmCadastroUsuarios
            // 
            this.tsmCadastroUsuarios.Name = "tsmCadastroUsuarios";
            this.tsmCadastroUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroUsuarios.Text = "&Usuários";
            // 
            // tsmCadastroProdutosNovo
            // 
            this.tsmCadastroProdutosNovo.Name = "tsmCadastroProdutosNovo";
            this.tsmCadastroProdutosNovo.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroProdutosNovo.Text = "&Novo";
            this.tsmCadastroProdutosNovo.Click += new System.EventHandler(this.tsmCadastroProdutosNovo_Click);
            // 
            // tsmCadastroProdutosLista
            // 
            this.tsmCadastroProdutosLista.Name = "tsmCadastroProdutosLista";
            this.tsmCadastroProdutosLista.Size = new System.Drawing.Size(180, 22);
            this.tsmCadastroProdutosLista.Text = "&Lista";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1007, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsnCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsnOperacoes;
        private System.Windows.Forms.ToolStripMenuItem tsnMovimento;
        private System.Windows.Forms.ToolStripMenuItem tsnRelatorio;
        private System.Windows.Forms.ToolStripMenuItem tsnConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem tsnAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroProdutosNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroProdutosLista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}