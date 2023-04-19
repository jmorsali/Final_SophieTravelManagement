﻿// <auto-generated />
using System;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_SophieTravelManagement.Infrastructure.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20230416101020_Init_Read")]
    partial class Init_Read
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("TravelerCheckList")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_SophieTravelManagement.Infrastructure.EF.Models.TravelerCheckListReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TravelerCheckList", "TravelerCheckList");
                });

            modelBuilder.Entity("Final_SophieTravelManagement.Infrastructure.EF.Models.TravelerItemReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<Guid>("TravelerCheckListId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TravelerCheckListId");

                    b.ToTable("TravelerItems", "TravelerCheckList");
                });

            modelBuilder.Entity("Final_SophieTravelManagement.Infrastructure.EF.Models.TravelerItemReadModel", b =>
                {
                    b.HasOne("Final_SophieTravelManagement.Infrastructure.EF.Models.TravelerCheckListReadModel", "TravelerCheckList")
                        .WithMany("Items")
                        .HasForeignKey("TravelerCheckListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelerCheckList");
                });

            modelBuilder.Entity("Final_SophieTravelManagement.Infrastructure.EF.Models.TravelerCheckListReadModel", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
