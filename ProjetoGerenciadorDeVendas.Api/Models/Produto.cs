using ProjetoGerenciadorDeVendas.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Models
{
    [Table("PRODUTO")]
    public class Produto : BaseClass
    {
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }
        [Column("DATA_DE_VENCIMENTO")]
        public DateTime DataDeVencimento { get; set; }
        [Column("CATEGORIA")]
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
