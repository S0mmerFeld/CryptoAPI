using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CryptoAPI.DAL.Context
{
    class CryptoAPIContext : DbContext
    {
        public CryptoAPIContext(DbContextOptions<CryptoAPIContext> options)
             : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
