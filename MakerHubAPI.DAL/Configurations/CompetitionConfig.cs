using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class CompetitionConfig : IEntityTypeConfiguration<Competition> {
        public void Configure(EntityTypeBuilder<Competition> builder) {
            //Nommer la table
            builder.ToTable("Competition");

            //Définir la Primary Key
            builder.HasKey(c => c.ID);

            //Spécifier que la colonne doit être auto-incrémentée
            builder.Property(c => c.ID).ValueGeneratedOnAdd();

            //Modifier les contraintes des colonnes de la table
            builder.Property(c => c.Nom)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(c => c.Date).IsRequired();
            builder.Property(c => c.Heure).IsRequired();
            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(1500);

            //Ajouter une contrainte de validation
            builder.HasOne(c => c.CategorieAge).WithMany(ca => ca.Competitions).HasForeignKey(c => c.IDCategorieAge).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(c => c.ClassementMinimum).WithMany(cm => cm.CompetitionsMin).HasForeignKey(c => c.IDClassementMinimum).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(c => c.ClassementMaximum).WithMany(cm => cm.CompetitionsMax).HasForeignKey(c => c.IDClassementMaximum).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
