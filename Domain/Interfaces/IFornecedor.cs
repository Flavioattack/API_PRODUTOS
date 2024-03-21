﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFornecedor
    {
        Task AddFornecedor(Fornecedor fornecedor);
        Task UpdateFornecedor(Fornecedor fornecedor);
        Task<List<Fornecedor>> ListFornecedores();
    }
}
