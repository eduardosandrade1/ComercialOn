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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuarios frmCadastrarUsuarios = new FrmCadastrarUsuarios();
            frmCadastrarUsuarios.Show();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            refreshDados();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCadastrarUsuarios frmCadastrarUsuarios = new FrmCadastrarUsuarios();
            frmCadastrarUsuarios.Show();
        }
        private void refreshDados()
        {
            var usuarios = Usuario.ListarTodos();
            dgvUsuarios.Rows.Clear();
            foreach (var item in usuarios)
            {
                dgvUsuarios.Rows.Add();

                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[2].Value = item.Email;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[3].Value = item.Senha;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[4].Value = item.Nivel;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[5].Value = (item.Situacao == "1") ? true : false;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[6].Value = item.Cpf;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDados();
        }

        private void txtBuscaUsuarioCpf_TextChanged(object sender, EventArgs e)
        {
            var usuarios = Usuario.buscarPorCpf(txtBuscaUsuarioCpf.Text);
            dgvUsuarios.Rows.Clear();
            foreach (var item in usuarios)
            {
                dgvUsuarios.Rows.Add();

                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[2].Value = item.Email;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[3].Value = item.Senha;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[4].Value = item.Nivel;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[5].Value = (item.Situacao == "1") ? true : false;
                dgvUsuarios.Rows[dgvUsuarios.Rows.Count - 1].Cells[6].Value = item.Cpf;
            }


        }
    }
}
