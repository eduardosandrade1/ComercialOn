using System;
using System.Collections.Generic;
using System.Data;

namespace ComercialOn.Classes
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Categoria(string nome)
        {
            Nome = nome;
        }

        public Categoria()
        {

        }

        /// <summary>
        /// insere no banco de dados os atributos passados no método construtor da classe
        /// </summary>
        public void Inserir()
        {
            var banco = Banco.Abrir();

            //banco.CommandType = CommandType.Text;
            banco.CommandText = "INSERT  categorias (nome) VALUES ('" + Nome + "')";
            // executando query no banco
            banco.ExecuteNonQuery();
            // recuperando o id inserido
            banco.CommandText = @"select @@identity";
            // e passando para propriedade da classe
            Id = Convert.ToInt32(banco.ExecuteScalar());
        }

        public static List<Categoria> ListarTodas()
        {
            List<Categoria> categorias = new List<Categoria>();

            string querySql = "SELECT * FROM categorias";

            var banco = Banco.Abrir();
            banco.CommandText = querySql;
            var leitorDeDados = banco.ExecuteReader();

            // adicionando os dados do banco as propriedades da classe
            while (leitorDeDados.Read())
            {
                categorias.Add(new Categoria(
                    leitorDeDados.GetInt32("id"),
                    leitorDeDados.GetString("nome")
                    ));
            }

            return categorias;
        }
    }
}
