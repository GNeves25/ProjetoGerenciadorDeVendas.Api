using NUnit.Framework;
using ProjetoGerenciadorDeVendas.Api.Models;
using ProjetoGerenciadorDeVendas.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoGerenciadorDeVendas.Testes
{
    public class TestaProduto
    {
        private Produto _produto;

        [SetUp]
        public void Setup()
        {
            _produto = new Produto("Produto 01", 4, new DateTime(2021, 12, 01), EnumCategoria.Bebidas);
        }

        [Test]
        public void TestaConstrutorProduto()
        {
            Assert.AreEqual("Produto 01", _produto.Nome);
            Assert.AreEqual(4, _produto.Quantidade);
            Assert.AreEqual(new DateTime(2021, 12, 01), _produto.DataDeVencimento);
            Assert.AreEqual(EnumCategoria.Bebidas, _produto.Categoria);

        }

        [Test]
        public void TestaDataDeValidade()
        {
            ProdutoValido();
            ProdutoInvalido();
        }

        public void ProdutoValido()
        {
            Assert.IsTrue(new Produto().VerificaDataDeValidade(_produto));
        }

        public void ProdutoInvalido()
        {
            var produto = new Produto() { DataDeVencimento = new DateTime(2010, 01, 01) };
            
            Assert.IsFalse(new Produto().VerificaDataDeValidade(produto));
        }

    }
}
