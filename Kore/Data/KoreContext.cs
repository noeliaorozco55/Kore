#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kore.Models;

namespace Kore.Data
{
    public class KoreContext : DbContext
    {
        public KoreContext (DbContextOptions<KoreContext> options)
            : base(options)
        {
        }

        public DbSet<Kore.Models.Producto> Producto { get; set; }
    }
}
