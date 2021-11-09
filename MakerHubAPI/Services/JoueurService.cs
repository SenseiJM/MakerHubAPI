using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO;
using MakerHubAPI.DTO.Joueur;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MakerHubAPI.Services {
    public class JoueurService {

        private readonly CTTDBContext cTTDB;
        private readonly ClubService clubService;

        public JoueurService(CTTDBContext cTTDB, ClubService cService) {
            this.cTTDB = cTTDB;
            this.clubService = cService;
        }

        public void Create(JoueurAddDTO dto) {
            //Injecter les services et vérifier les données récupérées dans dto
            //Si les données ne correspondent pas, envoyer une exception
            cTTDB.Joueurs.Add(new Joueur {
                IDAFTT = dto.IDAFTT,
                IdentifiantConnexion = dto.IdentifiantConnexion,
                MotDePasse = dto.MotDePasse,
                IDEquipeHommes = dto.IDEquipeHommes,
                IDEquipeDames = dto.IDEquipeDames,
                HeureDepartHommes = dto.HeureDepartHommes,
                HeureDepartDames = dto.HeureDepartDames
            });
            cTTDB.SaveChanges();
            //Ajouter contraintes
        }

        //public JoueurDetailsDTO GetByID(int id) {

        //    Joueur joueur = cTTDB.Joueurs.Include(j => j.ClassementHommes).Include(j=> j.ClassementDames).FirstOrDefault(j => j.ID == id);

        //    //jointure entre les joueurs et les autres tables de la DB

        //    return new JoueurDetailsDTO {
        //        ID = joueur.ID,
        //        Nom = joueur.Nom,
        //        Prenom = joueur.Prenom,
        //        IDClassementHommes = joueur.IDClassementHommes,
        //        ClassementHommes = joueur.ClassementHommes,
        //        IDClassementDames = joueur.IDClassementDames,
        //        ClassementDames = joueur.ClassementDames,
        //        IDCategorieAge = joueur.IDCategorieAge,
        //        Genre = joueur.Genre,
        //        IDEquipeHommes = joueur.IDEquipeHommes,
        //        IDEquipeDames = joueur.IDEquipeDames
        //    };

        //}

        public IEnumerable<JoueurIndexDTO> GetAll() {

            return cTTDB.Joueurs.ToList().Join(clubService.GetMembers(22), j => j.IDAFTT, m => m.UniqueIndex, (j, m) => new JoueurIndexDTO{
                ID = j.ID,
                IDAFTT = j.IDAFTT,
                Nom = m.LastName,
                Prenom = m.FirstName,
                ClassementHommes = m.Ranking
            });

            #region OLD VERSION

            //// OLD VERSION (explicit loading / eager loading)
            ////foreach (var joueur in cTTDB.Joueurs.Include(joueur => joueur.ClassementHommes)) {
            ////    yield return new JoueurIndexDTO {
            ////        Nom = joueur.Nom,
            ////        Prenom = joueur.Prenom,
            ////        IDClassementHommes = joueur.IDClassementHommes,
            ////        ClassementHommes = joueur.ClassementHommes?.Denomination
            ////    };
            ////}

            ////lazy loading
            //return cTTDB.Joueurs.Select(joueur => new JoueurIndexDTO {
            //    ID = joueur.ID,
            //    Nom = joueur.Nom,
            //    Prenom = joueur.Prenom,
            //    IDClassementHommes = joueur.IDClassementHommes,
            //    ClassementHommes = joueur.ClassementHommes,
            //    IDClassementDames = joueur.IDClassementDames,
            //    ClassementDames = joueur.ClassementDames
            //});
            #endregion


        }

        //public void Update(JoueurDetailsDTO dto, int id) {
        //    Joueur joueur = cTTDB.Joueurs.FirstOrDefault(j => j.ID == id);

        //    joueur.Nom = dto.Nom;
        //    joueur.Prenom = dto.Prenom;
        //    joueur.IDClassementHommes = dto.IDClassementHommes;
        //    joueur.IDClassementDames = dto.IDClassementDames;
        //    joueur.IDCategorieAge = dto.IDCategorieAge;
        //    joueur.Genre = dto.Genre;
        //    joueur.IDEquipeHommes = dto.IDEquipeHommes;
        //    joueur.IDEquipeDames = dto.IDEquipeDames;

        //    cTTDB.SaveChanges();

        //}

        //public void Delete(int id) {
        //    cTTDB.Remove(cTTDB.Joueurs.FirstOrDefault(j => j.ID == id));
        //    cTTDB.SaveChanges();
        //}
    }
}
