using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyApplication2.Models;

public partial class DemodbContext : DbContext
{
    public DemodbContext()
    {
    }

    public DemodbContext(DbContextOptions<DemodbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Announcement> Announcements { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-097O910;Database=demodb;uid=teacher;password=1234;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Announcement");

            entity.Property(e => e.AddAnnouncement)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DeleteAnnouncement)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.EditAnnouncement)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SeeAnnouncement)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShowAnnouncement)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
