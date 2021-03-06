// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Organista.Model;

#nullable disable

namespace Organista.Migrations
{
    [DbContext(typeof(ModelContext))]
    partial class ModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Organista.Model.Activity", b =>
                {
                    b.Property<ulong>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Bitter")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Cross")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Devotion")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Funeral")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Hours")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Mass")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Wedding")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Activities", (string)null);
                });

            modelBuilder.Entity("Organista.Model.Canto", b =>
                {
                    b.Property<ulong>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(260)
                        .HasColumnType("TEXT");

                    b.Property<ulong?>("SetID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("SetID");

                    b.ToTable("Cantos", (string)null);
                });

            modelBuilder.Entity("Organista.Model.Set", b =>
                {
                    b.Property<ulong>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("NameID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("NameID");

                    b.ToTable("Sets", (string)null);
                });

            modelBuilder.Entity("Organista.Model.SetName", b =>
                {
                    b.Property<ulong>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("SetNames", (string)null);
                });

            modelBuilder.Entity("Organista.Model.Canto", b =>
                {
                    b.HasOne("Organista.Model.Set", null)
                        .WithMany("Cantos")
                        .HasForeignKey("SetID");
                });

            modelBuilder.Entity("Organista.Model.Set", b =>
                {
                    b.HasOne("Organista.Model.SetName", "Name")
                        .WithMany()
                        .HasForeignKey("NameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Organista.Model.Set", b =>
                {
                    b.Navigation("Cantos");
                });
#pragma warning restore 612, 618
        }
    }
}
