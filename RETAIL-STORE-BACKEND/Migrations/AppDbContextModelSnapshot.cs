﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RETAIL_STORE_BACKEND.Data;

#nullable disable

namespace RETAIL_STORE_BACKEND.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.Colour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Shade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colours");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.ProductColours", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ColourId");

                    b.HasIndex("ColourId");

                    b.ToTable("ProductColouts");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.ProductPowers", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PowerId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "PowerId");

                    b.HasIndex("PowerId");

                    b.ToTable("ProductPowers");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.ProductColours", b =>
                {
                    b.HasOne("RETAIL_STORE_BACKEND.Models.Colour", "Colour")
                        .WithMany("ProCol")
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RETAIL_STORE_BACKEND.Models.Product", "Product")
                        .WithMany("ProCol")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colour");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.ProductPowers", b =>
                {
                    b.HasOne("RETAIL_STORE_BACKEND.Models.Power", "Power")
                        .WithMany("ProPow")
                        .HasForeignKey("PowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RETAIL_STORE_BACKEND.Models.Product", "Product")
                        .WithMany("ProPow")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Power");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.Colour", b =>
                {
                    b.Navigation("ProCol");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.Power", b =>
                {
                    b.Navigation("ProPow");
                });

            modelBuilder.Entity("RETAIL_STORE_BACKEND.Models.Product", b =>
                {
                    b.Navigation("ProCol");

                    b.Navigation("ProPow");
                });
#pragma warning restore 612, 618
        }
    }
}
