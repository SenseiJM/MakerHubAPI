using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Stage {

        public int ID {  get; set; }
        public string Titre { get; set; }
        public DateTime DateDebut {  get; set; }
        public DateTime DateFin {  get; set; }
        public TimeSpan HeureDebut {  get; set; }
        public TimeSpan HeureFin {  get; set; }
        public double PrixAffilies {  get; set; }
        public double PrixExternes {  get; set; }
        public int IDClassementMinimum {  get; set; }
        public int IDClassementMaximum {  get; set; }
        public string Entraineur {  get; set; }
        public int? NombreMax {  get; set; }
        public string Description {  get; set; }
        public Classement ClassementMinimum { get; set; }
        public Classement ClassementMaximum { get; set; }
        public IEnumerable<JoueurStage> JoueurStages { get; set; }

    }
}
