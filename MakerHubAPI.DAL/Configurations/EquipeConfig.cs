using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class EquipeConfig : IEntityTypeConfiguration<Equipe> {
        public void Configure(EntityTypeBuilder<Equipe> builder) {
            builder.ToTable("Equipe");

            builder.HasKey(e => e.ID);

            builder.Property(e => e.ID).ValueGeneratedOnAdd();

            builder.Property(e => e.Nom)
                .IsRequired()
                .HasMaxLength(8);
            builder.Property(e => e.IDCategorieInterclubs).IsRequired();
            builder.Property(e => e.LieuMatch)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.HeureMatch).IsRequired();
            builder.Property(e => e.Division)
                .IsRequired()
                .HasMaxLength(7);

            builder.HasOne(e => e.CategorieInterclubs).WithMany(ci => ci.Equipes).HasForeignKey(e => e.IDCategorieInterclubs);
        }
    }
}
