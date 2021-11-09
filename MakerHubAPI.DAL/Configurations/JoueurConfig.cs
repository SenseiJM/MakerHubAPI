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

            builder.Property(j => j.IDAFTT).IsRequired();
            builder.Property(j => j.IdentifiantConnexion).IsRequired();
            builder.Property(j => j.MotDePasse).IsRequired();
        }
    }
}
