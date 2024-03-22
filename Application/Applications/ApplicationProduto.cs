using Application.Interfaces;
using Entities.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Applications
{
    public class ApplicationProduto : IApplicationProduto
    {
        IProduto
        public ApplicationProduto() 
        {

        }

        public Task Add(Produto Objeto)
        {
            throw new NotImplementedException();
        }

        public Task AddProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Produto Objeto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> List()
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> listActiveProdutos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> listDisableProdutos()
        {
            throw new NotImplementedException();
        }

        public Task Update(Produto Objeto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
