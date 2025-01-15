using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using webApi.Models;

namespace webApi.Data
{
    public class ApplicationDbContext : DbContext
    {
      public  ApplicationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
    {
    
    }
     
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Data Source = localhost,1433; Initial Catalog=newsblog;Integrated Security=True; TrustServerCertificate=true; ", builder =>
        {
            builder.EnableRetryOnFailure(5, 
            TimeSpan.FromSeconds(10), 
            null);
        });
    base.OnConfiguring(optionsBuilder);
}

    public DbSet<Post> Posts {get; set;}
    public DbSet<Comment> Comments{get; set;}
        
    }
}