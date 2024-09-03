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
                .WithMany(p => p.Vehiculos)
                .HasForeignKey(v => v.PropietarioId);
        });

        // modelBuilder.Entity<Propietario>(vehiculo => {
        //     vehiculo.ToTable("Propietario");
        //     vehiculo.Property(p => p.Id ).ValueGeneratedOnAdd();
        //     vehiculo.Property(p => p.Nombre).HasMaxLength(50).IsRequired();
        //     vehiculo.Property(p => p.Apellido).HasMaxLength(50).IsRequired();
        //     vehiculo.Property(p => p.NumeroDeIdentificacion).IsRequired();
        //     vehiculo.Property(p => p.FotoPerfil).IsRequired().HasMaxLength(50);
        //     vehiculo.Property(p => p.Direccion).HasMaxLength(50).IsRequired();
        //     vehiculo.Property(p => p.Telefono).HasMaxLength(50).IsRequired();
        //     vehiculo.Property(p => p.Correo).HasMaxLength(50).IsRequired();
        //     vehiculo.HasOne(p => p.Vehiculos)
        //         .WithMany(v => v.Propietario)
        //         .HasForeignKey(p => p.VehiculoId);
        // });
  
    }
    
}