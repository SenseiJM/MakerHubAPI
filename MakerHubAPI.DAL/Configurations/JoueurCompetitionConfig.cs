using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class JoueurCompetitionConfig : IEntityTypeConfiguration<JoueurCompetition> {
        public void Configure(EntityTypeBuilder<JoueurCompetition> builder) {
            builder.ToTable("JoueurCompetition");

            builder.HasKey(jc => new { jc.IDCompetition, jc.IDJoueur });

            builder.HasOne(jc => jc.Competition).WithMany(c => c.JoueurCompetitions).HasForeignKey(jc => jc.IDCompetition);
            builder.HasOne(jc => jc.Joueur).WithMany(j => j.JoueurCompetitions).HasForeignKey(jc => jc.IDJoueur);
        }
    }
}
