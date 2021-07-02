using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialOn.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> ItemPedidos { get; set; }

        public Pedido()
        {
        }

        public Pedido(int data, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itemPedidos=null)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            ItemPedidos = itemPedidos;
        }

        public Pedido(int id, int data, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itemPedidos=null)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            ItemPedidos = itemPedidos;
        }


    }
}
