using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Data
{
    public class PopulaBanco
    {
        private GerenciadorDeVendasContext _context;

        public PopulaBanco(GerenciadorDeVendasContext context)
        {
            _context = context;
        }

        public void Popular()
        {
            if (_context.Produto.Any())
            {
                return;
            }

            Produto pd1 = new Produto("Produto 01", 1.01);
            Produto pd2 = new Produto("Produto 02", 1.10);
            Produto pd3 = new Produto("Produto 03", 1.11);
            Produto pd4 = new Produto("Produto 04", 2.00);
            Produto pd5 = new Produto("Produto 05", 2.01);
            Produto pd6 = new Produto("Produto 06", 3.10);
            Produto pd7 = new Produto("Produto 07", 3.11);

            _context.Produto.AddRange(pd1, pd2, pd3, pd4, pd5, pd6, pd7);
            _context.SaveChanges();
        }
    }
}
