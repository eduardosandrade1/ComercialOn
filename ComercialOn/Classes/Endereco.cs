using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialOn.Classes
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TipoEndereco { get; set; }
        // Construtor vazio
        public Endereco()
        {
        }
        // Construtor com todos os parâmetros
        public Endereco(string logradouro, string numero, string cep, string bairro, string cidade, string tipoEndereco, string estado=null, string complemento=null)
        {
            Logradouro  = logradouro;
            Numero      = numero;
            Complemento = complemento;
            Cep         = cep;
            Bairro      = bairro;
            Cidade      = cidade;
            TipoEndereco = tipoEndereco;
            Estado      = estado;
        }
        // 
        /// <summary>
        /// inserindo endereço relacionando com o cliente
        /// </summary>
        /// <param name="idCliente">id para relacionar o endereço com o cliente</param>
        public void Inserir(int idCliente)
        {
            string query = "INSERT enderecos(Clientes_id, cep,logradouro, numero, complemento, bairro, cidade, estado, tipo)" +
                " VALUES('"+idCliente+"','"+Cep+"','"+Logradouro+"','"+Numero+"','"+Complemento+"','"+Bairro+"','"+Cidade+"','"+Estado+"','"+TipoEndereco+"')";

            var comando = Banco.Abrir();
            comando.CommandType = System.Data.CommandType.Text;// dizendo o tipo de comando que irá rodar
            comando.CommandText = query;// relacionando a query
            comando.ExecuteNonQuery();// executando
        }
        public static List<Endereco> ListaEnderecos(int id=0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>();
            // código para buscar os endereços
            // se id == 0, lista todos

            // se tiver id, lista com
            return lista;
        }


    }
}
