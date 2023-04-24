using System;
using System.Data.Linq.Mapping;

namespace GestionBanqueApp.Model.Entities
{
    [Table]
    public class Compte
    {
        [Column(IsPrimaryKey = true)]
        public int IdCompte { get; set; }

        [Column(Name = "label_com")]
        public string LabelCompte { get; set; }

        [Column(Name = "solde_com")]
        public double SoldeCompte { get; set; }

        [Column(Name = "ouverture_com")]
        public DateTime DateOuvertureCompte { get; set; }

        [Column(Name = "id_cli")]
        public string NumCli { get; set; }

        [Column(Name = "num_com")]
        public string NumCompte{get;set;}

        public string TypeCompte { get; set; }

        public Compte ()
        {
            IdCompte = 0;
            LabelCompte = "";
            SoldeCompte = 0.0;
            NumCli = "";
            NumCompte = NumCompte;
            DateOuvertureCompte = new DateTime ();
        }

        public Compte(int idCompte, string labelCompte, double soldeCompte, DateTime dateOuvertureCompte,string numCli, string numCompte, string typeCompte)
        {
            IdCompte = idCompte;
            LabelCompte = labelCompte;
            SoldeCompte = soldeCompte;
            NumCli = numCli;
            DateOuvertureCompte = dateOuvertureCompte;
            NumCompte = numCompte;
            TypeCompte = typeCompte;
        }
    }
}