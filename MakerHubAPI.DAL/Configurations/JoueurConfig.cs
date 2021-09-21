using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class JoueurConfig : IEntityTypeConfiguration<Joueur> {
        public void Configure(EntityTypeBuilder<Joueur> builder) {
            builder.ToTable("Joueur");

            builder.HasKey(j => j.ID);

            builder.Property(j => j.ID).ValueGeneratedOnAdd();

            builder.Property(j => j.Nom)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(j => j.Prenom)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(j => j.IDClassementHommes).IsRequired();
            builder.Property(j => j.IDCategorieAge).IsRequired();
            builder.Property(j => j.Genre)
                .IsRequired()
                .HasMaxLength(6);

            builder.HasOne(j => j.ClassementHommes).WithMany(c => c.JoueursHommes).HasForeignKey(j => j.IDClassementHommes);
            builder.HasOne(j => j.ClassementDames).WithMany(c => c.JoueursDames).HasForeignKey(j => j.IDClassementDames);
            builder.HasOne(j => j.CategorieAge).WithMany(ca => ca.Joueurs).HasForeignKey(j => j.IDCategorieAge);
            builder.HasOne(j => j.EquipeHommes).WithMany(e => e.JoueursHommes).HasForeignKey(j => j.IDEquipeHommes);
            builder.HasOne(j => j.EquipeDames).WithMany(e => e.JoueursDames).HasForeignKey(j => j.IDEquipeDames);
        }
    }
}
