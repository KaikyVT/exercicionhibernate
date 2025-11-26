using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentNHibernateProjeto.entidades
{
    public class Produto
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual double Preco { get; set; }

        protected Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
}