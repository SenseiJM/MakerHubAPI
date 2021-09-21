using MakerHubAPI.DAL;
using MakerHubAPI.DAL.Entities;
using MakerHubAPI.DTO.Equipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class EquipeService {

        private readonly CTTDBContext cTTDB;

        public EquipeService(CTTDBContext cTTDB) {
            this.cTTDB = cTTDB;
        }

        public void Create(EquipeAddDTO dto) {
            cTTDB.Equipes.Add(new Equipe {
                Nom = dto.Nom,
                IDCategorieInterclubs = dto.IDCategorieInterclubs,
                LieuMatch = dto.LieuMatch,
                HeureDepart = dto.HeureDepart,
                HeureMatch = dto.HeureMatch,
                Division = dto.Division
            });
            cTTDB.SaveChanges();
        }

        public EquipeDetailsDTO GetByID(int id) {

            Equipe equipe = cTTDB.Equipes.FirstOrDefault(e => e.ID == id);

            return new EquipeDetailsDTO {
                Nom = equipe.Nom,
                IDCategorieInterclubs = equipe.IDCategorieInterclubs,
                LieuMatch = equipe.LieuMatch,
                HeureMatch = equipe.HeureMatch,
                HeureDepart = equipe.HeureDepart,
                Division = equipe.Division
            };

        }

        public IEnumerable<EquipeDetailsDTO> GetAllByName(string search) {
            foreach (var equipe in cTTDB.Equipes) {
                if (equipe.Nom == search) {
                    yield return new EquipeDetailsDTO {
                        Nom = equipe.Nom,
                        IDCategorieInterclubs = equipe.IDCategorieInterclubs,
                        LieuMatch = equipe.LieuMatch,
                        HeureMatch = equipe.HeureMatch,
                        HeureDepart = equipe.HeureDepart,
                        Division = equipe.Division
                    };
                }
            }
        }

        public IEnumerable<EquipeDetailsDTO> GetAll() {
            foreach (var equipe in cTTDB.Equipes) {
                yield return new EquipeDetailsDTO {
                    Nom = equipe.Nom,
                    IDCategorieInterclubs = equipe.IDCategorieInterclubs,
                    LieuMatch = equipe.LieuMatch,
                    HeureMatch = equipe.HeureMatch,
                    HeureDepart = equipe.HeureDepart,
                    Division = equipe.Division
                };
            }
        }

        public void Update(EquipeDetailsDTO dto, int id) {
            Equipe equipe = cTTDB.Equipes.FirstOrDefault(e => e.ID == id);

            equipe.Nom = dto.Nom;
            equipe.IDCategorieInterclubs = dto.IDCategorieInterclubs;
            equipe.LieuMatch = dto.LieuMatch;
            equipe.HeureMatch = dto.HeureMatch;
            equipe.HeureDepart = dto.HeureDepart;
            equipe.Division = dto.Division;

            cTTDB.SaveChanges();
        }

        public void Delete(int id) {
            cTTDB.Remove(cTTDB.Equipes.FirstOrDefault(e => e.ID == id));
            cTTDB.SaveChanges();
        }
    }
}
