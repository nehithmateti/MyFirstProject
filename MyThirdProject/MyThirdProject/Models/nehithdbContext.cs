using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyThirdProject.Models
{
    public partial class nehithdbContext : DbContext
    {
        public nehithdbContext()
        {
        }

        public nehithdbContext(DbContextOptions<nehithdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblEmployee> TblEmployees { get; set; } = null!;
        public virtual DbSet<TblStudentDetail> TblStudentDetails { get; set; } = null!;
        public virtual DbSet<TblStudentMark> TblStudentMarks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-L288TTL4\\SQLEXPRESS;Database=nehithdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Employee");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("empid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<TblStudentDetail>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK__tbl_stud__2F3684F4ECD3D4A3");

                entity.ToTable("tbl_StudentDetails");

                entity.HasIndex(e => e.SId, "UQ__tbl_stud__2F3684F502480E2E")
                    .IsUnique();

                entity.Property(e => e.SId)
                    .ValueGeneratedNever()
                    .HasColumnName("s_id");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("date_of_joining");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.SAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("s_address");

                entity.Property(e => e.SAge).HasColumnName("s_age");

                entity.Property(e => e.SCourse)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("s_course");

                entity.Property(e => e.SFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("s_firstname");

                entity.Property(e => e.SGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("s_gender")
                    .IsFixedLength();

                entity.Property(e => e.SLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("s_lastname");

                entity.Property(e => e.SPhone).HasColumnName("s_phone");

                entity.Property(e => e.SNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");
            });

            modelBuilder.Entity<TblStudentMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_StudentMarks");

                entity.Property(e => e.SChemistryMarks).HasColumnName("s_chemistrymarks");

                entity.Property(e => e.SEnglishMarks).HasColumnName("s_englishmarks");

                entity.Property(e => e.SFeesPaid)
                    .HasColumnType("money")
                    .HasColumnName("s_feespaid");

                entity.Property(e => e.SMathsMarks).HasColumnName("s_mathsmarks");

                entity.Property(e => e.SPercentage).HasColumnName("s_percentage");

                entity.Property(e => e.SPhysicsMarks).HasColumnName("s_physicsmarks");

                entity.Property(e => e.SScienceMarks).HasColumnName("s_sciencemarks");

                entity.Property(e => e.STotalMarks).HasColumnName("s_totalmarks");

                entity.Property(e => e.SerialNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("serialno");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
