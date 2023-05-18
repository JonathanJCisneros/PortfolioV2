﻿using PortfolioV2.Core.Entities;
using PortfolioV2.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioV2.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDb Db;

        public UserRepository(AppDb db) 
        {
            Db = db; 
        }
        
        public async Task<bool> CheckById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Get(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<string> Create(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Update(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}