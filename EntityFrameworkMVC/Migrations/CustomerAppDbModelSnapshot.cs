﻿// <auto-generated />
using EntityFrameworkMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkMVC.Migrations
{
    [DbContext(typeof(CustomerAppDb))]
    partial class CustomerAppDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkMVC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberShipId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("MemberShipId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 4,
                            MemberShipId = 1,
                            Name = "Ram"
                        },
                        new
                        {
                            CustomerId = 5,
                            MemberShipId = 2,
                            Name = "Rama"
                        },
                        new
                        {
                            CustomerId = 6,
                            MemberShipId = 2,
                            Name = "Ramji"
                        });
                });

            modelBuilder.Entity("EntityFrameworkMVC.Models.MemberShip", b =>
                {
                    b.Property<int>("MemberShipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("DurationInMonths")
                        .HasColumnType("int");

                    b.Property<int>("SignUpFee")
                        .HasColumnType("int");

                    b.HasKey("MemberShipId");

                    b.ToTable("Memberships");

                    b.HasData(
                        new
                        {
                            MemberShipId = 1,
                            Discount = 0,
                            DurationInMonths = 0,
                            SignUpFee = 0
                        },
                        new
                        {
                            MemberShipId = 2,
                            Discount = 10,
                            DurationInMonths = 3,
                            SignUpFee = 300
                        },
                        new
                        {
                            MemberShipId = 3,
                            Discount = 15,
                            DurationInMonths = 6,
                            SignUpFee = 600
                        },
                        new
                        {
                            MemberShipId = 4,
                            Discount = 20,
                            DurationInMonths = 12,
                            SignUpFee = 900
                        });
                });

            modelBuilder.Entity("EntityFrameworkMVC.Models.Customer", b =>
                {
                    b.HasOne("EntityFrameworkMVC.Models.MemberShip", "MemberShip")
                        .WithMany("Customers")
                        .HasForeignKey("MemberShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
