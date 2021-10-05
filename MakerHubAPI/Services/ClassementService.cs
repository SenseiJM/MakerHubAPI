using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.Classement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class ClassementService {

        private readonly CTTDBContext cTTDB;

        public ClassementService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(ClassementAddDTO dto) {
            cTTDB.Classements.Add(new Classement {
                Denomination = dto.Denomination
            });
            cTTDB.SaveChanges();
        }

        public ClassementDetailsDTO GetByID(int id) {
            Classement classement = cTTDB.Classements.FirstOrDefault(c => c.ID == id);

            return new ClassementDetailsDTO {
                Denomination = classement.Denomination
            };
        }

        public IEnumerable<ClassementDetailsDTO> GetAll() {
            foreach (var classement in cTTDB.Classements) {
                yield return new ClassementDetailsDTO {
                    ID = classement.ID,
                    Denomination = classement.Denomination
                };
            }
        }

        public void Update(ClassementDetailsDTO dto, int id) {
            Classement classement = cTTDB.Classements.FirstOrDefault(c => c.ID == id);

            classement.Denomination = dto.Denomination;

            cTTDB.SaveChanges();
        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.Classements.FirstOrDefault(c => c.ID == id));
            cTTDB.SaveChanges();
        }
    }
}
