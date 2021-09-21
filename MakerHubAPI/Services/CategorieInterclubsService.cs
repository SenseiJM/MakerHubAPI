using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.CategorieInterclubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class CategorieInterclubsService {

        private readonly CTTDBContext cTTDB;

        public CategorieInterclubsService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(CategorieInterclubsAddDTO dto) {
            cTTDB.CategoriesInterclubs.Add(new CategorieInterclubs {
                Genre = dto.Genre
            });
        }

        public CategorieInterclubsDetailsDTO GetByID(int id) {
            CategorieInterclubs catInt = cTTDB.CategoriesInterclubs.FirstOrDefault(ci => ci.ID == id);

            return new CategorieInterclubsDetailsDTO {
                Genre = catInt.Genre
            };
        }

        public IEnumerable<CategorieInterclubsDetailsDTO> GetAll() {
            foreach (var catInt in cTTDB.CategoriesInterclubs) {
                yield return new CategorieInterclubsDetailsDTO {
                    Genre = catInt.Genre
                };
            }
        }

        public void Update(CategorieInterclubsDetailsDTO dto, int id) {
            CategorieInterclubs catInt = cTTDB.CategoriesInterclubs.FirstOrDefault(ci => ci.ID == id);

            catInt.Genre = dto.Genre;

            cTTDB.SaveChanges();

        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.CategoriesInterclubs.FirstOrDefault(ci => ci.ID == id));
            cTTDB.SaveChanges();
        }
    }
}
