﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

#nullable disable

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    partial class ParksApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("Fee")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "Crater Lake inspires awe.",
                            Fee = 30,
                            Name = "Crater Lake"
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "No agates, but a great place to see the sunset.",
                            Fee = 0,
                            Name = "Agate Beach State Recreation Site"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "This park has great birdwatching and tidepools to explore.",
                            Fee = 0,
                            Name = "Fogarty Creek State Recreation Area"
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "Eons of acidic water seeping into marble rock created and decorated these wondrous marble halls.",
                            Fee = 5,
                            Name = "Oregon Caves National Monument"
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "Colorful rock formations preserve a world class record of plant and animal evolution, changing climate, and past ecosystems that span over 40 million years.",
                            Fee = 0,
                            Name = "John Day Fossil Beds National Monument"
                        },
                        new
                        {
                            ParkId = 6,
                            Description = "This convergence of three geologically distinct mountain ranges has resulted in an area with unparalleled biological diversity and a tremendously varied landscape.",
                            Fee = 0,
                            Name = "Cascade-Siskiyou National Monument"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
