using ProjetoGerenciadorDeVendas.Api.Models;
using ProjetoGerenciadorDeVendas.Api.Models.Enums;
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
            var rand = new Random();

            if (_context.Produto.Any())
            {
                return;
            }

            for (int i = 0; i < 1000; i++)
            {
                _context.Produto.AddRange(new Produto("PRODUTO_" + i, rand.Next(1, 100), new DateTime(rand.Next(2021, 2030), rand.Next(1, 12), rand.Next(1, 28)), (EnumCategoria)rand.Next(0, 10)));
            }
            _context.SaveChanges();
        }
    }
}
