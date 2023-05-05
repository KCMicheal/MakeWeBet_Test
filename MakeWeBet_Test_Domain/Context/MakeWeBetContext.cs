using MakeWeBet_Test_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeWeBet_Test_Domain.Context
{
    public class MakeWeBetContext : DbContext
    {
        public MakeWeBetContext()
        {
                
        }

        public MakeWeBetContext(DbContextOptions<MakeWeBetContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
