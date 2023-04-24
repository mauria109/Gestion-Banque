using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionBankApp.View
{
    public partial class Add_Admin : Form
    {
        public Add_Admin()
        {
            InitializeComponent();
        }

        private void Add_Admin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.admin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adminTableAdapter.Fill(this.gestion_bankDataSet.admin);

        }

        private void Cni_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Psp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Create(object sender, EventArgs e)
        {
            if (Cni.Checked || Psp.Checked)
            {
                if (string.IsNullOrEmpty(Nom.Text))
                {
                    MessageBox.Show("Le champ nom est obligatoire", "Erreur de saisie", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Prenom.Text))
                {
                    MessageBox.Show("Le champ prenom est obligatoire", "Erreur de saisie", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Login.Text))
                {
                    MessageBox.Show("Le champ pseudo/email est obligatoire", "Erreur de saisie", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Num.Text))
                {
                    MessageBox.Show("Le champ numéro est obligatoire", "Erreur de saisie", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(Pwd.Text))
                {
                    MessageBox.Show("Le champ mot de passe est obligatoire", "Erreur de saisie", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var connection = DbUtils.GetSqlConnection();

                if (Cni.Checked == true)
                {

                    try
                    {

                        connection.Open();
                        //on crée un nouveau client et un nouveau compte
                        Console.WriteLine("etape1");
                        Admin admin = new Admin(Cni.Text, Num.Text, Nom.Text, Prenom.Text, Login.Text, Pwd.Text);
                        var sql =
                            "INSERT INTO admin (type_carte, num_carte, nom_adm, prenom_adm, login_adm, mdp_adm) VALUES (@type, @num, @nom, @prenom, @email, @pwd)";

                        var cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        // Créez un objet Paramètre.

                        var type = new MySqlParameter("@type", MySqlDbType.VarChar);
                        type.Value = Cni.Text;
                        cmd.Parameters.Add(type);

                        var num = new MySqlParameter("@num", MySqlDbType.VarChar);
                        num.Value = Num.Text;
                        cmd.Parameters.Add(num);

                        var nom = new MySqlParameter("@nom", MySqlDbType.VarChar);
                        nom.Value = Nom.Text;
                        cmd.Parameters.Add(nom);

                        var prenom = new MySqlParameter("@prenom", MySqlDbType.VarChar);
                        prenom.Value = Prenom.Text;
                        cmd.Parameters.Add(prenom);

                        var email = new MySqlParameter("@email", MySqlDbType.VarChar);
                        email.Value = Login.Text;
                        cmd.Parameters.Add(email);


                        var pwd = new MySqlParameter("@pwd", MySqlDbType.VarChar);
                        pwd.Value = Pwd.Text;
                        cmd.Parameters.Add(pwd);

                        // Exécutez la Commande (Utilisez pour supprimer, insérer, mettre à jour).
                        var rowCount = cmd.ExecuteNonQuery();

                        if (rowCount != 0)
                        {
                            MessageBox.Show("Le compte a été créé avec succès", "opération réussie",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Une erreur s\'est produite lors de la création d'un nouvel admin !!",
                                "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cni.Checked = true;
                            Nom.Text = "";
                            Prenom.Text = "";
                            Login.Text = "";
                            Pwd.Text = "";
                            Num.Text = "";

                        }
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Une erreur s\'est produite lors de la création du compte !! ", "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);
                        MessageBox.Show(ex.Message, "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(@"Impossible de se connecter à la base de données!!!");
                        Console.WriteLine(e);
                        throw;
                    }
                }
                else if (Psp.Checked)
                {
                    try
                    {
                        connection.Open();
                        //on crée un nouveau client et un nouveau compte
                        Console.WriteLine("etape1");
                        var admin = new Admin(Psp.Text, Num.Text, Nom.Text, Prenom.Text, Login.Text, Pwd.Text);


                        var sql =
                            "INSERT INTO admin (type_carte, num_carte, nom_adm, prenom_adm, login_adm, mdp_adm) VALUES (@type, @num, @nom, @prenom, @email, @pwd)";

                        var cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        // Créez un objet Paramètre.

                        var type = new MySqlParameter("@type", MySqlDbType.VarChar);
                        type.Value = Psp.Text;
                        cmd.Parameters.Add(type);

                        var num = new MySqlParameter("@num", MySqlDbType.VarChar);
                        num.Value = Num.Text;
                        cmd.Parameters.Add(num);

                        var nom = new MySqlParameter("@nom", MySqlDbType.VarChar);
                        nom.Value = Nom.Text;
                        cmd.Parameters.Add(nom);

                        var prenom = new MySqlParameter("@prenom", MySqlDbType.VarChar);
                        prenom.Value = Prenom.Text;
                        cmd.Parameters.Add(prenom);

                        var email = new MySqlParameter("@email", MySqlDbType.VarChar);
                        email.Value = Login.Text;
                        cmd.Parameters.Add(email);


                        var pwd = new MySqlParameter("@pwd", MySqlDbType.VarChar);
                        pwd.Value = Pwd.Text;
                        cmd.Parameters.Add(pwd);

                        // Exécutez la Commande (Utilisez pour supprimer, insérer, mettre à jour).
                        var rowCount = cmd.ExecuteNonQuery();
                        if (rowCount != 0)
                        {
                            MessageBox.Show("Le compte a été créé avec succès", "opération réussie",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Une erreur s\'est produite lors de la création d'un nouvel admin !!",
                                "Erreur de création", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Psp.Checked = true;
                            Nom.Text = "";
                            Prenom.Text = "";
                            Login.Text = "";
                            Pwd.Text = "";
                            Num.Text = "";

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
