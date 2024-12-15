using Microsoft.EntityFrameworkCore;
using webuyglama.Models;

namespace webuyglama.Utility
{
    public class UygulamaDBContext : DbContext
    {
        public UygulamaDBContext(DbContextOptions<UygulamaDBContext> options) : base(options) { }
    
     public DbSet<KitapTuru> KitapTurleri { get; set; } 
    }
}
