using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Enums {
    public enum CategorieAges {
        SeniorsHommes,
        SeniorsDames,
        Benjamins,
        Benjamines,
        Préminimes,
        PréminimesFilles,
        Minimes,
        MinimesFilles,
        Cadets,
        Cadettes,
        Juniors,
        Juniores,
        [Description("17-21")]
        Moins21,
        [Description("17-21Filles")]
        Moins21Filles,
        Vétérans40,
        Aînées40,
        Vétérans50,
        Aînées50,
        Vétérans60,
        Aînées60,
        Vétérans65,
        Aînées65,
        Vétérans70,
        Aînées70,
        Vétérans75,
        Aînées75,
        Vétérans80,
        Aînées80,
        Vétérans85,
        Aînées85
    }
}
