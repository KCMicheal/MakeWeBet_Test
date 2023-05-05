using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeWeBet_Test_Domain.Context
{
    public class MakeWeBetContextFactory : IDesignTimeDbContextFactory<MakeWeBetContext>
    {
        public MakeWeBetContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());

            var builder = new DbContextOptionsBuilder<MakeWeBetContext>();

            builder.UseSqlServer(configuration.GetConnectionString("sqlConnection"));
            return new MakeWeBetContext(builder.Options);
        }
    }
}
