using System;
using System.Collections.Generic;

namespace ComercialOn.Classes
{
    public class Produto
    {
        /*
         * propriedade da classe
         * 
         * id, descricao, preco, desconto, descontinuado
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
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// CONSTRUTORES ///////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////
        
        // contrutor vazio
        public Produto()
        {
        }
        // contrutor com id
        public Produto(int id, string descricao, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        // contrutor sem id
        public Produto(string descricao, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// MÉTODOS ////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public int Inserir()
        {
            return 1;
        }

        public List<Produto> ListarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            return produtos;
        }

        public bool Aterar(int id)
        {
            return true;
        }

        public void BuscarPorId()
        {
            // não retorna valor
        }

    }
}
