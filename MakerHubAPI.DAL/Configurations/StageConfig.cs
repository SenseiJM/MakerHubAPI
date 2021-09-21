using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class StageConfig : IEntityTypeConfiguration<Stage> {
        public void Configure(EntityTypeBuilder<Stage> builder) {
            builder.ToTable("Stage");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID).ValueGeneratedOnAdd();

            builder.Property(s => s.Titre).HasMaxLength(100).IsRequired();
            builder.Property(s => s.DateDebut).IsRequired();
            builder.Property(s => s.DateFin).IsRequired();
            builder.Property(s => s.HeureDebut).IsRequired();
            builder.Property(s => s.HeureFin).IsRequired();
            builder.Property(s => s.PrixAffilies).IsRequired();
            builder.Property(s => s.PrixExternes).IsRequired();
            builder.Property(s => s.IDClassementMinimum).IsRequired();
            builder.Property(s => s.IDClassementMaximum).IsRequired();
            builder.Property(s => s.Entraineur)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(1500);

            builder.HasOne(s => s.ClassementMinimum).WithMany(cm => cm.StagesMin).HasForeignKey(s => s.IDClassementMinimum).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(s => s.ClassementMaximum).WithMany(cm => cm.StagesMax).HasForeignKey(s => s.IDClassementMaximum).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
