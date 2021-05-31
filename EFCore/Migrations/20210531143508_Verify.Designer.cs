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
    [Migration("20210531143508_Verify")]
    partial class Verify
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.Model.Bid", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Bid");
                });

            modelBuilder.Entity("EFCore.Model.Bid", b =>
                {
                    b.OwnsOne("EFCore.Model.Allocation", "ActualAllocation", b1 =>
                        {
                            b1.Property<Guid>("BidId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("BidId");

                            b1.ToTable("Bid");

                            b1.WithOwner()
                                .HasForeignKey("BidId");

                            b1.OwnsOne("EFCore.Model.ConfirmableValue<EFCore.Model.Capacity>", "Capacity", b2 =>
                                {
                                    b2.Property<Guid>("AllocationBidId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<bool>("Confirmed")
                                        .HasColumnType("bit");

                                    b2.HasKey("AllocationBidId");

                                    b2.ToTable("Bid");

                                    b2.WithOwner()
                                        .HasForeignKey("AllocationBidId");

                                    b2.OwnsOne("EFCore.Model.Capacity", "Value", b3 =>
                                        {
                                            b3.Property<Guid>("ConfirmableValue<Capacity>AllocationBidId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<decimal>("Value")
                                                .HasColumnType("decimal(18,2)");

                                            b3.HasKey("ConfirmableValue<Capacity>AllocationBidId");

                                            b3.ToTable("Bid");

                                            b3.WithOwner()
                                                .HasForeignKey("ConfirmableValue<Capacity>AllocationBidId");
                                        });

                                    b2.Navigation("Value");
                                });

                            b1.Navigation("Capacity");
                        });

                    b.OwnsOne("EFCore.Model.Allocation", "ExpectedAllocation", b1 =>
                        {
                            b1.Property<Guid>("BidId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("BidId");

                            b1.ToTable("Bid");

                            b1.WithOwner()
                                .HasForeignKey("BidId");

                            b1.OwnsOne("EFCore.Model.ConfirmableValue<EFCore.Model.Capacity>", "Capacity", b2 =>
                                {
                                    b2.Property<Guid>("AllocationBidId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<bool>("Confirmed")
                                        .HasColumnType("bit");

                                    b2.HasKey("AllocationBidId");

                                    b2.ToTable("Bid");

                                    b2.WithOwner()
                                        .HasForeignKey("AllocationBidId");

                                    b2.OwnsOne("EFCore.Model.Capacity", "Value", b3 =>
                                        {
                                            b3.Property<Guid>("ConfirmableValue<Capacity>AllocationBidId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<decimal>("Value")
                                                .HasColumnType("decimal(18,2)");

                                            b3.HasKey("ConfirmableValue<Capacity>AllocationBidId");

                                            b3.ToTable("Bid");

                                            b3.WithOwner()
                                                .HasForeignKey("ConfirmableValue<Capacity>AllocationBidId");
                                        });

                                    b2.Navigation("Value");
                                });

                            b1.Navigation("Capacity");
                        });

                    b.Navigation("ActualAllocation");

                    b.Navigation("ExpectedAllocation");
                });
#pragma warning restore 612, 618
        }
    }
}
