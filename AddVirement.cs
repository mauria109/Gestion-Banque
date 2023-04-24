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
    public partial class AddVirement : Form
    {
        public AddVirement()
        {
            InitializeComponent();
        }

        private void afficherToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void AddVirement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.virement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.virementTableAdapter.Fill(this.gestion_bankDataSet.virement);

        }

        private void CreateVi(object sender, EventArgs e)
        {
            //Controle de validation de saisie pour les comptes courant et epargne
            if (CniExp.Checked == true || PspExp.Checked == true)
            {
                if (string.IsNullOrEmpty(NumIdExp.Text))
                {
                    MessageBox.Show("Le champ numéro est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(NumComExp.Text))
                {
                    MessageBox.Show("Le champ numéro de compte est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CoExp.Checked == false || EpExp.Checked == false)
                {
                    MessageBox.Show("Veuillez sélectionner le type de compte de l'expéditeur", "Informations insuffisantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CniDest.Checked == true || PspDest.Checked == true)
                {
                    if (string.IsNullOrEmpty(NumComDest.Text))
                    {
                        MessageBox.Show("Le champ numéro de compte est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(NumIdDest.Text))
                    {
                        MessageBox.Show("Le champ numéro est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (CoDest.Checked == false || EpDest.Checked == false)
                    {
                        MessageBox.Show("Veuillez sélectionner le type de compte du destinataire", "Informations insuffisantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (string.IsNullOrEmpty(LabelVi.Text))
                    {
                        MessageBox.Show("Le champ libellé est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(Montant.Text))
                    {
                        MessageBox.Show("Le champ montant Compte est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(DateVi.Text))
                    {
                        MessageBox.Show("Le champ date est obligatoire", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(Depot.Text))
                    {
                        MessageBox.Show("Veuillez sélectionner le type de virement", "Informations insuffisantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Retrait.Text))
                    {
                        MessageBox.Show("Veuillez sélectionner le type de virement", "Informations insuffisantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    try
                    {
                        if(Depot.Checked == true)
                        {
                            if(Oui.Checked == true)
                            {
                                //on crée un nouveau client et un nouveau compte
                            Console.WriteLine("etape1");
                            Virement vi = new Virement(LabelVi.Text, Depot.Text,NumComExp.Text,Montant.Text, DateVi.Text,NumComDest.Text, Oui.Text);
                            }

                            if(Non.Checked == true)
                            {
                                Console.WriteLine("etape1");
                            Virement vi = new Virement(LabelVi.Text, Depot.Text,NumComExp.Text,Montant.Text, DateVi.Text,NumComDest.Text, Non.Text);
                            }

                            
                            if (Virement.Count != 0)
                            {
                                MessageBox.Show("Le compte a été créé avec succès", "opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Une erreur s\'est produite lors de la création du compte !!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Depot.Checked = true;
                                LabelVi.Text = "";
                                NumComDest.Text = "";
                                NumComExp.Text = "";
                                NumIdDest.Text = "";
                                NumIdExp.Text = "";
                                Montant.Text = "";
                                DateVi.Text = "";
                                Oui.Text = "";
                            }

                        }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Une erreur s\'est produite lors de la création du compte !! ", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);
                        MessageBox.Show(ex.Message, "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else if(Retrait.Checked == true)
                        {
                          if(Oui.Checked == true)
                            {
                                //on crée un nouveau client et un nouveau compte
                            Console.WriteLine("etape1");
                            Virement vi = new Virement(LabelVi.Text, Retrait.Text,NumComExp.Text,Montant.Text, DateVi.Text,NumComDest.Text, Oui.Text);
                            }

                            if(Non.Checked == true)
                            {
                                Console.WriteLine("etape1");
                            Virement vi = new Virement(LabelVi.Text, Retrait.Text,NumComExp.Text,Montant.Text, DateVi.Text,NumComDest.Text, Non.Text);
                            }

                            
                            if (Virement.Count != 0)
                            {
                                MessageBox.Show("Le compte a été créé avec succès", "opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Une erreur s\'est produite lors de la création du compte !!", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Retrait.Checked = true;
                                LabelVi.Text = "";
                                NumComDest.Text = "";
                                NumComExp.Text = "";
                                NumIdDest.Text = "";
                                NumIdExp.Text = "";
                                Montant.Text = "";
                                DateVi.Text = "";
                                Oui.Text = "";
                            }

                        }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Une erreur s\'est produite lors de la création du compte !! ", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);
                        MessageBox.Show(ex.Message, "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }  
                }
            } 
        }
    }
}
