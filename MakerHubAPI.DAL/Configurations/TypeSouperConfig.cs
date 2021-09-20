using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class TypeSouperConfig : IEntityTypeConfiguration<TypeSouper> {
        public void Configure(EntityTypeBuilder<TypeSouper> builder) {
            //Nommer la table
            builder.ToTable("TypeSouper");

            //Définir la Primary Key
            builder.HasKey(ts => ts.ID);

            //Spécifier que la colonne doit être auto-incrémentée
            builder.Property(c => c.ID).ValueGeneratedOnAdd();

            //Modifier les contraintes des colonnes de la table
            builder.Property(ts => ts.Nom)
                .IsRequired()
                .HasMaxLength(10);

            //Ajouter une contrainte de validation
        }
    }
}
