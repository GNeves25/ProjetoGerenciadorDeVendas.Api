using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorDeVendas.Api.Models;

namespace ProjetoGerenciadorDeVendas.Api.Data
{
    public class GerenciadorDeVendasContext : DbContext
    {
        public GerenciadorDeVendasContext(DbContextOptions<GerenciadorDeVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
