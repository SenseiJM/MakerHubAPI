using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class SouperConfig : IEntityTypeConfiguration<Souper> {
        public void Configure(EntityTypeBuilder<Souper> builder) {
            builder.ToTable("Souper");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID).ValueGeneratedOnAdd();

            builder.Property(s => s.Titre).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Date).IsRequired();
            builder.Property(s => s.IDType).IsRequired();
            builder.Property(s => s.PrixAffilies).IsRequired();
            builder.Property(s => s.PrixExternes).IsRequired();
            builder.Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(1500);

            builder.HasOne(s => s.TypeSouper).WithMany(ts => ts.Soupers).HasForeignKey(s => s.IDType);
        }
    }
}
