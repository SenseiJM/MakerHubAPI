using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Configurations {
    public class JoueurStageConfig : IEntityTypeConfiguration<JoueurStage> {
        public void Configure(EntityTypeBuilder<JoueurStage> builder) {
            builder.ToTable("JoueurStage");

            builder.HasOne(jc => jc.Stage).WithMany(s => s.JoueurStages).HasForeignKey(jc => jc.IDStage);
            builder.HasOne(jc => jc.Joueur).WithMany(j => j.JoueurStages).HasForeignKey(jc => jc.IDJoueur);
        }
    }
}
