using Domain.Interfaces.InterfaceServices;
using Infrastructure.Repository.Generics;
using Entities.Entities;
using Entities.Notifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IServiceProduto _IServiceProduto;
        public ProdutosController(IServiceProduto IServiceProduto)
        {
            _IServiceProduto = IServiceProduto;
        }
        [HttpGet]
        public async Task<ActionResult> ListarProdutosAtivos()
        {
            try
            {
                return Ok(await _IServiceProduto.listActiveProdutos());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar produtos. Erro: {ex.Message}");
            }
        }
        [Produces("application/json")]
        [HttpGet]
        public async Task<ActionResult> ListarProdutosInativos()
        {
            try
            {
                return Ok(await _IServiceProduto.listDisableProdutos());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar produtos. Erro: {ex.Message}");
            }
        }

        [Produces("application/json")]
        [HttpPost("/api/Produto/AddProduto")]
        public async Task<List<Notification>> AddProduto(ProdutoModel produto)
        {
            var newProduto = new Produto
            {
                Codigo = produto.Codigo,
                Nome = produto.Nome,
                descricaoProduto = produto.descricaoProduto,
                Valor = produto.Valor,
                Quantidade = produto.Quantidade,
                DataFabricacao = produto.DataFabricacao,
                DataValidade = produto.DataValidade,
                Situacao = produto.Situacao
            };
            await _IServiceProduto.AddProduto(newProduto);

            return newProduto.Notifications;
        }

        [Produces("application/json")]
        [HttpPost("/api/Produto/AddProduto")]
        public async Task<List<Notification>> UpdateProduto(ProdutoModel produto)
        {
            var Produto = _IServiceProduto
            Produto.Nome = produto.Nome;
            Produto.descricaoProduto = produto.descricaoProduto;
            Produto.Valor = produto.Valor;                
            Produto.Quantidade = produto.Quantidade;
            Produto.DataFabricacao = produto.DataFabricacao;
            Produto.DataValidade = produto.DataValidade;
            Produto.Situacao = produto.Situacao;


            await _IServiceProduto.AddProduto(newProduto);

            return newProduto.Notifications;
        }
    }
}

