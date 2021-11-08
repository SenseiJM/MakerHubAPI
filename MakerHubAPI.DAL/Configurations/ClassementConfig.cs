using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class ClassementConfig : IEntityTypeConfiguration<Classement2> {
        public void Configure(EntityTypeBuilder<Classement2> builder) {

            //Nommer la table
            builder.ToTable("Classement");

            //Définir la Primary Key
            builder.HasKey(c => c.ID);

            //Spécifier que la colonne doit être auto-incrémentée
            builder.Property(c => c.ID).ValueGeneratedOnAdd();

            //Modifier les contraintes des colonnes de la table
            builder.Property(c => c.Denomination)
                .IsRequired()
                .HasMaxLength(2);

            //Ajouter une contrainte de validation

        }
    }
}
