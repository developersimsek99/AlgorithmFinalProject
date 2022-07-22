﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmFinalProject
{
    public class EMarketingContext : DbContext
    {
        public DbSet<Product>Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
