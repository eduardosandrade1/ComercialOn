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

            string querySql = "SELECT * FROM marcas";

            var banco = Banco.Abrir();

            banco.CommandText = querySql;
            var leitorDeDados = banco.ExecuteReader();

            while (leitorDeDados.Read())
            {
                marcas.Add(new Marca(
                    leitorDeDados.GetInt32("id"),
                    leitorDeDados.GetString("descricao"),
                    leitorDeDados.GetString("abreviacao")
                    ));
            }


            return marcas;
        }

        public static List<Marca> ListarPorId(int id)
        {
            var banco = Banco.Abrir();
            List<Marca> lista = new List<Marca>();

            banco.CommandText = "SELECT * FROM marcas WHERE id = " + id;
            var lendoDados = banco.ExecuteReader();
            while (lendoDados.Read())
            {
                lista.Add(new Marca(
                    lendoDados.GetInt32("id"),
                    lendoDados.GetString("descricao"),
                    lendoDados.GetString("abreviacao")
                    ));
            }
            return lista;
        }

        public bool Alterar()
        {
            var banco = Banco.Abrir();
            banco.CommandText = "UPDATE marcas SET descricao = '"+Descricao+"' , abreviacao =  '"+Abreviacao+"' WHERE id = "+Id;
            var retornQuery = banco.ExecuteNonQuery();
            if (retornQuery == 0)
            {
                return false;
            }
            return true;
        }
    }
}
