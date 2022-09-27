using CLIENT_APP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLIENT_APP.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) :base(options) { }
        public DbSet<Master> Masters { get; set; }
    }
}


