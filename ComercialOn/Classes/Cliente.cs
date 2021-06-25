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
        public List<Endereco> Enderecos { get; set; }
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
            Enderecos = endereco;
            Ativo = ativo;
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, bool ativo=true, List<Endereco> endereco=null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Enderecos = endereco;
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


        public bool Alterar()
        {
            // faz o processo de update
            var banco = Banco.Abrir();
            banco.CommandText = "UPDATE clientes set nome = '"+Nome+"'," +
                                                    " email = '"+Email+"'," +
                                                    " telefone = '"+Telefone+"'," +
                                                    " ativo = "+ Ativo +
                                                    " WHERE id = "+Id;
            int linhasRetornadas = banco.ExecuteNonQuery();
            if (linhasRetornadas == 0)
            {
                return false;
            }

            return true;
        
        }


        // lista todos os clientes
        public static List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            string querySql = "SELECT * FROM clientes";
            var banco = Banco.Abrir();
            banco.CommandText = querySql;
            var lendoDados = banco.ExecuteReader();

            while (lendoDados.Read())
            {
                lista.Add(new Cliente(
                    lendoDados.GetInt32(0),
                    lendoDados.GetString(1),
                    lendoDados.GetString(2),
                    lendoDados.GetString(3),
                    lendoDados.GetString(4),
                    lendoDados.GetBoolean(5),
                    Endereco.ListaEnderecos(lendoDados.GetInt32("id"))
                    ));
            }

            return lista;
        }

        // busca por id, mas não retorna os dados
        public void BuscarPorId(int id)
        {
            string querySql = "SELECT * FROM clientes WHERE id = "+ id;
            var banco = Banco.Abrir();
            banco.CommandText = querySql;
            var lendoDados = banco.ExecuteReader();

            while (lendoDados.Read())
            {
                Id = lendoDados.GetInt32("id");
                Nome =lendoDados.GetString("nome");
                Email = lendoDados.GetString("Email");
                Cpf = lendoDados.GetString("cpf");
                Telefone = lendoDados.GetString("telefone");
                Ativo = lendoDados.GetBoolean("ativo");
                Enderecos = Endereco.ListaEnderecos(id);
            }
        }
    }
}
