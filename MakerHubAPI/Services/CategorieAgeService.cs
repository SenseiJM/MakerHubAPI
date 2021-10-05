using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.CategorieAge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class CategorieAgeService {

        private readonly CTTDBContext cTTDB;

        public CategorieAgeService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(CategorieAgeAddDTO dto) {
            cTTDB.CategoriesAge.Add(new CategorieAge {
                Nom = dto.Nom,
                Genre = dto.Genre
            });
            cTTDB.SaveChanges();
        }

        public CategorieAgeDetailsDTO GetByID(int id) {
            CategorieAge catAge = cTTDB.CategoriesAge.FirstOrDefault(ca => ca.ID == id);

            return new CategorieAgeDetailsDTO {
                Nom = catAge.Nom,
                Genre = catAge.Genre
            };
        }

        public IEnumerable<CategorieAgeDetailsDTO> GetAll() {
            foreach (var catAge in cTTDB.CategoriesAge) {
                yield return new CategorieAgeDetailsDTO {
                    ID = catAge.ID,
                    Nom = catAge.Nom,
                    Genre = catAge.Genre
                };
            }
        }

        public IEnumerable<CategorieAgeDetailsDTO> GetAllByName(string search) {
            foreach (var catAge in cTTDB.CategoriesAge) {
                if (catAge.Nom == search) {
                    yield return new CategorieAgeDetailsDTO {
                        Nom = catAge.Nom,
                        Genre = catAge.Genre
                    };
                }
            }
        }

        public void Update(CategorieAgeDetailsDTO dto, int id) {
            CategorieAge catAge = cTTDB.CategoriesAge.FirstOrDefault(ca => ca.ID == id);

            catAge.Nom = dto.Nom;
            catAge.Genre = dto.Genre;

            cTTDB.SaveChanges();
        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.CategoriesAge.FirstOrDefault(ca => ca.ID == id));
            cTTDB.SaveChanges();
        }

    }
}
