﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;

namespace UnitOfWorkDemo.Infastructure;

public class DbContextClass:DbContext
{
    public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
    {

    }
    
    public DbSet<ProductDetails> Products { get; set; }
}
