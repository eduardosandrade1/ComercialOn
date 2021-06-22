using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ComercialOn.Classes;

namespace ComercialOn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;// formata o campo para o banco de dados (sem . e -)

            Cliente cliente = new Cliente(txtNome.Text, mskCpf.Text, txtEmail.Text, mskTel.Text);
            cliente.Inserir();
            Endereco enderecoCliente = new Endereco(txtLogradouro.Text,txtNumero.Text,txtCep.Text,txtBairro.Text, txtCidade.Text, cmpTipo.Text, cmbEstado.Text, txtComplemento.Text);
            enderecoCliente.Inserir(cliente.Id);
            MessageBox.Show("Cliente "+cliente.Id+" inserido com sucesso");


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string EmailValido = txtEmail.Text;

            Regex rg = new Regex(@"(@)(.+)$");
            if (rg.IsMatch(EmailValido))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
