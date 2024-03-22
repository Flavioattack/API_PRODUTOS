using Application.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    internal interface IApplicationProduto : IGenericApplication<Produto>
    {
        Task AddProduto(Produto produto);
        Task UpdateProduto(Produto produto);
        Task DeleteProduto(int id);
        Task<List<Produto>> listActiveProdutos();
        Task<List<Produto>> listDisableProdutos();
    }
}
