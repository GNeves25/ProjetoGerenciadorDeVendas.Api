using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorDeVendas.Api.Data;
using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Services
{
    public class ProdutoService
    {
        private readonly GerenciadorDeVendasContext _context;

        public ProdutoService(GerenciadorDeVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> FindAllAsync()
        {
            return await _context.Produto.OrderBy(produto => produto.Nome).ToListAsync();
        }
    }
}
