using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentNHibernateProjeto.entidades
{
    public class Pedido
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual Cliente IdCliente { get; set; }

        protected Pedido()
        {
        }

        public Pedido(Cliente cliente)
        {
            DataPedido = DateTime.Now;
            IdCliente = cliente;
        }
    }
}