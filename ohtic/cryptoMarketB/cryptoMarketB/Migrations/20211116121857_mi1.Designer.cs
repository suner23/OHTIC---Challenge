﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cryptoMarketB.Data;

namespace cryptoMarketB.Migrations
{
    [DbContext(typeof(cryptoMarketBContext))]
    [Migration("20211116121857_mi1")]
    partial class mi1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cryptoMarketB.Models.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarketCap")
                        .HasColumnType("int");

                    b.Property<int>("MaxSupply")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalSupply")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Coin");
                });

            modelBuilder.Entity("cryptoMarketB.Models.Exchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoinId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TradingVolume")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoinId");

                    b.ToTable("Exchange");
                });

            modelBuilder.Entity("cryptoMarketB.Models.Exchange", b =>
                {
                    b.HasOne("cryptoMarketB.Models.Coin", null)
                        .WithMany("Exchanges")
                        .HasForeignKey("CoinId");
                });
#pragma warning restore 612, 618
        }
    }
}
