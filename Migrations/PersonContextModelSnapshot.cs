using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CarCRUD.Data; // Corrigido para CarCRUD.Data

#nullable disable

namespace CarCRUD.Migrations // Corrigido para CarCRUD.Migrations
{
    [DbContext(typeof(ContextoCarro))] // Corrigido para ContextoCarro
    public class CarCRUDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("CarCRUD.Models.CarroModelo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<string>("Modelo")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Carros");
            });
        }
    }
}