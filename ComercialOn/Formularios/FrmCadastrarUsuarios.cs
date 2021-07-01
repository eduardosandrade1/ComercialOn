using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComercialOn.Classes;

namespace ComercialOn.Formularios
{
    public partial class FrmCadastrarUsuarios : Form
    {
        public FrmCadastrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string situation = (chkAtivo.Checked == true) ? "1" : "0";
            string textSenha = Md5Hash.encode(txtSenha.Text);

            Usuario usuario = new Usuario(txtNome.Text,txtEmail.Text, textSenha,cmbNivel.Text, situation, txtCpf.Text);
            usuario.Inserir();
            MessageBox.Show("Usuário "+usuario.Nome+" cadastrado com sucesso!");
        }

    }
}
