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
            if ((txtNomeCategoria.Text).Trim() != "")
            {
                Categoria categoria = new Categoria(txtNomeCategoria.Text);
                categoria.Inserir();
                txtNomeCategoria.Text = "";
                MessageBox.Show("Categoria '" + categoria.Nome + "' inserida com sucesso! ");
            }
            else
            {
                MessageBox.Show("Não é possível inserir um valor Vazio");
            }

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
            if (btnPesquisarCategoria.Text == "...")
            {
                btnPesquisarCategoria.Text = "Pesquisar";
                txtBuscaIdCategoria.Enabled = true;
                bloqueiaTodosInputs();
            }
            else
            {
                btnPesquisarCategoria.Text = "...";
                txtBuscaIdCategoria.Enabled = false;
                if ((txtBuscaIdCategoria.Text).Trim() != "")
                {
                    categoria.listarPorId(int.Parse(txtBuscaIdCategoria.Text));
                    if (categoria.Id > 0)
                    {
                        txtBuscaIdCategoria.Text = (categoria.Id).ToString();
                        txtNomeCategoria.Text = categoria.Nome;
                        btnCadastrarCategoria.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Não existe este ID cadastrado! ");
                        btnCadastrarCategoria.Enabled = true;
                        txtNomeCategoria.Focus();
                        limpaCampos();
                    }
                    desbloquearTodosInputs();
                }
                else
                {
                    MessageBox.Show("Por favor, digite um ID para Pesquisar!");
                    limpaCampos();
                }
            }

        }
        /// <summary>
        /// Bloqueia os campos de entrada do formulário de categorias
        /// </summary>
        private void bloqueiaTodosInputs()
        {
            txtNomeCategoria.Enabled = false;
            btnCadastrarCategoria.Enabled = false;
        }
        /// <summary>
        /// DESbloqueia os campos de entrada do formulário de categorias
        /// </summary>
        private void desbloquearTodosInputs()
        {
            txtNomeCategoria.Enabled = true;
            btnCadastrarCategoria.Enabled = true;
        }
        /// <summary>
        /// Limpa todos os campos do formulário de categoria
        /// </summary>
        private void limpaCampos()
        {
            txtNomeCategoria.Clear();
            txtBuscaIdCategoria.Clear();
        }
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            if ((txtBuscaIdCategoria.Text).Trim() != "")
            {
                categoria.Id = int.Parse(txtBuscaIdCategoria.Text);
                categoria.Nome = txtNomeCategoria.Text;

                if (categoria.Alterar())
                {
                    MessageBox.Show("Categoria atualizada com sucesso! ");
                    limpaCampos();
                }
            }
            else
            {
                valoresVazios();
            }
        }
        private void valoresVazios()
        {
            MessageBox.Show("Não é possível inserir um valor Vazio");
        }
    }
}
