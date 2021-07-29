using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ListAsync();
        Task AddAsync(Produto produto);
        Task<Produto> FindByIdAsync(int id);
        void Update(Produto produto);
        void Remove(Produto produto);
        bool ProdutoExists(int id);
    }
}
