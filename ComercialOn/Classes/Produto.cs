using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public int Status { get; set; }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////// CONSTRUTORES ///////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////

        public Produto(int id, string descricao, double valorUnitario, string unidadeVenda, string codBar, double desconto, bool descontinuado, int marca, int categoria, int status)
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
            Status = status;
        }

        public Produto(string descricao, double valorUnitario, string unidadeVenda, string codBar, double desconto, bool descontinuado, int marca, int categoria, int status)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            UnidadeVenda = unidadeVenda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categoria = categoria;
            Status = status;
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
            banco.CommandText = "INSERT produtos VALUES(null,'"+Descricao+"', '"+ValorUnitario+"','"+UnidadeVenda+"','"+CodBar+"','"+Desconto+"','"+Marca+"','"+Categoria+"','"+Status+"')";
            banco.ExecuteNonQuery();
        }

        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            var banco = Banco.Abrir();
            banco.CommandText = "SELECT * FROM produtos";
            var lendoDados = banco.ExecuteReader();
            //while (lendoDados.Read())
            //{
            //    produtos.Add(new Produto(
            //        lendoDados.GetInt32("id"),
            //        lendoDados.GetString("descricao"),
            //        lendoDados.GetDouble("valor_unitario"),
            //        lendoDados.GetString("unidade_venda"),
            //        lendoDados.GetString("cod_bar"),
            //        lendoDados.GetDouble("desconto"),
            //        lendoDados.GetBoolean("status"),
            //        Marca.ListarPorId(Convert.ToInt32(lendoDados.GetInt32("Marcas_id"))),
            //        Categoria.listarPorId(lendoDados.GetInt32("Categorias_id"))
            //        )) ;
            //}
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
        /// <summary>
        /// Geta um código para identificar cada produto
        /// </summary>
        /// <returns></returns>
        public string GerarCodeBar()
        {
            var code = alfanumericoAleatorio(6);
            return code;
        }
        public int formatNumber(int num)
        {
            if (num < 10)
            {
                return int.Parse("0" + num);
            }
            return num;
        }
        /// <summary>
        /// gera numeros aleatórios
        /// </summary>
        /// <param name="tamanho">tamanho de itens que deseja</param>
        /// <returns></returns>
        public string alfanumericoAleatorio(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
