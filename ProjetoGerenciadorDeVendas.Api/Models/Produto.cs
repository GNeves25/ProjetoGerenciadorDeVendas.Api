using ProjetoGerenciadorDeVendas.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public EnumCategoria Categoria { get; set; }

        public Produto() {}

        public Produto(string nome, int quantidade, DateTime dataDeVencimento, EnumCategoria categoria)
        {
            Nome = nome;
            Quantidade = quantidade;
            DataDeVencimento = dataDeVencimento;
            Categoria = categoria;
        }

        public bool VerificaDataDeValidade(Produto produto)
        {
            return produto.DataDeVencimento < DateTime.Now ? false : true;
        }

        public List<Produto> VerificaQuantidade(List<Produto> produtos)
        {
            var listaDeProdutos = new List<Produto>();

            foreach (var produto in produtos)
            {
                if (produto.Quantidade == 0)
                {
                    listaDeProdutos.Add(produto);
                }
            }

            return listaDeProdutos;
        }

    }
}
