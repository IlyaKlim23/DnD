﻿// <auto-generated />
using DungeonAndDragons.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DungeonAndDragons.Core.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20240109073750_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DungeonAndDragons.Core.Entities.Enemy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ArmorClass")
                        .HasColumnType("integer");

                    b.Property<int>("AttackModifier")
                        .HasColumnType("integer");

                    b.Property<int>("AttackPerRound")
                        .HasColumnType("integer");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DamageModifier")
                        .HasColumnType("integer");

                    b.Property<int>("HitPoints")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArmorClass = 24,
                            AttackModifier = 18,
                            AttackPerRound = 2,
                            Damage = "10d8",
                            DamageModifier = 5,
                            HitPoints = 220,
                            Name = "Ави"
                        },
                        new
                        {
                            Id = 2,
                            ArmorClass = 50,
                            AttackModifier = 144,
                            AttackPerRound = 1,
                            Damage = "24d12",
                            DamageModifier = 7,
                            HitPoints = 300,
                            Name = "Аллозавр"
                        },
                        new
                        {
                            Id = 3,
                            ArmorClass = 111,
                            AttackModifier = 70,
                            AttackPerRound = 1,
                            Damage = "10d8",
                            DamageModifier = 3,
                            HitPoints = 120,
                            Name = "Булезау"
                        },
                        new
                        {
                            Id = 4,
                            ArmorClass = 9,
                            AttackModifier = 12,
                            AttackPerRound = 1,
                            Damage = "24d12",
                            DamageModifier = -2,
                            HitPoints = 5,
                            Name = "Ворон"
                        },
                        new
                        {
                            Id = 5,
                            ArmorClass = 50,
                            AttackModifier = 0,
                            AttackPerRound = 3,
                            Damage = "9d8",
                            DamageModifier = -2,
                            HitPoints = 100,
                            Name = "Василиск"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}