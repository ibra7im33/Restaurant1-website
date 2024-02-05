using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restorent.Models
{
    public partial class Rest_2024Context : DbContext
    {
        public Rest_2024Context()
        {
        }

        public Rest_2024Context(DbContextOptions<Rest_2024Context> options)
            : base(options)
        {
        }

        public virtual DbSet<MasterCategoryMenu> MasterCategoryMenus { get; set; } = null!;
        public virtual DbSet<MasterContactUsInformation> MasterContactUsInformations { get; set; } = null!;
        public virtual DbSet<MasterItemMenu> MasterItemMenus { get; set; } = null!;
        public virtual DbSet<MasterMenu> MasterMenus { get; set; } = null!;
        public virtual DbSet<MasterOffer> MasterOffers { get; set; } = null!;
        public virtual DbSet<MasterPartner> MasterPartners { get; set; } = null!;
        public virtual DbSet<MasterService> MasterServices { get; set; } = null!;
        public virtual DbSet<MasterSlider> MasterSliders { get; set; } = null!;
        public virtual DbSet<MasterSocialMedium> MasterSocialMedia { get; set; } = null!;
        public virtual DbSet<MasterWorkingHour> MasterWorkingHours { get; set; } = null!;
        public virtual DbSet<SystemSetting> SystemSettings { get; set; } = null!;
        public virtual DbSet<TransactionBookTable> TransactionBookTables { get; set; } = null!;
        public virtual DbSet<TransactionContactU> TransactionContactUs { get; set; } = null!;
        public virtual DbSet<TransactionNewsletter> TransactionNewsletters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQL2019;Initial Catalog=Rest_2024;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MasterCategoryMenu>(entity =>
            {
                entity.ToTable("MasterCategoryMenu");

                entity.Property(e => e.MasterCategoryMenuId).ValueGeneratedNever();

                entity.Property(e => e.MasterCategoryMenuName).HasMaxLength(3000);
            });

            modelBuilder.Entity<MasterContactUsInformation>(entity =>
            {
                entity.ToTable("MasterContactUsInformation");

                entity.Property(e => e.MasterContactUsInformationId).ValueGeneratedNever();

                entity.Property(e => e.MasterContactUsInformationIdesc).HasColumnName("MasterContactUsInformationIDesc");
            });

            modelBuilder.Entity<MasterItemMenu>(entity =>
            {
                entity.ToTable("MasterItemMenu");

                entity.Property(e => e.MasterItemMenuId).ValueGeneratedNever();

                entity.Property(e => e.MasterItemMenuDate).HasColumnType("datetime");

                entity.Property(e => e.MasterItemMenuPrice).HasColumnType("money");

                entity.Property(e => e.MasterItemMenuTitle).HasMaxLength(3000);

                entity.HasOne(d => d.MasterCategoryMenu)
                    .WithMany(p => p.MasterItemMenus)
                    .HasForeignKey(d => d.MasterCategoryMenuId)
                    .HasConstraintName("FK_MasterItemMenu_MasterCategoryMenu");
            });

            modelBuilder.Entity<MasterMenu>(entity =>
            {
                entity.ToTable("MasterMenu");

                entity.Property(e => e.MasterMenuId).ValueGeneratedNever();

                entity.Property(e => e.MasterMenuName).HasMaxLength(1000);

                entity.Property(e => e.MasterMenuUrl).HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterOffer>(entity =>
            {
                entity.ToTable("MasterOffer");

                entity.Property(e => e.MasterOfferId).ValueGeneratedNever();
            });

            modelBuilder.Entity<MasterPartner>(entity =>
            {
                entity.ToTable("MasterPartner");

                entity.Property(e => e.MasterPartnerId).ValueGeneratedNever();

                entity.Property(e => e.MasterPartnerName).HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterService>(entity =>
            {
                entity.HasKey(e => e.MasterServicesId);

                entity.Property(e => e.MasterServicesId).ValueGeneratedNever();

                entity.Property(e => e.MasterServicesTitle).HasMaxLength(3000);
            });

            modelBuilder.Entity<MasterSlider>(entity =>
            {
                entity.ToTable("MasterSlider");

                entity.Property(e => e.MasterSliderId).ValueGeneratedNever();

                entity.Property(e => e.MasterSliderBreef).HasMaxLength(1000);

                entity.Property(e => e.MasterSliderDesc).HasMaxLength(1000);

                entity.Property(e => e.MasterSliderTitle).HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterSocialMedium>(entity =>
            {
                entity.HasKey(e => e.MasterSocialMediaId);

                entity.Property(e => e.MasterSocialMediaId).ValueGeneratedNever();
            });

            modelBuilder.Entity<MasterWorkingHour>(entity =>
            {
                entity.HasKey(e => e.MasterWorkingHoursId);

                entity.Property(e => e.MasterWorkingHoursId).ValueGeneratedNever();

                entity.Property(e => e.MasterWorkingHoursIdName).HasMaxLength(1000);

                entity.Property(e => e.MasterWorkingHoursIdTimeFormTo).HasMaxLength(3000);
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.ToTable("SystemSetting");

                entity.Property(e => e.SystemSettingId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransactionBookTable>(entity =>
            {
                entity.ToTable("TransactionBookTable");

                entity.Property(e => e.TransactionBookTableId).ValueGeneratedNever();

                entity.Property(e => e.TransactionBookTableDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionBookTableEmail).HasMaxLength(1000);

                entity.Property(e => e.TransactionBookTableFullName).HasMaxLength(1000);

                entity.Property(e => e.TransactionBookTableMobileNumber).HasMaxLength(1000);
            });

            modelBuilder.Entity<TransactionContactU>(entity =>
            {
                entity.HasKey(e => e.TransactionContactUsId);

                entity.Property(e => e.TransactionContactUsId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionContactUsID");

                entity.Property(e => e.TransactionContactUsEmail).HasMaxLength(1000);

                entity.Property(e => e.TransactionContactUsFullName).HasMaxLength(1000);

                entity.Property(e => e.TransactionContactUsSubject).HasMaxLength(1000);
            });

            modelBuilder.Entity<TransactionNewsletter>(entity =>
            {
                entity.ToTable("TransactionNewsletter");

                entity.Property(e => e.TransactionNewsletterId).ValueGeneratedNever();

                entity.Property(e => e.TransactionNewsletterEmail).HasMaxLength(1000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
