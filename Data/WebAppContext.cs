using Microsoft.EntityFrameworkCore;
using Teo_PC03.Models;

namespace Teo_PC03.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Formulario> Formularios { get; set; }
        public WebAppContext(DbContextOptions dco) : base(dco){

        }
    }
}