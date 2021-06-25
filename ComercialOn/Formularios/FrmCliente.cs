using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ComercialOn.Classes;
using ComercialOn.Formularios;

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

        private void listarTodos_Click(object sender, EventArgs e)
        {
            var clientes = Cliente.ListarTodos();
            listaClientes.Items.Clear();
            foreach (var item in clientes)
            {
                foreach (var endereco in item.Enderecos)
                {
                    listaClientes.Items.Add(
                            item.Id + " - " +
                            item.Nome + " - " +
                            endereco.Logradouro
                        );
                }

            }
        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRedirectCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.Show();
        }

        private void btnRedirectMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "...")
            {
                txtIdBuscarCliente.Enabled = true;
                txtIdBuscarCliente.ReadOnly = false;
                txtIdBuscarCliente.Focus();
                button2.Text = "Buscar";
                bloquearControles();
            }
            else
            {
                txtIdBuscarCliente.Enabled = false;
                txtIdBuscarCliente.ReadOnly = true;
                button2.Text = "...";
                desbloqueiarControles();
                Cliente cliente = new Cliente();
                if ((txtIdBuscarCliente.Text) != "")
                {
                    cliente.BuscarPorId(int.Parse(txtIdBuscarCliente.Text));
                    if (cliente.Id > 0)
                    {
                        txtNome.Text = cliente.Nome;
                        txtEmail.Text = cliente.Email;
                        mskCpf.Text = cliente.Cpf;
                        mskTel.Text = cliente.Telefone;
                        chkAtivo.Checked = cliente.Ativo;
                        mskCpf.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Não há cliente com o ID "+txtIdBuscarCliente.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Digite um ID para poder buscar! ");
                    limpaDadosCliente();
                    txtIdBuscarCliente.Focus();
                }
            }

        }
        /// <summary>
        /// Limpa todos os campos de cadastro do cliente
        /// </summary>
        private void limpaDadosCliente()
        {
            txtIdBuscarCliente.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCpf.Clear();
            mskTel.Clear();
            chkAtivo.Checked = false;
        }
        private void bloquearControles()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCpf.Enabled = false;
            mskTel.Enabled = false;
            chkAtivo.Enabled = false;
        }
        private void desbloqueiarControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCpf.Enabled = true;
            mskTel.Enabled = true;
            chkAtivo.Enabled = true;
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(txtIdBuscarCliente.Text);
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mskTel.Text;
            cliente.Ativo = chkAtivo.Checked;
            
            if (cliente.Alterar())
            {
                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar o Cliente!");
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {

            if (e.KeyValue >= 48 && e.KeyValue <= 57 || e.KeyValue == 44 || e.KeyValue == 46)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                e.SuppressKeyPress = true;
            }

        }
    }
}
