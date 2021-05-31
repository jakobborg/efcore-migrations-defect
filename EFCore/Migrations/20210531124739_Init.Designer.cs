﻿// <auto-generated />
using System;
using EFCore.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20210531124739_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.Model.FinancialsRevenue", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FinancialsRevenue");
                });

            modelBuilder.Entity("EFCore.Model.PowerPurchaseAgreement", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FinancialsRevenueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FinancialsRevenueId");

                    b.ToTable("PowerPurchaseAgreement");
                });

            modelBuilder.Entity("EFCore.Model.PowerPurchaseAgreement", b =>
                {
                    b.HasOne("EFCore.Model.FinancialsRevenue", null)
                        .WithMany("PowerPurchaseAgreements")
                        .HasForeignKey("FinancialsRevenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("EFCore.Model.Fid", "Fid", b1 =>
                        {
                            b1.Property<Guid>("PowerPurchaseAgreementId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .HasMaxLength(8)
                                .HasColumnType("nvarchar(8)")
                                .HasColumnName("Fid");

                            b1.HasKey("PowerPurchaseAgreementId");

                            b1.ToTable("PowerPurchaseAgreement");

                            b1.WithOwner()
                                .HasForeignKey("PowerPurchaseAgreementId");
                        });

                    b.Navigation("Fid");
                });

            modelBuilder.Entity("EFCore.Model.FinancialsRevenue", b =>
                {
                    b.Navigation("PowerPurchaseAgreements");
                });
#pragma warning restore 612, 618
        }
    }
}