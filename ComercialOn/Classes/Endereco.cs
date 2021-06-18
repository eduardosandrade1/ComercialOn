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
        public string SiglaEstado { get; set; }
        public string TipoEndereco { get; set; }
        // Construtor vazio
        public Endereco()
        {
        }
        // Construtor com todos os parâmetros
        public Endereco(string logradouro, string numero, string cep, string bairro, string cidade, string tipoEndereco, string estado=null, string complemento=null, string siglaEstado = null)
        {
            Logradouro  = logradouro;
            Numero      = numero;
            Complemento = complemento;
            Cep         = cep;
            Bairro      = bairro;
            Cidade      = cidade;
            TipoEndereco = tipoEndereco;
            Estado      = estado;
            SiglaEstado = siglaEstado;
        }

        public static List<Endereco> ListaEnderecos(int id=0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>();
            // código para buscar os endereços
            // se id == 0, lista todos

            // se tiver id, lista com
            return lista;
        }
    }
}
