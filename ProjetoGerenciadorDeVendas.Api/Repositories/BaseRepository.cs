using ProjetoGerenciadorDeVendas.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Repositories
{
    public class BaseRepository
    {
        protected readonly GerenciadorDeVendasContext _context;

        public BaseRepository(GerenciadorDeVendasContext context)
        {
            _context = context;
        }
    }
}
