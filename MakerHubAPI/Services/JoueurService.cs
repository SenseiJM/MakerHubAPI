using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class JoueurService {

        private readonly CTTDBContext cTTDB;

        public JoueurService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(JoueurAddDTO dto) {
            cTTDB.Joueurs.Add(new Joueur {
                Nom = dto.Nom,
                Prenom = dto.Prenom,
                IDClassementHommes = dto.IDClassementHommes,
                IDClassementDames = dto.IDClassementDames,
                IDCategorieAge = dto.IDCategorieAge,
                Genre = dto.Genre,
                IDEquipeHommes = dto.IDEquipeHommes,
                IDEquipeDames = dto.IDEquipeDames
            });
            cTTDB.SaveChanges();
        }

        public JoueurDetailsDTO GetByID(int id) {

            Joueur joueur = cTTDB.Joueurs.FirstOrDefault(j => j.ID == id);

            return new JoueurDetailsDTO {
                Nom = joueur.Nom,
                Prenom = joueur.Prenom,
                IDClassementHommes = joueur.IDClassementHommes,
                IDClassementDames = joueur.IDClassementDames,
                IDCategorieAge = joueur.IDCategorieAge,
                Genre = joueur.Genre,
                IDEquipeHommes = joueur.IDEquipeHommes,
                IDEquipeDames = joueur.IDEquipeDames
            };

        }

        public IEnumerable<JoueurIndexDTO> GetAll() {

            foreach (var joueur in cTTDB.Joueurs) {
                yield return new JoueurIndexDTO {
                    Nom = joueur.Nom,
                    Prenom = joueur.Prenom,
                    IDClassementHommes = joueur.IDClassementHommes
                };
            }

        }

        public IEnumerable<JoueurIndexDTO> GetAllByName(string search) {
            foreach (var joueur in cTTDB.Joueurs) {
                if (joueur.Nom == search || joueur.Prenom == search) {
                    yield return new JoueurIndexDTO {
                        Nom = joueur.Nom,
                        Prenom = joueur.Prenom,
                        IDClassementHommes = joueur.IDClassementHommes
                    };
                }
            }
        }

        public void Update(JoueurDetailsDTO dto, int id) {
            Joueur joueur = cTTDB.Joueurs.FirstOrDefault(j => j.ID == id);

            joueur.Nom = dto.Nom;
            joueur.Prenom = dto.Prenom;
            joueur.IDClassementHommes = dto.IDClassementHommes;
            joueur.IDClassementDames = dto.IDClassementDames;
            joueur.IDCategorieAge = dto.IDCategorieAge;
            joueur.Genre = dto.Genre;
            joueur.IDEquipeHommes = dto.IDEquipeHommes;
            joueur.IDEquipeDames = dto.IDEquipeDames;

            cTTDB.SaveChanges();

        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.Joueurs.FirstOrDefault(j => j.ID == id));
            cTTDB.SaveChanges();
        }
    }
}
