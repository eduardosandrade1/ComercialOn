using System;
using System.Collections.Generic;
using System.Data;
namespace ComercialOn.Classes
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Abreviacao { get; set; }

        public Marca(int id, string descricao, string abreviacao)
        {
            Id = id;
            Descricao = descricao;
            Abreviacao = abreviacao;
        }

        public Marca(string descricao, string abreviacao)
        {
            Descricao = descricao;
            Abreviacao = abreviacao;
        }

        public Marca()
        {
        }
        /// <summary>
        /// Inserindo dados com base nos dados atribuidos as propriedades da classe
        /// </summary>
        public void Inserir()
        {
            var banco = Banco.Abrir();
            banco.CommandType = CommandType.Text;
            banco.CommandText = "INSERT marcas (descricao, abreviacao) VALUES ('"+Descricao+"','"+Abreviacao+"');";

            banco.ExecuteNonQuery();
            banco.CommandText = @"select @@identity";
            // retornando o id inserido para a propriedade da classe
            Id = Convert.ToInt32(banco.ExecuteScalar());
        }

        public static List<Marca> ListarTodas()
        {
            List<Marca> marcas = new List<Marca>();
            return marcas;
        }
    }
}
