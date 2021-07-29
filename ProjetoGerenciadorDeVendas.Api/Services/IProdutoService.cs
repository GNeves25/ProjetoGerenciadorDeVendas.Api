using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ListAsync();
        Task AddAsync(Produto produto);
        Task<Produto> FindByIdAsync(int id);
        public bool ProdutoExists(int id);
        void Update(Produto produto);
        void Remove(Produto produto);
    }
}
