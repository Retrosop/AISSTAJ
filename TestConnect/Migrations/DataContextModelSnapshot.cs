﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestConnectDB;

#nullable disable

namespace TestConnectDB.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestConnectDB.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommentsWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SotrudnikIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SotrudnikIdId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("TestConnectDB.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nomerreport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StajIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StajIdId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("TestConnectDB.Sotrudnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dater")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pol")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sotrudnik");
                });

            modelBuilder.Entity("TestConnectDB.Staj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginWorkSotrudnik")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndWorkSotrudnik")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GosWorkSotrudnik")
                        .HasColumnType("datetime2");

                    b.Property<int>("SotrudnikIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SotrudnikIdId");

                    b.ToTable("Staj");
                });

            modelBuilder.Entity("TestConnectDB.Comment", b =>
                {
                    b.HasOne("TestConnectDB.Sotrudnik", "SotrudnikId")
                        .WithMany()
                        .HasForeignKey("SotrudnikIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SotrudnikId");
                });

            modelBuilder.Entity("TestConnectDB.Report", b =>
                {
                    b.HasOne("TestConnectDB.Staj", "StajId")
                        .WithMany()
                        .HasForeignKey("StajIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StajId");
                });

            modelBuilder.Entity("TestConnectDB.Staj", b =>
                {
                    b.HasOne("TestConnectDB.Sotrudnik", "SotrudnikId")
                        .WithMany()
                        .HasForeignKey("SotrudnikIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SotrudnikId");
                });
#pragma warning restore 612, 618
        }
    }
}
