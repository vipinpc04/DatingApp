using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data;
public class DataContext : DbContext
{
    public DbSet<AppUser> Users { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}
