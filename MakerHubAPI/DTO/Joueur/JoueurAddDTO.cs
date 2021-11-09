namespace MakerHubAPI.DTO.Joueur {
    public class JoueurAddDTO {

        public int IDAFTT { get; set; }

        //Email (plus tard)
        public string IdentifiantConnexion { get; set; }

        public string MotDePasse { get; set; }

        public int? IDEquipeHommes { get; set; }

        public int? IDEquipeDames { get; set; }

        public string? HeureDepartHommes { get; set; }

        public string? HeureDepartDames { get; set; }

    }
}
