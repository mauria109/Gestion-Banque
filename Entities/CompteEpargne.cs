using System;
using System.Data.Linq.Mapping;

namespace GestionBanqueApp.Model.Entities
{
    [Table]
    public class CompteEpargne : Compte
    {
        private int v1;
        private string text1;
        private double v2;
        private string text2;
        private string text3;
        private double v3;
        private int v4;

        [Column(Name = "interet")]
        public double Interet { get; set; }

        [Column(Name = "plafond")]
        public double Plafond { get; set; }
        
        public CompteEpargne ()
        {
            Interet = 0;
            Plafond = 0;
        }
        
        public CompteEpargne ( double interet, double plafond )
        {
            Interet = interet;
            Plafond = plafond;
        }

        public CompteEpargne (int id, string label, double solde, DateTime date, string numCli, string num, string type, double interetD, double plafondD ) : base (id, label, solde, date, numCli, num,  type )
        {
            Interet = interetD;
            Plafond = plafondD;
        }

        public CompteEpargne(int v1, string text1, double v2, string text2, string text3, double v3, int v4)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.v2 = v2;
            this.text2 = text2;
            this.text3 = text3;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}