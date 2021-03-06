using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorDeVendas.Api.Data;
using ProjetoGerenciadorDeVendas.Api.Models;
using ProjetoGerenciadorDeVendas.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task AddAsync(Produto produto)
        {
            await _produtoRepository.AddAsync(produto);
        }

        public async Task<Produto> FindByIdAsync(int id)
        {
            return await _produtoRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Produto>> ListAsync()
        {
            return await _produtoRepository.ListAsync();
        }

        public bool ProdutoExists(int id)
        {
            return _produtoRepository.ProdutoExists(id);
        }

        public void Remove(Produto produto)
        {
            _produtoRepository.Remove(produto);
        }

        public void Update(Produto produto)
        {
            _produtoRepository.Update(produto);
        }
    }
}
