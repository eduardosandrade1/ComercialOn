using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialOn.Classes
{
    public class Endereco
    {
        private readonly int idCliente;
        public int IdCliente { get { return idCliente; } }
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

        public Endereco(int idCliente, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado, string tipoEndereco)
        {
            this.idCliente = idCliente;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            TipoEndereco = tipoEndereco;
        }



        /// <summary>
        /// Retorna endereços
        /// </summary>
        /// <param name="id">Id do cliente na tabela de endereço. 0 = para listar todos. </param>
        /// <param name="start"> começo do limite das linhas para consulta
        /// <param name="limit">Limite de linhas por consultas. (start, limit)</param>
        /// <returns></returns>
        public static List<Endereco> ListaEnderecos(int id=0,int start=0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>();
            var comandoSql = Banco.Abrir();// abrindo conexão para consulta

            string queryConsulta = "";

            // consultando endereço de cliente específico
            if (id > 0)
            {
                queryConsulta = "SELECT * FROM enderecos WHERE Clientes_id = "+id;
            }
            else if(limit > 0) // com limites começando de 0
            {
                queryConsulta = "SELECT * FROM enderecos LIMIT "+ limit;
            }else if (start > 0 && limit > 0)
            {
                queryConsulta = "SELECT * FROM enderecos LIMIT " + start + "," + limit;
            }
            else
            {
                queryConsulta = "SELECT * FROM enderecos";
            }
            comandoSql.CommandText = queryConsulta;

            var LeitorDeDados = comandoSql.ExecuteReader();// reader é para consulta de dados

            while (LeitorDeDados.Read()) // enquanto tiver próximo dado para leitura
            {
                lista.Add(new Endereco(
                    LeitorDeDados.GetInt32(0),//coluna de id
                    LeitorDeDados.GetString("logradouro"),// coluna de cep
                    LeitorDeDados.GetString("numero"),
                    LeitorDeDados.GetString("complemento"),
                    LeitorDeDados.GetString("cep"),
                    LeitorDeDados.GetString("bairro"),
                    LeitorDeDados.GetString("cidade"),
                    LeitorDeDados.GetString("estado"),
                    LeitorDeDados.GetString("tipo")
                ));
            }

            //Id = Convert.ToInt32(comandosSql.ExecuteScalar());
            return lista;
        }
    }
}
