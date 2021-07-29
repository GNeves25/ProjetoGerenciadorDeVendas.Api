using FluentValidation;
using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Validation
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public void ValidaNome()
        {
            RuleFor(produto => produto.Nome).NotEmpty();
        }
    }
}
