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
        public void ValidaQuantidade()
        {
            RuleFor(produto => produto.Quantidade).NotEmpty();
        }
        public void ValidaDataDeVencimento()
        {
            RuleFor(produto => produto.DataDeVencimento).NotEmpty();
        }
        public void ValidaCategoria()
        {
            RuleFor(produto => produto.Categoria).NotEmpty();
        }
    }
}
