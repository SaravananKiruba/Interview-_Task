using Interview__Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Interview__Task.DATA
{
    public class INTTASKDBcontext : DbContext
    {
        public INTTASKDBcontext(DbContextOptions<INTTASKDBcontext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}


