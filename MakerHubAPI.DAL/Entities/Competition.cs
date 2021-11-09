using MakerHubAPI.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Competition {

        public int ID {  get; set; }
        public string Nom {  get; set; }
        public DateTime Date {  get; set; }
        public TimeSpan Heure {  get; set; }
        public byte[]? Photo {  get; set; }
        public string Description {  get; set; }
        public string? Lieu {  get; set; }
        public string? Lien {  get; set; }
        public int? NombreMax {  get; set; }
        public CategorieAge CategorieAge {  get; set; }
        public Classements ClassementMinimum { get; set; }
        public Classements ClassementMaximum { get; set; }
        public IEnumerable<JoueurCompetition> JoueurCompetitions { get; set; }

    }
}
