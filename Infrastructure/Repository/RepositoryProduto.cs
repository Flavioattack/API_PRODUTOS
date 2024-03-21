using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryProduto : RepositoryGenerics<Produto>, IProduto
    {
        private readonly DbContextOptions<Context> _optionsBuilder;
        public RepositoryProduto() 
        {
            _optionsBuilder = new DbContextOptions<Context>();
        }
        public async Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto)
        {
            using (var data = new Context(_optionsBuilder))
            {
                return await data.Set<Produto>().AsNoTracking().Where(exProduto).ToListAsync();
            }   
        }
    }
}
