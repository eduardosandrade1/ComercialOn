using System;
using System.Collections.Generic;

namespace ComercialOn.Classes
{
    public class Produto
    {
        /*
         * propriedade da classe
         * 
         * id, descricao, ValorUnitario, desconto, descontinuado
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
        public double ValorUnitario { get; set; }
        public string UnidadeVenda { get; set; }
        public string CodBar { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// CONSTRUTORES ///////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public Produto(int id, string descricao, double valorUnitario, string unidadeVenda, string codBar, double desconto, bool descontinuado, Marca marca, Categoria categoria)
        {
            Id = id;
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
        }

        public Produto(string descricao, double valorUnitario, string unidadeVenda, string codBar, double desconto, bool descontinuado, Marca marca, Categoria categoria)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
        }

        public Produto()
        {
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// MÉTODOS ////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////
        public void Inserir()
        {
            var banco = Banco.Abrir();
            banco.CommandText = "INSERT produtos VALUES(null,'"+Descricao+"')";
        }

        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            return produtos;
        }

        public bool Aterar(int id)
        {
            var banco = Banco.Abrir();
            
            return true;
        }
        // busca uma lista por id
        public List<Produto> GetById()
        {
            List<Produto> produtos = new List<Produto>();


            return produtos;
        }
        public List<Produto> GetByCodeBar()
        {
            List<Produto> produtos = new List<Produto>();
            return produtos;
        }
    }
}
