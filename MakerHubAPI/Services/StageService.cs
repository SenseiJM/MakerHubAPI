using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.Stage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class StageService {

        //private readonly CTTDBContext cTTDB;

        //public StageService(CTTDBContext cTTDB) {
        //    this.cTTDB = cTTDB;
        //}

        //public void Create(StageAddDTO dto) {
        //    cTTDB.Stages.Add(new DAL.Entities.Stage {
        //        DateDebut = dto.DateDebut,
        //        DateFin = dto.DateFin,
        //        HeureDebut = dto.HeureDebut,
        //        HeureFin = dto.HeureFin,
        //        PrixAffilies = dto.PrixAffilies,
        //        PrixExternes = dto.PrixExternes,
        //        Entraineur = dto.Entraineur,
        //        Description = dto.Description,
        //        Titre = dto.Titre,
        //        NombreMax = dto.NombreMax,
        //        ClassementMaximum = dto.ClassementMaximum,
        //        ClassementMinimum = dto.ClassementMinimum                
        //    });
        //    cTTDB.SaveChanges();
        //}

        //public StageDetailsDTO GetByID(int id) {
        //    Stage stage = cTTDB.Stages.Include(j => j.JoueurStages).ThenInclude(s => s.Joueur).FirstOrDefault(s => s.ID == id);

        //    return new StageDetailsDTO {
        //        DateDebut = stage.DateDebut,
        //        DateFin = stage.DateFin,
        //        Description = stage.Description,
        //        Entraineur = stage.Entraineur,
        //        HeureDebut = stage.HeureDebut,
        //        HeureFin = stage.HeureFin,
        //        IDClassementMaximum = stage.IDClassementMaximum,
        //        IDClassementMinimum = stage.IDClassementMinimum,
        //        NombreMax = stage.NombreMax,
        //        PrixAffilies = stage.PrixAffilies,
        //        PrixExternes = stage.PrixExternes,
        //        Joueurs = stage.JoueurStages.Select(j => new DTO.JoueurIndexDTO {
        //            ID = j.Joueur.ID,
        //            Nom = j.Joueur.Nom,
        //            Prenom = j.Joueur.Prenom,
        //            ClassementHommes = j.Joueur.ClassementHommes
        //        })
        //    };
        //}

        //public IEnumerable<StageIndexDTO> GetAll() {
        //    foreach (var stage in cTTDB.Stages) {
        //        yield return new StageIndexDTO {
        //            DateDebut = stage.DateDebut,
        //            DateFin = stage.DateFin,
        //            HeureDebut = stage.HeureDebut,
        //            HeureFin = stage.HeureFin,
        //            Titre = stage.Titre,
        //            ID = stage.ID
        //        };
        //    }
        //}

        //public void Update(StageDetailsDTO dto, int id) {
        //    Stage stage = cTTDB.Stages.FirstOrDefault(s => s.ID == id);

        //    stage.DateDebut = dto.DateDebut;
        //    stage.DateFin = dto.DateFin;
        //    stage.HeureDebut = dto.HeureDebut;
        //    stage.HeureFin = dto.HeureFin;
        //    stage.PrixAffilies = dto.PrixAffilies;
        //    stage.PrixExternes = dto.PrixExternes;
        //    stage.IDClassementMinimum = dto.IDClassementMinimum;
        //    stage.IDClassementMaximum = dto.IDClassementMaximum;
        //    stage.Entraineur = dto.Entraineur;
        //    stage.NombreMax = dto.NombreMax;
        //    stage.Description = dto.Description;

        //    cTTDB.SaveChanges();
        //}

        //public void Delete(int id) {
        //    cTTDB.Remove(cTTDB.Stages.FirstOrDefault(s => s.ID == id));
        //    cTTDB.SaveChanges();
        //}

    }
}
