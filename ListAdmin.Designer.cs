
namespace GestionBankApp.View
{
    partial class ListAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.généralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bank_appDataSet = new GestionBankApp.bank_appDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typecarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomadmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomadmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginadmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdpadmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_bankDataSet = new GestionBankApp.gestion_bankDataSet();
            this.adminTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.adminTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bank_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.généralToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem,
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesVirementsToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // généralToolStripMenuItem
            // 
            this.généralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem});
            this.généralToolStripMenuItem.Name = "généralToolStripMenuItem";
            this.généralToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.généralToolStripMenuItem.Text = "Général";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authentificationToolStripMenuItem,
            this.compteToolStripMenuItem});
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(155, 21);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // authentificationToolStripMenuItem
            // 
            this.authentificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem});
            this.authentificationToolStripMenuItem.Name = "authentificationToolStripMenuItem";
            this.authentificationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.authentificationToolStripMenuItem.Text = "Authentification";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.comptesToolStripMenuItem});
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.editerToolStripMenuItem1,
            this.supprimerToolStripMenuItem1,
            this.afficherToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // editerToolStripMenuItem1
            // 
            this.editerToolStripMenuItem1.Name = "editerToolStripMenuItem1";
            this.editerToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.editerToolStripMenuItem1.Text = "Editer";
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.editerToolStripMenuItem2,
            this.supprimerToolStripMenuItem2,
            this.afficherToolStripMenuItem1});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // editerToolStripMenuItem2
            // 
            this.editerToolStripMenuItem2.Name = "editerToolStripMenuItem2";
            this.editerToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.editerToolStripMenuItem2.Text = "Editer";
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.afficherToolStripMenuItem1.Text = "Afficher";
            // 
            // gestionDesVirementsToolStripMenuItem
            // 
            this.gestionDesVirementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.editerToolStripMenuItem3,
            this.afficherToolStripMenuItem2,
            this.supprimerToolStripMenuItem3});
            this.gestionDesVirementsToolStripMenuItem.Name = "gestionDesVirementsToolStripMenuItem";
            this.gestionDesVirementsToolStripMenuItem.Size = new System.Drawing.Size(149, 21);
            this.gestionDesVirementsToolStripMenuItem.Text = "Gestion des virements";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            // 
            // editerToolStripMenuItem3
            // 
            this.editerToolStripMenuItem3.Name = "editerToolStripMenuItem3";
            this.editerToolStripMenuItem3.Size = new System.Drawing.Size(137, 22);
            this.editerToolStripMenuItem3.Text = "Editer";
            // 
            // afficherToolStripMenuItem2
            // 
            this.afficherToolStripMenuItem2.Name = "afficherToolStripMenuItem2";
            this.afficherToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.afficherToolStripMenuItem2.Text = "Afficher";
            // 
            // supprimerToolStripMenuItem3
            // 
            this.supprimerToolStripMenuItem3.Name = "supprimerToolStripMenuItem3";
            this.supprimerToolStripMenuItem3.Size = new System.Drawing.Size(137, 22);
            this.supprimerToolStripMenuItem3.Text = "Supprimer";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // bank_appDataSet
            // 
            this.bank_appDataSet.DataSetName = "bank_appDataSet";
            this.bank_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typecarteDataGridViewTextBoxColumn,
            this.numcarteDataGridViewTextBoxColumn,
            this.nomadmDataGridViewTextBoxColumn,
            this.prenomadmDataGridViewTextBoxColumn,
            this.loginadmDataGridViewTextBoxColumn,
            this.mdpadmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // typecarteDataGridViewTextBoxColumn
            // 
            this.typecarteDataGridViewTextBoxColumn.DataPropertyName = "type_carte";
            this.typecarteDataGridViewTextBoxColumn.HeaderText = "Type identité";
            this.typecarteDataGridViewTextBoxColumn.Name = "typecarteDataGridViewTextBoxColumn";
            // 
            // numcarteDataGridViewTextBoxColumn
            // 
            this.numcarteDataGridViewTextBoxColumn.DataPropertyName = "num_carte";
            this.numcarteDataGridViewTextBoxColumn.HeaderText = "Numéro identité";
            this.numcarteDataGridViewTextBoxColumn.Name = "numcarteDataGridViewTextBoxColumn";
            // 
            // nomadmDataGridViewTextBoxColumn
            // 
            this.nomadmDataGridViewTextBoxColumn.DataPropertyName = "nom_adm";
            this.nomadmDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomadmDataGridViewTextBoxColumn.Name = "nomadmDataGridViewTextBoxColumn";
            // 
            // prenomadmDataGridViewTextBoxColumn
            // 
            this.prenomadmDataGridViewTextBoxColumn.DataPropertyName = "prenom_adm";
            this.prenomadmDataGridViewTextBoxColumn.HeaderText = "Prénoms";
            this.prenomadmDataGridViewTextBoxColumn.Name = "prenomadmDataGridViewTextBoxColumn";
            // 
            // loginadmDataGridViewTextBoxColumn
            // 
            this.loginadmDataGridViewTextBoxColumn.DataPropertyName = "login_adm";
            this.loginadmDataGridViewTextBoxColumn.HeaderText = "Pseudo/email";
            this.loginadmDataGridViewTextBoxColumn.Name = "loginadmDataGridViewTextBoxColumn";
            // 
            // mdpadmDataGridViewTextBoxColumn
            // 
            this.mdpadmDataGridViewTextBoxColumn.DataPropertyName = "mdp_adm";
            this.mdpadmDataGridViewTextBoxColumn.HeaderText = "Mot de passe";
            this.mdpadmDataGridViewTextBoxColumn.Name = "mdpadmDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.gestion_bankDataSet;
            // 
            // gestion_bankDataSet
            // 
            this.gestion_bankDataSet.DataSetName = "gestion_bankDataSet";
            this.gestion_bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // ListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListAdmin";
            this.Text = "ListAdmin";
            this.Load += new System.EventHandler(this.ListAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bank_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
        private bank_appDataSet bank_appDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private gestion_bankDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authentificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomadmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomadmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginadmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdpadmDataGridViewTextBoxColumn;
    }
}