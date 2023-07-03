using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbCon
{
    public class MyDb : DbContext
    {
        public MyDb( DbContextOptions<MyDb> options ) : base( options )
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
