using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class CategorieAgeConfig : IEntityTypeConfiguration<CategorieAge> {
        public void Configure(EntityTypeBuilder<CategorieAge> builder) {
            //Nommer la table
            builder.ToTable("CategorieAge");

            //Définir la Primary Key
            builder.HasKey(ca => ca.ID);

            //Spécifier que la colonne doit être auto-incrémentée
            builder.Property(ca => ca.ID).ValueGeneratedOnAdd();

            //Modifier les contraintes des colonnes de la table
            builder.Property(ca => ca.Nom)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(ca => ca.Genre)
                .IsRequired()
                .HasMaxLength(6);

            //Ajouter une contrainte de validation
        }
    }
}
