using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Souper {

        public int ID {  get; set; }
        public DateTime Date {  get; set; }
        public int IDType {  get; set; }
        public double PrixAffilies {  get; set; }
        public double PrixExternes {  get; set; }
        public string Description {  get; set; }
        public byte[]? Photo {  get; set; }
        public int? NombreMax { get; set; }
        public TypeSouper TypeSouper { get; set; }
        public string Titre { get; set; }

    }
}
