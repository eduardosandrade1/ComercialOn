using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialOn.Classes
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        // Construtor vazio
        public Endereco()
        {
        }
        // Construtor com todos os parâmetros
        public Endereco(string logradouro, string numero, string cep, string bairro, string cidade, string estado=null, string complemento=null)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
