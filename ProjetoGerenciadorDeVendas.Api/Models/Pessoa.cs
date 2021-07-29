using ProjetoGerenciadorDeVendas.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciadorDeVendas.Api.Models
{
    public class Pessoa : BaseClass
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public EnumGenero Genero { get; set; }
        public Endereco Endereco { get; set; }
    }
}
