using System;
using System.Collections.Generic;
using System.Data;

namespace ComercialOn.Classes
{
    /// <summary>
    /// Classe para executar as ações dos clientes
    /// </summary>
    public class Cliente
    {
        // propriedades da classe
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Endereco { get; set; }
        public bool Ativo { get; set; }
        // método contrutor tem o mesmo nome da classe
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string email, string telefone, bool ativo=true, List<Endereco> endereco = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, bool ativo=true, List<Endereco> endereco=null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }


        // métodos da classe
        public void Inserir() 
        {
            // faz o processo de inserção no DB
            var comandosSql = Banco.Abrir();
            // métodos de inserção
            if (comandosSql.Connection.State==ConnectionState.Open)
            {
                // concatenação
                comandosSql.CommandType = CommandType.Text;
                comandosSql.CommandText = "INSERT clientes(nome, email, cpf, telefone, ativo) VALUES('"+Nome+"', '"+Email+"', '"+Cpf+"', '"+Telefone+"', default);"; // prepare query
                comandosSql.ExecuteNonQuery();// executa a query criada em command Text
                comandosSql.CommandText = "select @@identity"; // retorna o id inserido

                Id = Convert.ToInt32(comandosSql.ExecuteScalar()); // convertendo objeto retornado do banco em string
                // após o cadastro do cliente, posso cadastrar o Endereço
                
            }

            // expressões mysql
            // usando procedures
        }


        public bool Alterar(int id, object list)
        {
            // faz o processo de update
            return true; // Apenas para o itelisence
        }


        // lista todos os clientes
        public static List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            // code para capturar infos no banco...
            return lista;
        }


        // recupera os clientes para listar, com limite
        public static List<Cliente> ListarComLimite(int limite)
        {
            List<Cliente> listaLimitada = new List<Cliente>();
            return listaLimitada;
        }



        // busca por id, mas não retorna os dados
        public void BuscarPorId(int id)
        {

        }
    }
}
