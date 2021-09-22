using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.Annonce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class AnnonceService {

        private readonly CTTDBContext cTTDB;

        public AnnonceService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(AnnonceAddDTO dto) {
            cTTDB.Annonces.Add(new Annonce {
                Titre = dto.Titre,
                Description = dto.Description,
                Photo = dto.Photo
            });

            cTTDB.SaveChanges();
        }

        public AnnonceDetailsDTO GetByID(int id) {
            Annonce annonce = cTTDB.Annonces.FirstOrDefault(a => a.ID == id);

            return new AnnonceDetailsDTO {
                Titre = annonce.Titre,
                Description = annonce.Description,
                Photo = annonce.Photo
            };
        }

        public IEnumerable<AnnonceDetailsDTO> GetAllByTitle(string search) {
            foreach (var annonce in cTTDB.Annonces) {
                if (annonce.Titre == search) {
                    yield return new AnnonceDetailsDTO {
                        Titre = annonce.Titre,
                        Description = annonce.Description,
                        Photo = annonce.Photo
                    };
                }
            }
        }

        public IEnumerable<AnnonceIndexDTO> GetAll() {
            foreach (var annonce in cTTDB.Annonces) {
                yield return new AnnonceIndexDTO {
                    Titre = annonce.Titre,
                    Photo = annonce.Photo
                };
            }
        }

        public void Update(AnnonceDetailsDTO dto, int id) {
            Annonce annonce = cTTDB.Annonces.FirstOrDefault(a => a.ID == id);

            annonce.Titre = dto.Titre;
            annonce.Photo = dto.Photo;
            annonce.Description = dto.Description;

            cTTDB.SaveChanges();
        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.Annonces.FirstOrDefault(a => a.ID == id));
            cTTDB.SaveChanges();
        }
    }
}
