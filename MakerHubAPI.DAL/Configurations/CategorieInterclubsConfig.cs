using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class CategorieInterclubsConfig : IEntityTypeConfiguration<CategorieInterclubs> {
        public void Configure(EntityTypeBuilder<CategorieInterclubs> builder) {
            //Nommer la table
            builder.ToTable("CategorieInterclubs");

            //Définir la Primary Key
            builder.HasKey(ci => ci.ID);

            //Spécifier que la colonne doit être auto-incrémentée
            builder.Property(ci => ci.ID).ValueGeneratedOnAdd();

            //Modifier les contraintes des colonnes de la table
            builder.Property(ci => ci.Genre)
                .IsRequired()
                .HasMaxLength(6);

            //Ajouter une contrainte de validation
        }
    }
}
