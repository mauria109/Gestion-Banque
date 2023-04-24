using GestionBankApp.Model.Entities;
using GestionBanqueApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBankApp.View
{
    public partial class Add_Client : Form
    {
        public Add_Client()
        {
            InitializeComponent();
        }

        private void Add_Client_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.epargne'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.epargneTableAdapter.Fill(this.gestion_bankDataSet.epargne);
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.courant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.courantTableAdapter.Fill(this.gestion_bankDataSet.courant);
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.compte'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.compteTableAdapter.Fill(this.gestion_bankDataSet.compte);
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.gestion_bankDataSet.client);

        }


        private void Courant_CheckedChanged(object sender, EventArgs e)
        {
            Plafond.Enabled = false;
            Interet.Enabled = false;
            Decouvert.Enabled = true;
            Ouv.Value = DateTime.Today;
        }

        private void Epargne_CheckedChanged(object sender, EventArgs e)
        {
            Plafond.Enabled = true;
            Interet.Enabled = true;
            Decouvert.Enabled = false;
            Ouv.Value = DateTime.Today;
        }


        private void Create(object sender, EventArgs e)
        {
            if (Cni.Checked == true || Psp.Checked == true)
            {
                Ouv.Value = DateTime.Today;

                if (string.IsNullOrEmpty(Nom.Text))
                {
                    MessageBox.Show("Le champ nom est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Prenom.Text))
                {
                    MessageBox.Show("Le champ prenom est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Age.Text))
                {
                    MessageBox.Show("Le champ age est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Taille.Text))
                {
                    MessageBox.Show("Le champ taille est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(NumId.Text))
                {
                    MessageBox.Show("Le champ numéro est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(Courant.Checked == true || Epargne.Checked == true)
                {
                    if (string.IsNullOrEmpty(Label.Text))
                    {
                        MessageBox.Show("Le champ libellé est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Solde.Text))
                    {
                        MessageBox.Show("Le champ solde est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Ouv.Text))
                    {
                        MessageBox.Show("Le champ ouverture est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(NumCom.Text))
                    {
                        MessageBox.Show("Le champ Numéro de compte est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Decouvert.Text))
                    {
                        MessageBox.Show("Le champ Découvert est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Interet.Text))
                    {
                        MessageBox.Show("Le champ interet est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Plafond.Text))
                    {
                        MessageBox.Show("Le champ plafond est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    //Creation des objets comptes courant ou epargne

                    if (Courant.Checked) // si le compte est de type courant
                    {
                        if (string.IsNullOrEmpty(Decouvert.Text))
                        {
                            MessageBox.Show("Le champ decouvert est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        try
                        {
                            //on crée un nouveau client et un nouveau compte
                            Console.WriteLine("etape1");
                            Client client = new Client(NumId.Text, Nom.Text, Prenom.Text, int.Parse(Age.Text), double.Parse(Taille.Text));
                            Console.WriteLine("etape2");
                            CompteCourant compteCourants = new CompteCourant(int.Parse(NumId.Text), Label.Text, double.Parse(Solde.Text), Ouv.Text, 
                                NumId.Text, NumCom.Text, double.Parse(Decouvert.Text));
                            Console.WriteLine("etape3");

                            // compteCourant.obtenirInformationCompte();
                            CompteFormat.aClients.Add(client);
                            CompteFormat.aComptes.Add(compteCourants);
                            if (CompteFormat.aComptes.Count != 0)
                            {
                                MessageBox.Show("Le compte a été créé avec succès", "opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Une erreur s\'est produite lors de la création du compte !!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Courant.Checked = true;
                                Nom.Text = "";
                                Prenom.Text = "";
                                Taille.Text = "";
                                Age.Text = "";
                                NumCom.Text = "";
                                Label.Text = "";
                                Solde.Text = "";
                                Decouvert.Text = "";
                                NumId.Text = "";

                            }


                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show("Une erreur s\'est produite lors de la création du compte !! ", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex.StackTrace);
                            MessageBox.Show(ex.Message, "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }



                    }
                    if (Epargne.Checked)
                    {
                        try
                        {
                            Client lClient = new Client(NumId.Text, Nom.Text, Prenom.Text, int.Parse(Age.Text), double.Parse(Taille.Text));
                            CompteEpargne compteEpargne = new CompteEpargne(int.Parse(NumCom.Text), Label.Text, double.Parse(Solde.Text), Ouv.Text,
                                NumId.Text, double.Parse(Interet.Text), int.Parse(Plafond.Text));

                            CompteFormat.aClients.Add(lClient);
                            CompteFormat.aCompteEp.Add(compteEpargne);

                            if (CompteFormat.aCompteEp.Count != 0)
                            {
                                MessageBox.Show("Le compte a été créé avec succès", "opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Une erreur s\'est produite lors de la création du compte !!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Courant.Checked = true;
                                Nom.Text = "";
                                Prenom.Text = "";
                                Taille.Text = "";
                                Age.Text = "";
                                NumCom.Text = "";
                                Label.Text = "";
                                Solde.Text = "";
                                Plafond.Text = "";
                                Interet.Text = "";
                                NumId.Text = "";

                            }

                        }
                        catch
                        {
                            MessageBox.Show("une erreur s\'est produite lors de la création du compte !! ", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                }
            }
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
