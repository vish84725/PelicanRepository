﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DellyShopApp.Models;

namespace DellyShopApp.DAL.DAO
{
    interface IProductDAO
    {
        Task<List<Product>> GetAllProducts();
        Task<bool> SaveProducts(List<Product> products);
    }
}
