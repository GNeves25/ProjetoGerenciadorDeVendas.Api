using NUnit.Framework;
using ProjetoGerenciadorDeVendas.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGerenciadorDeVendas.Testes
{
    public class TestaProduto
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestaConstrutorProduto()
        {
            var produto = new Produto("Produto 01", "33.4");

            Assert.AreEqual("Produto 01", produto.Nome);
            Assert.AreEqual("33.4", produto.Preco);
        }
    }
}
