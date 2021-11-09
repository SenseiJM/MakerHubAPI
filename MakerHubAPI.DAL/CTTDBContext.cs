using MakerHubAPI.DAL.Configurations;
using MakerHubAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL {
    public class CTTDBContext : DbContext {

        public DbSet<Annonce> Annonces {  get; set; }
        public DbSet<Competition> Competitions {  get; set; }
        public DbSet<Joueur> Joueurs {  get; set; }
        public DbSet<JoueurCompetition> JoueurCompetitions {  get; set; }
        public DbSet<JoueurStage> JoueurStages {  get; set;}
        public DbSet<Souper> Soupers {  get; set; }
        public DbSet<Stage> Stages {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //optionsBuilder.UseSqlServer("server=SENSEI-ALICE-V1\\TB2019;initial catalog=MakerHubCTTPhilippeville;integrated security=true;");
            optionsBuilder.UseSqlServer("server=SONIC-10;initial catalog=MakerHubCTTPhilippeville;uid=sa;pwd=formation");
            //optionsBuilder.UseSqlServer("server=K-LAPTOP;database=MakerHubCTTPhilippeville;integrated security = true;");
        }

        protected override void OnModelCreating(ModelBuilder mb) {
            mb.ApplyConfiguration(new AnnonceConfig());
            mb.ApplyConfiguration(new CompetitionConfig());
            mb.ApplyConfiguration(new JoueurConfig());
            mb.ApplyConfiguration(new JoueurCompetitionConfig());
            mb.ApplyConfiguration(new JoueurStageConfig());
            mb.ApplyConfiguration(new SouperConfig());
            mb.ApplyConfiguration(new StageConfig());
        }

    }
}
