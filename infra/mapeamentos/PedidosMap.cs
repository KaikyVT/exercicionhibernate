using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernateProjeto.entidades;

namespace FluentNHibernateProjeto.infra.mapeamentos
{
    public class PedidosMap : ClassMap<Pedido>
    {
        public PedidosMap()
        {
            Not.LazyLoad();
            Schema("projeto_nhibernate");
            Table("pedido");
            Id(pedido => pedido.Id).Column("id");
            Map(pedido => pedido.DataPedido).Column("datapedido");
            References(pedido => pedido.IdCliente).Column("idcliente");
        }
    }
}