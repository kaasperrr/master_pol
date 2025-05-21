using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Entities;

public partial class MasterPolBsvContext : DbContext
{
    public MasterPolBsvContext()
    {
    }

    public MasterPolBsvContext(DbContextOptions<MasterPolBsvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnerType> PartnerTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=masterPol_BSV;Trusted_Connection=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.IdPartner).HasName("PK__Partners__6A42E6698CE7ABE9");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.DirectorFirstName).HasMaxLength(100);
            entity.Property(e => e.DirectorLastName).HasMaxLength(100);
            entity.Property(e => e.DirectorMiddleName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasOne(d => d.IdPartnerTypeNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdPartnerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partners__IdPart__32E0915F");
        });

        modelBuilder.Entity<PartnerType>(entity =>
        {
            entity.HasKey(e => e.IdPartnerType).HasName("PK__PartnerT__9E6F6009D18E8ADE");

            entity.HasIndex(e => e.TypeName, "UQ__PartnerT__D4E7DFA80FDF50D6").IsUnique();

            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__Products__2E8946D43648074F");

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.IdProductTypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__IdProd__38996AB5");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.IdProductType).HasName("PK__ProductT__D51B4454ECBDFC88");

            entity.HasIndex(e => e.TypeName, "UQ__ProductT__D4E7DFA874D8CEC1").IsUnique();

            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.IdSale).HasName("PK__Sales__A04F9B37B4637E6D");

            entity.Property(e => e.SaleDate).HasColumnType("date");

            entity.HasOne(d => d.IdPartnerNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__IdPartner__3C69FB99");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__IdProduct__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
