﻿// <auto-generated />
using System;
using AdActivity.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdActivity.Infra.Data.Migrations
{
    [DbContext(typeof(AdActivityDBContext))]
    [Migration("20200716155002_Migration3")]
    partial class Migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdActivity.Domain.Models.Brand", b =>
                {
                    b.Property<int>("BRNId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BRNEffectDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BRNEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BRNType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BRNId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AdActivity.Domain.Models.Campaign", b =>
                {
                    b.Property<int>("CAMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BRNId")
                        .HasColumnType("int");

                    b.Property<int?>("BrandBRNId")
                        .HasColumnType("int");

                    b.Property<string>("CAMDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CAMName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FundingTypeId")
                        .HasColumnType("int");

                    b.Property<string>("IsPlaceholder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CAMId");

                    b.HasIndex("BrandBRNId");

                    b.HasIndex("FundingTypeId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("AdActivity.Domain.Models.FundingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FundingTypes");
                });

            modelBuilder.Entity("AdActivity.Domain.Models.Campaign", b =>
                {
                    b.HasOne("AdActivity.Domain.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandBRNId");

                    b.HasOne("AdActivity.Domain.Models.FundingType", "FundingType")
                        .WithMany()
                        .HasForeignKey("FundingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
