using System;
using System.Text;
using System.Windows.Forms;
using ComercialOn.Classes;
namespace ComercialOn.Formularios
{
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
            var listaClientes = Cliente.ListarTodos();
            foreach (var item in listaClientes)
            {
                // primeiro adiciona uma linha para poder adicionar os elementos
                dgvClientes.Rows.Add();

                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[2].Value = item.Cpf;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[3].Value = item.Email;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[4].Value = item.Telefone;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[5].Value = item.Ativo;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnderecos.Rows.Clear(); // limpando o DataGrid

            int idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            var listaEndereco = Endereco.ListaEnderecos(idCliente);

            if (listaEndereco.Count > 0)
            {
                foreach (var item in listaEndereco)
                {
                    dgvEnderecos.Rows.Add();
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[0].Value = item.TipoEndereco;
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[1].Value = item.Cep;
                    StringBuilder endereco = new StringBuilder();
                    endereco.Append(item.Logradouro);
                    endereco.Append(","+item.Numero);
                    endereco.Append(" - "+item.Cidade);
                    dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[2].Value = endereco;
                }
            }
            else
            {
                dgvEnderecos.Rows.Add();
                string msg = "Não existe endereço relacionado a este cliente!";
                dgvEnderecos.Rows[dgvEnderecos.Rows.Count - 1].Cells[2].Value = msg;

            }

        }
    }
}
