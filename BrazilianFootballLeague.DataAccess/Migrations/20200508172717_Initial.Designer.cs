﻿// <auto-generated />
using BrazilianFootballLeague.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrazilianFootballLeague.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200508172717_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions_ResultTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Drawn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalsAgainst")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalsFor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Lost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Played")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeasonID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Won")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("SeasonID");

                    b.HasIndex("TeamID");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions_Seasons", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompetitionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CompetitionID");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.States", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("States");
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Teams", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<int>("StateID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("StateID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions_ResultTable", b =>
                {
                    b.HasOne("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions_Seasons", "Season")
                        .WithMany("Results")
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrazilianFootballLeague.DataAccess.BusinessObjects.Teams", "Team")
                        .WithMany("Results")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions_Seasons", b =>
                {
                    b.HasOne("BrazilianFootballLeague.DataAccess.BusinessObjects.Competitions", "Competition")
                        .WithMany("Seasons")
                        .HasForeignKey("CompetitionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrazilianFootballLeague.DataAccess.BusinessObjects.Teams", b =>
                {
                    b.HasOne("BrazilianFootballLeague.DataAccess.BusinessObjects.States", "State")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
