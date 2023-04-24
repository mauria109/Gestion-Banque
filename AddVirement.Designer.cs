
namespace GestionBankApp.View
{
    partial class AddVirement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelVi = new System.Windows.Forms.TextBox();
            this.Depot = new System.Windows.Forms.RadioButton();
            this.Retrait = new System.Windows.Forms.RadioButton();
            this.Montant = new System.Windows.Forms.TextBox();
            this.Oui = new System.Windows.Forms.RadioButton();
            this.Non = new System.Windows.Forms.RadioButton();
            this.DateVi = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CoExp = new System.Windows.Forms.RadioButton();
            this.EpExp = new System.Windows.Forms.RadioButton();
            this.CoDest = new System.Windows.Forms.RadioButton();
            this.EpDest = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NumComExp = new System.Windows.Forms.TextBox();
            this.NumComDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumIdExp = new System.Windows.Forms.TextBox();
            this.NumIdDest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CniDest = new System.Windows.Forms.RadioButton();
            this.PspDest = new System.Windows.Forms.RadioButton();
            this.CniExp = new System.Windows.Forms.RadioButton();
            this.PspExp = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.généralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.epargneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Submit = new System.Windows.Forms.Button();
            this.gestion_bankDataSet = new GestionBankApp.gestion_bankDataSet();
            this.virementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virementTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.virementTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PspExp);
            this.groupBox1.Controls.Add(this.CniExp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NumIdExp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NumComExp);
            this.groupBox1.Controls.Add(this.EpExp);
            this.groupBox1.Controls.Add(this.CoExp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos expéditeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type compte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateVi);
            this.groupBox2.Controls.Add(this.Non);
            this.groupBox2.Controls.Add(this.Oui);
            this.groupBox2.Controls.Add(this.Montant);
            this.groupBox2.Controls.Add(this.Retrait);
            this.groupBox2.Controls.Add(this.Depot);
            this.groupBox2.Controls.Add(this.LabelVi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(445, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infos virement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "libellé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Montant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Statut";
            // 
            // LabelVi
            // 
            this.LabelVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "label_vi", true));
            this.LabelVi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "label_vi", true));
            this.LabelVi.Location = new System.Drawing.Point(98, 81);
            this.LabelVi.Name = "LabelVi";
            this.LabelVi.Size = new System.Drawing.Size(222, 24);
            this.LabelVi.TabIndex = 5;
            // 
            // Depot
            // 
            this.Depot.AutoSize = true;
            this.Depot.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.virementBindingSource, "type_vi", true));
            this.Depot.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "type_vi", true));
            this.Depot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "type_vi", true));
            this.Depot.Location = new System.Drawing.Point(98, 26);
            this.Depot.Name = "Depot";
            this.Depot.Size = new System.Drawing.Size(66, 22);
            this.Depot.TabIndex = 6;
            this.Depot.TabStop = true;
            this.Depot.Text = "Dépôt";
            this.Depot.UseVisualStyleBackColor = true;
            // 
            // Retrait
            // 
            this.Retrait.AutoSize = true;
            this.Retrait.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.virementBindingSource, "type_vi", true));
            this.Retrait.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "type_vi", true));
            this.Retrait.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "type_vi", true));
            this.Retrait.Location = new System.Drawing.Point(251, 24);
            this.Retrait.Name = "Retrait";
            this.Retrait.Size = new System.Drawing.Size(69, 22);
            this.Retrait.TabIndex = 7;
            this.Retrait.TabStop = true;
            this.Retrait.Text = "Retrait";
            this.Retrait.UseVisualStyleBackColor = true;
            // 
            // Montant
            // 
            this.Montant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "montant_vi", true));
            this.Montant.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "montant_vi", true));
            this.Montant.Location = new System.Drawing.Point(98, 143);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(222, 24);
            this.Montant.TabIndex = 8;
            // 
            // Oui
            // 
            this.Oui.AutoSize = true;
            this.Oui.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.virementBindingSource, "statut_vi", true));
            this.Oui.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "statut_vi", true));
            this.Oui.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "statut_vi", true));
            this.Oui.Location = new System.Drawing.Point(98, 249);
            this.Oui.Name = "Oui";
            this.Oui.Size = new System.Drawing.Size(76, 22);
            this.Oui.TabIndex = 9;
            this.Oui.TabStop = true;
            this.Oui.Text = "Succès";
            this.Oui.UseVisualStyleBackColor = true;
            // 
            // Non
            // 
            this.Non.AutoSize = true;
            this.Non.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.virementBindingSource, "statut_vi", true));
            this.Non.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "statut_vi", true));
            this.Non.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "statut_vi", true));
            this.Non.Location = new System.Drawing.Point(252, 249);
            this.Non.Name = "Non";
            this.Non.Size = new System.Drawing.Size(68, 22);
            this.Non.TabIndex = 10;
            this.Non.TabStop = true;
            this.Non.Text = "Echec";
            this.Non.UseVisualStyleBackColor = true;
            // 
            // DateVi
            // 
            this.DateVi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.virementBindingSource, "date_vi", true));
            this.DateVi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.virementBindingSource, "date_vi", true));
            this.DateVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.virementBindingSource, "date_vi", true));
            this.DateVi.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.virementBindingSource, "date_vi", true));
            this.DateVi.Location = new System.Drawing.Point(98, 198);
            this.DateVi.Name = "DateVi";
            this.DateVi.Size = new System.Drawing.Size(222, 24);
            this.DateVi.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PspDest);
            this.groupBox3.Controls.Add(this.CniDest);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.NumIdDest);
            this.groupBox3.Controls.Add(this.NumComDest);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.EpDest);
            this.groupBox3.Controls.Add(this.CoDest);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infos destinataire";
            // 
            // CoExp
            // 
            this.CoExp.AutoSize = true;
            this.CoExp.Checked = true;
            this.CoExp.Location = new System.Drawing.Point(146, 143);
            this.CoExp.Name = "CoExp";
            this.CoExp.Size = new System.Drawing.Size(79, 22);
            this.CoExp.TabIndex = 3;
            this.CoExp.TabStop = true;
            this.CoExp.Text = "Courant";
            this.CoExp.UseVisualStyleBackColor = true;
            // 
            // EpExp
            // 
            this.EpExp.AutoSize = true;
            this.EpExp.Location = new System.Drawing.Point(303, 141);
            this.EpExp.Name = "EpExp";
            this.EpExp.Size = new System.Drawing.Size(81, 22);
            this.EpExp.TabIndex = 4;
            this.EpExp.Text = "Epargne";
            this.EpExp.UseVisualStyleBackColor = true;
            // 
            // CoDest
            // 
            this.CoDest.AutoSize = true;
            this.CoDest.Checked = true;
            this.CoDest.Location = new System.Drawing.Point(146, 136);
            this.CoDest.Name = "CoDest";
            this.CoDest.Size = new System.Drawing.Size(79, 22);
            this.CoDest.TabIndex = 0;
            this.CoDest.TabStop = true;
            this.CoDest.Text = "Courant";
            this.CoDest.UseVisualStyleBackColor = true;
            // 
            // EpDest
            // 
            this.EpDest.AutoSize = true;
            this.EpDest.Location = new System.Drawing.Point(303, 136);
            this.EpDest.Name = "EpDest";
            this.EpDest.Size = new System.Drawing.Size(81, 22);
            this.EpDest.TabIndex = 1;
            this.EpDest.Text = "Epargne";
            this.EpDest.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Numéro compte";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Type compte";
            // 
            // NumComExp
            // 
            this.NumComExp.Location = new System.Drawing.Point(146, 101);
            this.NumComExp.Name = "NumComExp";
            this.NumComExp.Size = new System.Drawing.Size(263, 24);
            this.NumComExp.TabIndex = 5;
            // 
            // NumComDest
            // 
            this.NumComDest.Location = new System.Drawing.Point(146, 91);
            this.NumComDest.Name = "NumComDest";
            this.NumComDest.Size = new System.Drawing.Size(263, 24);
            this.NumComDest.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type Identité";
            // 
            // NumIdExp
            // 
            this.NumIdExp.Location = new System.Drawing.Point(146, 60);
            this.NumIdExp.Name = "NumIdExp";
            this.NumIdExp.Size = new System.Drawing.Size(263, 24);
            this.NumIdExp.TabIndex = 7;
            // 
            // NumIdDest
            // 
            this.NumIdDest.Location = new System.Drawing.Point(146, 55);
            this.NumIdDest.Name = "NumIdDest";
            this.NumIdDest.Size = new System.Drawing.Size(263, 24);
            this.NumIdDest.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Numéro Identité";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Type identité";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Numéro Identité";
            // 
            // CniDest
            // 
            this.CniDest.AutoSize = true;
            this.CniDest.Location = new System.Drawing.Point(146, 23);
            this.CniDest.Name = "CniDest";
            this.CniDest.Size = new System.Drawing.Size(51, 22);
            this.CniDest.TabIndex = 8;
            this.CniDest.Text = "CNI";
            this.CniDest.UseVisualStyleBackColor = true;
            // 
            // PspDest
            // 
            this.PspDest.AutoSize = true;
            this.PspDest.Location = new System.Drawing.Point(303, 26);
            this.PspDest.Name = "PspDest";
            this.PspDest.Size = new System.Drawing.Size(94, 22);
            this.PspDest.TabIndex = 9;
            this.PspDest.Text = "Passeport";
            this.PspDest.UseVisualStyleBackColor = true;
            // 
            // CniExp
            // 
            this.CniExp.AutoSize = true;
            this.CniExp.Location = new System.Drawing.Point(146, 24);
            this.CniExp.Name = "CniExp";
            this.CniExp.Size = new System.Drawing.Size(51, 22);
            this.CniExp.TabIndex = 9;
            this.CniExp.Text = "CNI";
            this.CniExp.UseVisualStyleBackColor = true;
            // 
            // PspExp
            // 
            this.PspExp.AutoSize = true;
            this.PspExp.Location = new System.Drawing.Point(303, 24);
            this.PspExp.Name = "PspExp";
            this.PspExp.Size = new System.Drawing.Size(94, 22);
            this.PspExp.TabIndex = 10;
            this.PspExp.Text = "Passeport";
            this.PspExp.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.généralToolStripMenuItem,
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesVirementsToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.monCompteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
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
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accueilToolStripMenuItem.Text = "Accueil";
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
            // gestionDesVirementsToolStripMenuItem
            // 
            this.gestionDesVirementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.gestionDesVirementsToolStripMenuItem.Name = "gestionDesVirementsToolStripMenuItem";
            this.gestionDesVirementsToolStripMenuItem.Size = new System.Drawing.Size(149, 21);
            this.gestionDesVirementsToolStripMenuItem.Text = "Gestion des virements";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
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
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.afficherToolStripMenuItem1,
            this.editerToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courantToolStripMenuItem,
            this.epargneToolStripMenuItem,
            this.afficherToolStripMenuItem4});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem1.Text = "Afficher";
            // 
            // editerToolStripMenuItem1
            // 
            this.editerToolStripMenuItem1.Name = "editerToolStripMenuItem1";
            this.editerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editerToolStripMenuItem1.Text = "Editer";
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // courantToolStripMenuItem
            // 
            this.courantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem2});
            this.courantToolStripMenuItem.Name = "courantToolStripMenuItem";
            this.courantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courantToolStripMenuItem.Text = "Courant";
            // 
            // afficherToolStripMenuItem2
            // 
            this.afficherToolStripMenuItem2.Name = "afficherToolStripMenuItem2";
            this.afficherToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem2.Text = "Afficher";
            // 
            // epargneToolStripMenuItem
            // 
            this.epargneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem3});
            this.epargneToolStripMenuItem.Name = "epargneToolStripMenuItem";
            this.epargneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.epargneToolStripMenuItem.Text = "Epargne";
            // 
            // afficherToolStripMenuItem3
            // 
            this.afficherToolStripMenuItem3.Name = "afficherToolStripMenuItem3";
            this.afficherToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem3.Text = "Afficher";
            // 
            // afficherToolStripMenuItem4
            // 
            this.afficherToolStripMenuItem4.Name = "afficherToolStripMenuItem4";
            this.afficherToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem4.Text = "Afficher";
            // 
            // monCompteToolStripMenuItem
            // 
            this.monCompteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem5,
            this.editerToolStripMenuItem2,
            this.afficherToolStripMenuItem6,
            this.supprimerToolStripMenuItem2});
            this.monCompteToolStripMenuItem.Name = "monCompteToolStripMenuItem";
            this.monCompteToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.monCompteToolStripMenuItem.Text = "Mon compte";
            // 
            // afficherToolStripMenuItem5
            // 
            this.afficherToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem});
            this.afficherToolStripMenuItem5.Name = "afficherToolStripMenuItem5";
            this.afficherToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem5.Text = "Authentification";
            this.afficherToolStripMenuItem5.Click += new System.EventHandler(this.afficherToolStripMenuItem5_Click);
            // 
            // editerToolStripMenuItem2
            // 
            this.editerToolStripMenuItem2.Name = "editerToolStripMenuItem2";
            this.editerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.editerToolStripMenuItem2.Text = "Editer";
            // 
            // afficherToolStripMenuItem6
            // 
            this.afficherToolStripMenuItem6.Name = "afficherToolStripMenuItem6";
            this.afficherToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem6.Text = "Afficher";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(144, 405);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(502, 36);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Valider";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.CreateVi);
            // 
            // gestion_bankDataSet
            // 
            this.gestion_bankDataSet.DataSetName = "gestion_bankDataSet";
            this.gestion_bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virementBindingSource
            // 
            this.virementBindingSource.DataMember = "virement";
            this.virementBindingSource.DataSource = this.gestion_bankDataSet;
            // 
            // virementTableAdapter
            // 
            this.virementTableAdapter.ClearBeforeFill = true;
            // 
            // AddVirement
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddVirement";
            this.Text = "Ajouter Virement";
            this.Load += new System.EventHandler(this.AddVirement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton PspExp;
        private System.Windows.Forms.RadioButton CniExp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NumIdExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumComExp;
        private System.Windows.Forms.RadioButton EpExp;
        private System.Windows.Forms.RadioButton CoExp;
        private System.Windows.Forms.DateTimePicker DateVi;
        private System.Windows.Forms.RadioButton Non;
        private System.Windows.Forms.RadioButton Oui;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.RadioButton Retrait;
        private System.Windows.Forms.RadioButton Depot;
        private System.Windows.Forms.TextBox LabelVi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton PspDest;
        private System.Windows.Forms.RadioButton CniDest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NumIdDest;
        private System.Windows.Forms.TextBox NumComDest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton EpDest;
        private System.Windows.Forms.RadioButton CoDest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem epargneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private System.Windows.Forms.Button Submit;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource virementBindingSource;
        private gestion_bankDataSetTableAdapters.virementTableAdapter virementTableAdapter;
    }
}