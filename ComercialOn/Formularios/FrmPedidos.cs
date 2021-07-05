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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            clientes.GetByCpf(txtCPF.Text);

            dgvCliente.Rows.Clear();
            foreach (var item in clientes)
            {
                dgvCliente.Rows.Add();

                dgvCliente.Rows[dgvCliente.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvCliente.Rows[dgvCliente.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvCliente.Rows[dgvCliente.Rows.Count - 1].Cells[2].Value = item.Cpf;
                dgvCliente.Rows[dgvCliente.Rows.Count - 1].Cells[3].Value = item.Email;
            }
        }
    }
}
