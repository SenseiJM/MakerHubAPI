using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class AnnonceConfig : IEntityTypeConfiguration<Annonce> {

        
        public void Configure(EntityTypeBuilder<Annonce> builder) {

            //Nommer la table
            builder.ToTable("Annonce");

            //Définir la Primary Key
            builder.HasKey(a => a.ID);

            //Spécifier que la colonne doit être auto-incrémentée
            builder.Property(a => a.ID).ValueGeneratedOnAdd();

            //Modifier les contraintes des colonnes de la table
            builder.Property(a => a.Titre)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(1500);

            //Ajouter une contrainte de validation

        }
    }
}
