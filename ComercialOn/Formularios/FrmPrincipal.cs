using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComercialOn.Formularios;

namespace ComercialOn.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmCadastroClientes_Click(object sender, EventArgs e)
        {
            Form1 frmCliente = new Form1();
            //frmCliente.Show();// exibe janela externa
            frmCliente.MdiParent = this; // exibe dentro do container informado
            frmCliente.Show();
        }

        private void tsmCadastroProdutosNovo_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProduto = new FrmProdutos();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }
    }
}
