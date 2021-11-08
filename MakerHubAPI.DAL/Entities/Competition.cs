using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Competition {

        public int ID {  get; set; }
        public int IDCategorieAge {  get; set; }
        public string Nom {  get; set; }
        public DateTime Date {  get; set; }
        public TimeSpan Heure {  get; set; }
        public byte[]? Photo {  get; set; }
        public string Description {  get; set; }
        public int IDClassementMinimum {  get; set; }
        public int IDClassementMaximum {  get; set; }
        public string? Lieu {  get; set; }
        public string? Lien {  get; set; }
        public int? NombreMax {  get; set; }
        public CategorieAge CategorieAge {  get; set; }
        public Classement2 ClassementMinimum { get; set; }
        public Classement2 ClassementMaximum { get; set; }
        public IEnumerable<JoueurCompetition> JoueurCompetitions { get; set; }

    }
}
