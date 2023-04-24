using System;
using System.Data.Linq.Mapping;

namespace GestionBanqueApp.Model.Entities
{
    [Table]
    public class Virement
    {
        [Column(IsPrimaryKey = true)]
        public int IdVirement{get;set;}

        [Column(Name = "label_vi")]
        public string LabelVirement{get;set;}

        [Column(Name = "id_com_em")]
        public string CompteEm{get;set;}

        [Column(Name = "type_vi")]
        public string Type{get;set;}

        [Column(Name = "montant_vi")]
        public double MontantVirement{get;set;}

        [Column(Name = "date_vi")]
        public DateTime DateVirement{get;set;}

        [Column(Name = "id_com_exp")]
        public string CompteExp{get;set;}
        
        [Column(Name = "statut_vi")]
        public string Result{get;set;}
        
        public Virement(){}
        
        public Virement(int idVirement, string labelVirement, string type,string CompteEm, double montantVirement, DateTime dateVirement, string CompteExp, string result)
        {
            IdVirement = idVirement;
            LabelVirement = labelVirement;
            Type = type;
            CompteEm = CompteEm;
            MontantVirement = montantVirement;
            DateVirement = dateVirement;
            CompteExp = CompteExp;
            Result = result;
        }
    }
}