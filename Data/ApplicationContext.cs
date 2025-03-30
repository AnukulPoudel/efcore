using System;
using Microsoft.EntityFrameworkCore;
using efcore.Models;
namespace Data.ApplicationContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option) { }
        public DbSet<Employe> employes { get; set; }
    }
}
