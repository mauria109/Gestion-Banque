using System.Data.Linq.Mapping;

namespace GestionBanqueApp.Model.Entities
{
    [Table]
    public class Client
    {
        private string text1;
        private string text2;
        private string text3;
        private int v1;
        private double v2;

        [Column(IsPrimaryKey = true)]
        public int Id{get;set;}
        
        [Column(Name = "num_carte")]
        public string NumCarte{get;set;}
        
        [Column(Name = "nom_cli")]
        public string Nom{get;set;}
        
        [Column(Name = "prenom_cli")]
        public string Prenom{get;set;}

        [Column(Name = "age_cli")]
        public int Age{get;set;}

        [Column(Name = "taille_cli")]
        public double Taille{get;set;}
        
        [Column(Name = "type_carte")]
        public string NomCarte{get;set;}

        public Client()
        {
        }

        public Client(int id, string nomCarte, string numCarte, string nom, string prenom, int age, double taille)
        {
            Id = id;
            NomCarte = nomCarte;
            NumCarte = numCarte;
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Taille = taille;
        }

        public Client(string text1, string text2, string text3, int v1, double v2)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}