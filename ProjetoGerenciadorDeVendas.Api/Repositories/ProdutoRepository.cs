using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorDeVendas.Api.Data;
using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Repositories
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public ProdutoRepository(GerenciadorDeVendasContext context): base(context)
        {

        }
        public async Task AddAsync(Produto produto)
        {
            await _context.Produto.AddAsync(produto);
        }

        public async Task<Produto> FindByIdAsync(int id)
        {
            return await _context.Produto.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> ListAsync()
        {
            return await _context.Produto.ToListAsync();
        }

        public bool ProdutoExists(int id)
        {
            return _context.Produto.Any(produto => produto.Id == id);
        }

        public void Remove(Produto produto)
        {
            _context.Produto.Remove(produto);
        }

        public void Update(Produto produto)
        {
            _context.Produto.Update(produto);
        }
    }
}
