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
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Vehiculo>(vehiculo => {
            vehiculo.ToTable("Vehiculos");
            vehiculo.Property(v => v.Id).ValueGeneratedOnAdd();
            vehiculo.Property(v => v.Marca).HasMaxLength(50).IsRequired();
            vehiculo.Property(v => v.Modelo).HasMaxLength(50).IsRequired();
            vehiculo.Property(v => v.PropietarioId).IsRequired();
            vehiculo.Property(v => v.Año).IsRequired().HasMaxLength(50);
            vehiculo.Property(v => v.Color).HasMaxLength(50).IsRequired();
            vehiculo.Property(v => v.TipoVehiculo).HasMaxLength(50).IsRequired();
            vehiculo.Property(v => v.NumeroChasis).HasMaxLength(50).IsRequired();
            vehiculo.HasOne(v => v.Propietario)
            .HasForeignKey(v => v.PropietarioId);
        });
  
    }
    
}