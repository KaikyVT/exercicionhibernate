using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernateProjeto.infra.mapeamentos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using NHibernate;

namespace FluentNHibernateProjeto.infra
{
    public class HibernateUtil
    {
        public static ISessionFactory sessionFactory;

        public static ISession getSession()
        {
            if (sessionFactory == null)
            {
                sessionFactory = Fluently.Configure().Database(
                                MySQLConfiguration.Standard.ConnectionString("Server=localhost;Port=3306;Database=PROJETO_NHIBERNATE;Uid=root;Pwd=;")
                                .ShowSql()
                                .FormatSql())
                                .Mappings(m => { m.FluentMappings.AddFromAssemblyOf<ClientesMap>(); })
                                .BuildSessionFactory();
            }

            return sessionFactory.OpenSession();

        }
    }
}