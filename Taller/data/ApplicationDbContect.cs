using Microsoft.EntityFrameworkCore;
using Taller.models;

namespace Taller.data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Propietario> Propietarios { get; set;}
    public DbSet<Vehiculo> Vehiculos { get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}