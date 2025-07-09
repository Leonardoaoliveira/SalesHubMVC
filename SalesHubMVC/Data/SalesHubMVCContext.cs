using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesHubMVC.Models;

namespace SalesHubMVC.Data
{
    public class SalesHubMVCContext : DbContext
    {
        public SalesHubMVCContext (DbContextOptions<SalesHubMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesHubMVC.Models.Department> Department { get; set; } = default!;
    }
}
