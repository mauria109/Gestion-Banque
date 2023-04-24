using System;
using System.Data.Linq.Mapping;

namespace GestionBanqueApp.Model.Entities
{
    [Table]
    public class CompteCourant : Compte
    {
        private int v1;
        private string text1;
        private double v2;
        private string text2;
        private string text3;
        private string text4;
        private double v3;

        [Column(Name = "dec_aut")]
        public double DecouvertAutoriser { get; set; }
        public CompteCourant ( ) : base()
        {
            DecouvertAutoriser = DecouvertAutoriser;
        }
        

        public CompteCourant (int id, string label, double solde, DateTime date, string numCli, string num, string type, double decouvert ) : base ( id, label, solde, date, numCli, num,  type )
        {
            DecouvertAutoriser = decouvert;
        }

        public CompteCourant(int v1, string text1, double v2, string text2, string text3, string text4, double v3)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.v2 = v2;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.v3 = v3;
        }
    }
}