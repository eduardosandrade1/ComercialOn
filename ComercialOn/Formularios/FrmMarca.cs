using System;
using System.Windows.Forms;
using ComercialOn.Classes;

namespace ComercialOn.Formularios
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Descricao = txtNomeMarca.Text;
            marca.Abreviacao = txtAbreviacao.Text;
            marca.Inserir();
            MessageBox.Show("Marca '"+marca.Descricao+"' inserida com sucesso!");
        }

        private void btnListarCategoria_Click(object sender, EventArgs e)
        {
            listMarcas.Items.Clear();
            var marcas = Marca.ListarTodas();
            foreach (var item in marcas)
            {
                listMarcas.Items.Add(item.Descricao);
            }
            
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Id = 0;
        }

        private void btnPesquisarMarca_Click(object sender, EventArgs e)
        {
            if (btnPesquisarMarca.Text.Trim() != "")
            {
                Marca marca = new Marca();
                marca.Id = int.Parse(txtBuscarMarca.Text);
                Marca.ListarPorId(marca.Id);
            }
        }
    }
}
