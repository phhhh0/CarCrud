
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CarCRUD.Data;

#nullable disable

namespace CarCRUD.Migrations 
{
    [DbContext(typeof(ContextoCarro))] 
    partial class Inicial
    {
       
        protected void BuildModel(ModelBuilder modelBuilder) 
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

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
#pragma warning restore 612, 618
        }
    }
}
