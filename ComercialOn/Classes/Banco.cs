using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
namespace ComercialOn.Classes
{
    /// <summary>
    /// Classe de conexão com banco de dados
    /// </summary>
    public static class Banco
    {
        /// <summary>
        /// Abre a conexao para um banco de dados MYSQL
        /// </summary>
        /// <returns>[object] comandos SQL</returns>
       public static MySqlCommand Abrir()
        {
            MySqlCommand comandosSql = new MySqlCommand();
            string stringDeConexao = @"server=127.0.0.1;database=comercialondb;user id=root;password=usbw; port=3306";//  @ força para interpretar como string
            // conectando
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            // tratativa de exceção
            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                    comandosSql.Connection = conexao;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return comandosSql;
        }
    }
}
