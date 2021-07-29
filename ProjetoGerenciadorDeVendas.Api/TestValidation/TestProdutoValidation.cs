using NUnit.Framework;
using ProjetoGerenciadorDeVendas.Api.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.TestValidation
{
    public class TestProdutoValidation
    {
        [Test]
        public void TestaValidaNome()
        {
            var validaNome = new ProdutoValidation();

            validaNome.ValidaNome();
        }
    }
}
