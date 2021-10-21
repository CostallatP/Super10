using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Super10.Models;

namespace Super10.Data
{
    public class Super10Context : DbContext
    {
        public Super10Context (DbContextOptions<Super10Context> options)
            : base(options)
        {
        }

        public DbSet<Super10.Models.Produtos> Produtos { get; set; }
    }
}
