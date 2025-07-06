using ASP.NET_MVC_01_NET8.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_01_NET8.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Country> Countries { get; set; }

    }
}
