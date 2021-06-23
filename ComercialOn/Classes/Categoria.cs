using System;
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

        public void Inserir()
        {
            var banco = Banco.Abrir();

            banco.CommandType = CommandType.Text;
            banco.CommandText = "INSERT  categorias (nome) VALUES ('" + Nome + "')";
            // executando query no banco
            banco.ExecuteNonQuery();
            // recuperando o id inserido
            banco.CommandText = @"select @@identity";
            // e passando para propriedade da classe
            Id = Convert.ToInt32(banco.ExecuteScalar());
        }

    }
}
