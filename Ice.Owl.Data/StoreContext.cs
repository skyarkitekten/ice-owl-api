﻿using Ice.Owl.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Ice.Owl.Data {


public class StoreContext : DbContext 
{
    public StoreContext(DbContextOptions<StoreContext> options)
     : base(options)
     { }

public DbSet<Item>Items {get; set;}
    }
}