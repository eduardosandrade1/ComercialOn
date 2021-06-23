using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComercialOn.Classes;

namespace ComercialOn.Formularios
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(txtNomeCategoria.Text);
            categoria.Inserir();
            txtNomeCategoria.Text = "";
            MessageBox.Show("Categoria '"+categoria.Nome + "' inserida com sucesso! ");
        }
    }
}
