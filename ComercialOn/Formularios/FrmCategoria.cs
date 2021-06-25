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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnListCategoria_Click(object sender, EventArgs e)
        {
            var categorias = Categoria.ListarTodas();
            listCategorias.Items.Clear();
            foreach (var item in categorias)
            {
                listCategorias.Items.Add(
                    item.Nome
                    );
            }
        }

        private void btnPesquisarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            if (txtNomeCategoria.Text == "...")
            {
                btnCadastrarCategoria.Text = "Pesquisar";
                txtBuscaIdCategoria.Enabled = true;
                if (txtBuscaIdCategoria.Text != "")
                {
                    categoria.Id = int.Parse(txtBuscaIdCategoria.Text);
                    categoria.Nome = txtNomeCategoria.Text;
                    categoria.listarPorId(categoria.Id);
                }
                else
                {
                    MessageBox.Show("Por favor, digite um ID para Pesquisar!");
                }
            }
            else
            {
                btnCadastrarCategoria.Text = "...";
                txtBuscaIdCategoria.Enabled = false;
            }

        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            if (txtNomeCategoria.Text == "...")
            {
                btnCadastrarCategoria.Text = "Pesquisar";
                txtBuscaIdCategoria.Enabled = true;
                if (txtBuscaIdCategoria.Text != "")
                {
                    categoria.Id = int.Parse(txtBuscaIdCategoria.Text);
                    categoria.Nome = txtNomeCategoria.Text;
                    categoria.Alterar();
                }
                else
                {
                    MessageBox.Show("Por favor, digite um ID para Pesquisar!");
                }
            }
            else
            {
                btnCadastrarCategoria.Text = "...";
                txtBuscaIdCategoria.Enabled = false;
            }
        }
    }
}
