using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NIPWebAppBase.Entities;

namespace NIPWebAppBase.Data
{
    public class NIPContext : DbContext
    {
        public NIPContext() : base("NIPDb")
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
