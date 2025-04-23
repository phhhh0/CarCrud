using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CarCRUD.Data; 

#nullable disable

namespace CarCRUD.Migrations 
{
    [DbContext(typeof(ContextoCarro))] 
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
