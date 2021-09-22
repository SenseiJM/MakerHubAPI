using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.Souper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class SouperService {

        private CTTDBContext cTTDB;

        public SouperService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(SouperAddDTO dto) {
            cTTDB.Soupers.Add(new DAL.Entities.Souper {
                Date = dto.Date,
                Description = dto.Description,
                IDType = dto.IDType,
                NombreMax = dto.NombreMax,
                Photo = dto.Photo,
                PrixAffilies = dto.PrixAffilies,
                PrixExternes = dto.PrixExternes,
                Titre = dto.Titre
            });
        }

        public SouperDetailsDTO GetByID(int id) {

            Souper souper = cTTDB.Soupers.FirstOrDefault(s => s.ID == id);

            return new SouperDetailsDTO {
                Date = souper.Date,
                IDType = souper.IDType,
                PrixAffilies = souper.PrixAffilies,
                PrixExternes = souper.PrixExternes,
                Description = souper.Description,
                Photo = souper.Photo,
                NombreMax = souper.NombreMax
            };

        }

        public IEnumerable<SouperIndexDTO> GetAll() {
            foreach (var souper in cTTDB.Soupers) {
                yield return new SouperIndexDTO {
                    Titre = souper.Titre,
                    Date = souper.Date,
                    Description = souper.Description,
                    Photo = souper.Photo
                };
            }
        }

        public void Update(SouperDetailsDTO dto, int id) {
            Souper souper = cTTDB.Soupers.FirstOrDefault(s => s.ID == id);

            souper.Date = dto.Date;
            souper.IDType = dto.IDType;
            souper.PrixAffilies = dto.PrixAffilies;
            souper.PrixExternes = dto.PrixExternes;
            souper.Description = dto.Description;
            souper.Photo = dto.Photo;
            souper.NombreMax = dto.NombreMax;
            souper.Titre = dto.Titre;

            cTTDB.SaveChanges();
        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.Soupers.FirstOrDefault(s => s.ID == id));
            cTTDB.SaveChanges();
        }
    }
}
