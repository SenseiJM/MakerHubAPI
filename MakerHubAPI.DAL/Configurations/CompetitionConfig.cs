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

            builder.Property(c => c.ClassementMaximum).IsRequired().HasConversion<string>();
            builder.Property(c => c.ClassementMinimum).IsRequired().HasConversion<string>();
            builder.Property(c => c.CategorieAge).IsRequired().HasConversion<string>();
        }
    }
}
