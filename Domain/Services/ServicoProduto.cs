using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Services
{
    public class ServicoProduto : IServiceProduto
    {
        private readonly IProduto _IProduto;

        public ServicoProduto(IProduto IProduto)
        {
            _IProduto = IProduto;
        }

        public async Task AddProduto(Produto produto)
        {
            var validaNome = produto.ValidateString(produto.Nome, "Nome");
            var validarValidade = produto.ValidateValidade(produto.DataFabricacao, produto.DataValidade, "DataValidade");

            if(validaNome && validarValidade)
            {
                produto.dataInclusao = DateTime.Now;
                produto.Situacao = "Ativo";
                await _IProduto.Add(produto);
            }
        }
        public async Task UpdateProduto(Produto produto)
        {
            var validaNome = produto.ValidateString(produto.Nome, "Nome");
            var validarValidade = produto.ValidateValidade(produto.DataFabricacao, produto.DataValidade, "DataValidade");

            if (validaNome && validarValidade)
            {
                produto.dataInclusao = DateTime.Now;
                produto.Situacao = "Ativo";
                await _IProduto.Update(produto);
            }
        }

        public async Task DeleteProduto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Produto>> listActiveProdutos()
        {
            return await _IProduto.ListarProdutos(p => p.Situacao == "Ativo");
        }
        public async Task<List<Produto>> listDisableProdutos()
        {
            return await _IProduto.ListarProdutos(p => p.Situacao == "Inativo");
        }
    }
}
