using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernateProjeto.entidades;
using NHibernate.Mapping.ByCode.Impl;

namespace FluentNHibernateProjeto.infra.mapeamentos
{
    public class ClientesMap : ClassMap<Cliente>
    {
        public ClientesMap()
        {
            Not.LazyLoad();
            Schema("projeto_nhibernate");
            Table("cliente");
            Id(cliente => cliente.Id).Column("id");
            Map(Cliente => Cliente.Nome).Column("nome");
            Map(Cliente => Cliente.Email).Column("email");
            Map(Cliente => Cliente.Senha).Column("senha");
        }
    }
}