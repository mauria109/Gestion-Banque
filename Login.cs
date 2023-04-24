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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Create(object sender, EventArgs e)
        {
            if (Cni.Checked == true || Psp.Checked == true)
            {
                
                if (string.IsNullOrEmpty(Pseudo.Text))
                {
                    MessageBox.Show("Le champ pseudo/email est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(NumId.Text))
                {
                    MessageBox.Show("Le champ numéro est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(Pwd.Text))
                {
                    MessageBox.Show("Le champ mot de passe est obligatoire", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
