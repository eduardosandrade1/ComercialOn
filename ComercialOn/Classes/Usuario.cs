using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComercialOn.Classes
{
    public class Usuario
    {
        /* propriedades da classe
         * 
         * id int
         * nome string
         * email string
         * senha string
         * nivel int
         * situacao bool
         * 
         * 
         * 
         * métodos construtores
         * VAZIO
         * TODOS
         * SEM ID
         * 
         * 
         * MÉTODOS DA CLASSE
         * inserir com retorno do id do usuário inserido
         * Listar todos
         * alterar com id como parâmetro e retorne bool
         * busca por Id que não retorne valor
         */
        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// PROPRIEDADES DA CLASSE /////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string Situacao { get; set; }
        public string Cpf { get; set; }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// CONSTRUTORES ///////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        // método vazio
        public Usuario()
        {
        }
        // método construtor com id
        public Usuario(int id, string nome, string email, string senha, string nivel, string situacao, string cpf)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
            Cpf = cpf;
        }
        // método construtor sem id
        public Usuario(string nome, string email, string senha, string nivel, string situacao, string cpf)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
            Cpf = cpf;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// MÉTODOS ////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public void Inserir()
        {
            // insere e retorna o id inserido
            var banco = Banco.Abrir();
            MD5 md5Hash = MD5.Create();
            banco.CommandText = "INSERT usuarios VALUES (null,'"+Nome+"', '"+Email+"', '"+Senha+"', '"+Nivel+"' , '"+Situacao+"', '"+Cpf+"');";
            banco.ExecuteNonQuery();
            banco.CommandText = @"select @@identity";

            // retorna o id na propiedade da classe
            Id = Convert.ToInt32(banco.ExecuteScalar());
        }

        public static List<Usuario> ListarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var banco = Banco.Abrir();
            banco.CommandText = "SELECT * FROM usuarios";
            var lendoDados = banco.ExecuteReader();
            while (lendoDados.Read())
            {
                usuarios.Add(new Usuario(
                        lendoDados.GetInt32("id"),
                        lendoDados.GetString("nome"),
                        lendoDados.GetString("email"),
                        lendoDados.GetString("senha"),
                        lendoDados.GetString("nivel"),
                        lendoDados.GetString("ativo"),
                        lendoDados.GetString("cpf")
                    ));
            }
            return usuarios;
        }

        public bool Alterar(int id)
        {
            return true;
        }

        public void BuscaPorId()
        {
            // não retorna valor
        }

        public static List<Usuario > buscarPorCpf(string cpf)
        {
            List<Usuario> usuarios = new List<Usuario>();
            var banco = Banco.Abrir();
            banco.CommandText = "select * from usuarios where cpf like '%"+cpf+"%';";
            var lendoDados = banco.ExecuteReader();
            while (lendoDados.Read())
            {
                usuarios.Add(new Usuario(
                    lendoDados.GetInt32("id"),
                    lendoDados.GetString("nome"),
                    lendoDados.GetString("email"),
                    lendoDados.GetString("senha"),
                    lendoDados.GetString("nivel"),
                    lendoDados.GetString("ativo"),
                    lendoDados.GetString("cpf")
                ));
            }
            return usuarios;
        }
    }
}
