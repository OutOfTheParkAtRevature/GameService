﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(SeasonContext))]
    partial class SeasonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Game", b =>
                {
                    b.Property<Guid>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AwayScore")
                        .HasColumnType("int");

                    b.Property<Guid>("AwayStatID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AwayTeamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HomeScore")
                        .HasColumnType("int");

                    b.Property<Guid>("HomeStatID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HomeTeamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SeasonID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WinningTeam")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Model.Season", b =>
                {
                    b.Property<Guid>("SeasonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeagueID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SeasonID");

                    b.ToTable("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
