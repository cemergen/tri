using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tri.entity;

namespace tri.data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("DatabaseContext")
        {
        }
        public DbSet<Invoice> InvoiceList { get; set; }
        public DbSet<Account> AccountList { get; set; }
    }
}
