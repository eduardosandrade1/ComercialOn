using System;
using System.Collections.Generic;
using System.Linq;
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

        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// CONSTRUTORES ///////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        // método vazio
        public Usuario()
        {
        }
        // método construtor com id
        public Usuario(int id, string nome, string email, string senha, string nivel, string situacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
        }
        // método construtor sem id
        public Usuario(string nome, string email, string senha, string nivel, string situacao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// MÉTODOS ////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public int Inserir()
        {
            // inseree e retorna o id inserido
            return 1;
        }

        public List<Usuario> ListarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
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

    }
}
