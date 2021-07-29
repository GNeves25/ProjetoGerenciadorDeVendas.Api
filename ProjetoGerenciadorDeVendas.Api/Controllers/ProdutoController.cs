using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoGerenciadorDeVendas.Api.Data;
using ProjetoGerenciadorDeVendas.Api.Models;
using ProjetoGerenciadorDeVendas.Api.Services;

namespace ProjetoGerenciadorDeVendas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Produto>> GetAllProdutosAsync()
        {
            return await _produtoService.ListAsync();
        }
        
        [HttpGet("{id}")]        
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _produtoService.FindByIdAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        [HttpPut("{id}")]
        public IActionResult PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            try
            {
                _produtoService.Update(produto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_produtoService.ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            await _produtoService.AddAsync(produto);

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        [HttpDelete("{id}")]
        public ActionResult<Produto> DeleteProduto(int id)
        {
            var produto = _produtoService.FindByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _produtoService.Remove(produto.Result);

            return Ok();

        }
    }
}
