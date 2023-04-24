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
    public partial class ListAdmin : Form
    {
        public ListAdmin()
        {
            InitializeComponent();
        }

        private void ListAdmin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_bankDataSet.admin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adminTableAdapter.Fill(this.gestion_bankDataSet.admin);

        }
    }
}
