﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioV2.Core
{
    public interface IBaseInterface<T> where T : class
    {
        Task<bool> CheckById(string id);

        Task<T> Get(string id);

        Task<List<T>> GetAll();

        Task<string> Create(T entity);

        Task<string> Update(T entity);

        Task<bool> Delete(string id);
    }
}