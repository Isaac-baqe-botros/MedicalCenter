using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medical_Center.Models;

public partial class MedicalCenterContext : IdentityDbContext<IdentityUser>
{
    public MedicalCenterContext(DbContextOptions<MedicalCenterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }
    public virtual DbSet<Billing> Billings { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Doctor> Doctors { get; set; }
    public virtual DbSet<InsuranceProvider> InsuranceProviders { get; set; }
    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }
    public virtual DbSet<Patient> Patients { get; set; }
    public virtual DbSet<Prescription> Prescriptions { get; set; }
    public virtual DbSet<Staff> Staff { get; set; }
    public virtual DbSet<Admin> Admins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Billing>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK__Billing__11F2FC4A5A36CC6A");
            entity.ToTable("Billing");
            entity.Property(e => e.BillId).ValueGeneratedOnAdd().HasColumnName("BillID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DateOfBill).HasColumnType("date");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PaymentMethod).HasMaxLength(20).IsUnicode(false);
            entity.Property(e => e.PaymentStatus).HasMaxLength(20).IsUnicode(false);
            entity.HasOne(d => d.Patient).WithMany(p => p.Billings)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Billing__Patient__5DCAEF64");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK_Departments");
            entity.Property(e => e.DepartmentId).ValueGeneratedOnAdd().HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Location).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15).IsUnicode(false);
        });

        // Add configuration for other entities...
    }
}
