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
    public partial class ListeEp : Form
    {
        public ListeEp()
        {
            InitializeComponent();
        }

        private void ListeEp_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.epargne'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.epargneTableAdapter.Fill(this.gestion_bankDataSet.epargne);

        }
    }
}
