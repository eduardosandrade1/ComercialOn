using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialOn.Classes
{
    public class ItemPedido
    {
        public int idProduto { get {return idProduto; } } // APENAS RECEBE ID DO PEDIDO
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double ValorProduto { get; set; }
        public double Desconto { get; set; }

        public ItemPedido(Produto produto, double quantidade, double valorProduto, double desconto)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
            Desconto = desconto;
        }

        public ItemPedido()
        {
        }

        public static List<ItemPedido> GetItemPedidos()
        {
            List<ItemPedido> itensPedidos = new List<ItemPedido>();

            return itensPedidos;
        }

        public void Inserir()
        {

        }

        public List<ItemPedido> getByPedido()
        {
            List<ItemPedido> lista = new List<ItemPedido>();

            return lista;
        }
    }
}
