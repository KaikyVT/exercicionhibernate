using System.Transactions;
using FluentNHibernateProjeto.entidades;
using FluentNHibernateProjeto.infra;
using NHibernate;

namespace FluentNHibernateProjeto;

internal class Program
{
    private static void Main(string[] args)
    {
        //! Criando sessão
        ISession session = HibernateUtil.getSession();

        //! Criando transação
        ITransaction transaction = session.BeginTransaction();

        // ! Insert
        Cliente cliente = new("Nome", "email@email.com", "senha123");
        session.Save(cliente);
        transaction.Commit();

        // ! Select
        // Cliente cliente = session.Get<Cliente>(3);
        // Console.WriteLine("Te amo, " + cliente.Nome);

        // ! Update
        // Cliente cliente = session.Get<Cliente>(3);
        // Console.WriteLine(cliente.Nome);
        // cliente.Nome = "Gabi meu amor S2";
        // Console.WriteLine(cliente.Nome);
        // session.Update(cliente);
        // transaction.Commit();

        // ! Delete
        // Cliente cliente = session.Get<Cliente>(2);
        // session.Delete(cliente);
        // transaction.Commit();

        // Cliente cliente = session.Get<Cliente>(3);
        // Pedido pedido = new(cliente);
        // session.Save(pedido);
        // transaction.Commit();
    }
}