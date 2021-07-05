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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            // listando as categorias no comboBox categorias
            Produto produto = new Produto();
            lbCodProd.Text = produto.GerarCodeBar();
            var categorias = Categoria.ListarTodas();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id";
            // listando as marcas no comboBox de marcas
            var marcas = Marca.ListarTodas();
            cmbMarca.DataSource = marcas;
            cmbMarca.DisplayMember = "Descricao";
            cmbMarca.ValueMember = "id";
            

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            double valorUnitario = Double.Parse(txtValorUnitario.Text);
            double desconto = Double.Parse(txtDesconto.Text);
            Produto produto = new Produto(txtDescricao.Text, valorUnitario, txtUnidade.Text, lbCodProd.Text, desconto, true, int.Parse(cmbMarca.SelectedValue.ToString()), int.Parse(cmbCategoria.SelectedValue.ToString()), 0);
            
            produto.Inserir();
            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }
}
