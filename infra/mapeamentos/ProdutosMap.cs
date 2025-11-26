using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernateProjeto.entidades;

namespace FluentNhibernateProjeto.infra.mapeamentos
{
    public class ProdutosMap : ClassMap<Produto>
    {
        public ProdutosMap()
        {
            Not.LazyLoad();
            Schema("projeto_nhibernate");
            Table("produto");
            Id(produto => produto.Id).Column("id");
            Map(produto => produto.Nome).Column("nome");
            Map(produto => produto.Preco).Column("preco");
        }
    }
}