﻿// <auto-generated />
using System;
using System.Collections.Generic;
using BloodDonation.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodDonation.Infrastructure.Migrations
{
    [DbContext(typeof(BloodDonationDbContext))]
    partial class BloodDonationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BloodDonation.Domain.Entities.BloodStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BloodType")
                        .HasColumnType("int");

                    b.Property<int>("QuantityInMililiters")
                        .HasColumnType("int");

                    b.Property<int>("RhFactor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BloodType");

                    b.ToTable("BloodStorage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodType = 0,
                            QuantityInMililiters = 0,
                            RhFactor = 0
                        },
                        new
                        {
                            Id = 2,
                            BloodType = 0,
                            QuantityInMililiters = 0,
                            RhFactor = 1
                        },
                        new
                        {
                            Id = 3,
                            BloodType = 1,
                            QuantityInMililiters = 0,
                            RhFactor = 0
                        },
                        new
                        {
                            Id = 4,
                            BloodType = 1,
                            QuantityInMililiters = 0,
                            RhFactor = 1
                        },
                        new
                        {
                            Id = 5,
                            BloodType = 2,
                            QuantityInMililiters = 0,
                            RhFactor = 0
                        },
                        new
                        {
                            Id = 6,
                            BloodType = 2,
                            QuantityInMililiters = 0,
                            RhFactor = 1
                        },
                        new
                        {
                            Id = 7,
                            BloodType = 3,
                            QuantityInMililiters = 0,
                            RhFactor = 0
                        },
                        new
                        {
                            Id = 8,
                            BloodType = 3,
                            QuantityInMililiters = 0,
                            RhFactor = 1
                        });
                });

            modelBuilder.Entity("BloodDonation.Domain.Entities.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityInMililiters")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonationDate");

                    b.HasIndex("DonorId");

                    b.ToTable("Donation");
                });

            modelBuilder.Entity("BloodDonation.Domain.Entities.Donor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BloodType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("RhFactor")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.ComplexProperty<Dictionary<string, object>>("Address", "BloodDonation.Domain.Entities.Donor.Address#Address", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PublicArea")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ZipCode")
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Donor");
                });

            modelBuilder.Entity("BloodDonation.Domain.Entities.Donation", b =>
                {
                    b.HasOne("BloodDonation.Domain.Entities.Donor", "Donor")
                        .WithMany("Donations")
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donor");
                });

            modelBuilder.Entity("BloodDonation.Domain.Entities.Donor", b =>
                {
                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}