﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Xml;



namespace BusinessObjects.Model;

public partial class FuflowerBouquetManagementV4Context : DbContext
{
    public FuflowerBouquetManagementV4Context()
    {
    }

    public FuflowerBouquetManagementV4Context(DbContextOptions<FuflowerBouquetManagementV4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<FlowerBouquet> FlowerBouquets { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DefaultConnection"];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A2BCBB61074");

            entity.ToTable("Category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryDescription).HasMaxLength(150);
            entity.Property(e => e.CategoryName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CategoryNote).HasMaxLength(150);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B8947D39E6");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(180)
                .IsUnicode(false);
            entity.Property(e => e.CustomerStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlowerBouquet>(entity =>
        {
            entity.HasKey(e => e.FlowerBouquetId).HasName("PK__FlowerBo__A1391301F87964F5");

            entity.ToTable("FlowerBouquet");

            entity.Property(e => e.FlowerBouquetId)
                .ValueGeneratedNever()
                .HasColumnName("FlowerBouquetID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Description)
                .HasMaxLength(220)
                .IsUnicode(false);
            entity.Property(e => e.FlowerBouquetName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Morphology).HasMaxLength(250);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Category).WithMany(p => p.FlowerBouquets)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__FlowerBou__Categ__2F10007B");

            entity.HasOne(d => d.Supplier).WithMany(p => p.FlowerBouquets)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__FlowerBou__Suppl__300424B4");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Order__C3905BAF1703EF48");

            entity.ToTable("Order");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("money");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Order__CustomerI__30F848ED");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.FlowerBouquetId }).HasName("PK__OrderDet__C983CA9F7F2D32D3");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.FlowerBouquetId).HasColumnName("FlowerBouquetID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.FlowerBouquet).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.FlowerBouquetId)
                .HasConstraintName("FK__OrderDeta__Flowe__31EC6D26");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__32E0915F");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier");

            entity.Property(e => e.SupplierId)
                .ValueGeneratedNever()
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierAddress).HasMaxLength(150);
            entity.Property(e => e.SupplierName).HasMaxLength(50);
            entity.Property(e => e.Telephone)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public (string, string) GetAdminAccount()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        return (configuration["AdminAccount:email"], configuration["AdminAccount:password"]);
    }

}
