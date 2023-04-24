using System.Data.Linq.Mapping;

namespace GestionBanqueApp.Model.Entities
{
    [Table]
    public class Admin
    {
        [Column(IsPrimaryKey = true)]
        public int Id{get;set;}

        [Column(Name = "num_carte")]
        public string NumCarte{get;set;}
        
        [Column(Name = "type_carte")]
        public string NomCarte{get;set;}
        
        [Column(Name = "nom_adm")]
        public string Nom{get;set;}
        
        [Column(Name = "prenom_adm")]
        public string Prenom{get;set;}
        
        [Column(Name = "login_adm")]
        public string Email{get;set;}
        
        [Column(Name = "mdp_adm")]
        public string Pwd{get;set;}

        public Admin()
        {}


        public Admin(int id, string nomCarte, string numCarte,string nom, string prenom, string email, string pwd)
        {
            Id = id;
            NomCarte = nomCarte;
            NumCarte = numCarte;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Pwd = pwd;
        }
    }
}