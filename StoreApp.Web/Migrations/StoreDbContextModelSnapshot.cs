﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Concrete;

#nullable disable

namespace StoreApp.Web.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("StoreApp.Data.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Url")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Notebook",
                            Url = "notebook"
                        },
                        new
                        {
                            Id = 3,
                            Name = "MP3 Player",
                            Url = "mp3-player"
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cox gozel telefon",
                            Name = "Samsung S24",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cox gozel telefon",
                            Name = "Samsung S25",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cox gozel telefon",
                            Name = "Samsung S26",
                            Price = 2500m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cox gozel telefon",
                            Name = "IPhone 11 pro",
                            Price = 2500m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cox gozel telefon",
                            Name = "IPhone 12 pro Max",
                            Price = 2800m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Cox serfeli telefon",
                            Name = "IPhone 15 pro Max",
                            Price = 3800m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Cox bahali notebook",
                            Name = "Apple Mac Book",
                            Price = 4800m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Cox guclu notebook",
                            Name = "Asus Excalibur",
                            Price = 4500m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Cox guclu sesi var",
                            Name = "Air Drop Apple",
                            Price = 280m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Cox gozel qulagciq",
                            Name = "HP OMEN blue",
                            Price = 300m
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 6
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 7
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 8
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Concrete.ProductCategory", b =>
                {
                    b.HasOne("StoreApp.Data.Concrete.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreApp.Data.Concrete.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
