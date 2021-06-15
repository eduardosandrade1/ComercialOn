using System;
using System.Collections.Generic;

namespace ComercialOn.Classes
{
    /// <summary>
    /// Classe para executar as ações dos clientes
    /// </summary>
    public class Cliente
    {
        // atributo da classe
        public int Id { get; set; }
        public string Nome { get;set }
        // método contrutor tem o mesmo nome da classe
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // métodos da classe
        public void Inserir() 
        {
            // faz o processo de inserção no DB
        }
        public bool Alterar(int id, object list)
        {
            // faz o processo de update
            return true; // Apenas para o itelisence
        }
        // lista todos os clientes
        public static List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            // code para capturar infos no banco...
            return lista;
        }
        // busca por id, mas não retorna os dados
        public void BuscarPorId(int id)
        {

        }
    }
}
