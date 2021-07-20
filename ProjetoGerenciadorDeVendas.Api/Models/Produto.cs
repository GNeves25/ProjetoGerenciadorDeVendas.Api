using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }

        public Produto() {}

        public Produto(string nome, string preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
