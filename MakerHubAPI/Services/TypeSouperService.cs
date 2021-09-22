using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.TypeSouper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class TypeSouperService {

        private readonly CTTDBContext cTTDB;

        public TypeSouperService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(TypeSouperAddDTO dto) {
            cTTDB.TypesSoupers.Add(new DAL.Entities.TypeSouper {
                Nom = dto.Nom
            });

            cTTDB.SaveChanges();
        }

        public TypeSouperDetailsDTO GetByID(int id) {
            TypeSouper typeSouper = cTTDB.TypesSoupers.FirstOrDefault(ts => ts.ID == id);

            return new TypeSouperDetailsDTO {
                Nom = typeSouper.Nom
            };
        }

        public IEnumerable<TypeSouperDetailsDTO> GetAll() {
            foreach (var typeSouper in cTTDB.TypesSoupers) {
                yield return new TypeSouperDetailsDTO {
                    Nom = typeSouper.Nom
                };
            }
        }

        public void Update(TypeSouperDetailsDTO dto, int id) {
            TypeSouper typeSouper = cTTDB.TypesSoupers.FirstOrDefault(ts => ts.ID == id);

            typeSouper.Nom = dto.Nom;

            cTTDB.SaveChanges();
        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.TypesSoupers.FirstOrDefault(ts => ts.ID == id));
            cTTDB.SaveChanges();
        }

    }
}
