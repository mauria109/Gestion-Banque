
namespace GestionBankApp.View
{
    partial class Add_Admin
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
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_bankDataSet = new GestionBankApp.gestion_bankDataSet();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Validate = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.adminTableAdapter();
            this.Cni = new System.Windows.Forms.RadioButton();
            this.Psp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Psp);
            this.groupBox1.Controls.Add(this.Cni);
            this.groupBox1.Controls.Add(this.Pwd);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.Prenom);
            this.groupBox1.Controls.Add(this.Nom);
            this.groupBox1.Controls.Add(this.Num);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos utilisateur";
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
            // Pwd
            // 
            this.Pwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "mdp_adm", true));
            this.Pwd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "mdp_adm", true));
            this.Pwd.Location = new System.Drawing.Point(479, 190);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(255, 23);
            this.Pwd.TabIndex = 10;
            // 
            // Login
            // 
            this.Login.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "login_adm", true));
            this.Login.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "login_adm", true));
            this.Login.Location = new System.Drawing.Point(105, 190);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(218, 23);
            this.Login.TabIndex = 9;
            // 
            // Prenom
            // 
            this.Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "prenom_adm", true));
            this.Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "prenom_adm", true));
            this.Prenom.Location = new System.Drawing.Point(479, 112);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(255, 23);
            this.Prenom.TabIndex = 8;
            // 
            // Nom
            // 
            this.Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "nom_adm", true));
            this.Nom.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "nom_adm", true));
            this.Nom.Location = new System.Drawing.Point(49, 112);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(274, 23);
            this.Nom.TabIndex = 7;
            // 
            // Num
            // 
            this.Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "num_carte", true));
            this.Num.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "num_carte", true));
            this.Num.Location = new System.Drawing.Point(479, 47);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(255, 23);
            this.Num.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numéro identité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prénom(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pseudo/email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type identité";
            // 
            // Validate
            // 
            this.Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validate.Location = new System.Drawing.Point(36, 399);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(347, 39);
            this.Validate.TabIndex = 1;
            this.Validate.Text = "Valider";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Create);
            // 
            // Cancel
            // 
            this.Cancel.CausesValidation = false;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(453, 399);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(323, 39);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.monCompteToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem1});
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.accueilToolStripMenuItem.Text = "Général";
            // 
            // accueilToolStripMenuItem1
            // 
            this.accueilToolStripMenuItem1.Name = "accueilToolStripMenuItem1";
            this.accueilToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.accueilToolStripMenuItem1.Text = "Accueil";
            // 
            // monCompteToolStripMenuItem
            // 
            this.monCompteToolStripMenuItem.Name = "monCompteToolStripMenuItem";
            this.monCompteToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.monCompteToolStripMenuItem.Text = "Mon compte";
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
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // Cni
            // 
            this.Cni.AutoSize = true;
            this.Cni.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.adminBindingSource, "type_carte", true));
            this.Cni.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "type_carte", true));
            this.Cni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "type_carte", true));
            this.Cni.Location = new System.Drawing.Point(122, 49);
            this.Cni.Name = "Cni";
            this.Cni.Size = new System.Drawing.Size(48, 21);
            this.Cni.TabIndex = 11;
            this.Cni.TabStop = true;
            this.Cni.Text = "CNI";
            this.Cni.UseVisualStyleBackColor = true;
            this.Cni.CheckedChanged += new System.EventHandler(this.Cni_CheckedChanged);
            // 
            // Psp
            // 
            this.Psp.AutoSize = true;
            this.Psp.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.adminBindingSource, "type_carte", true));
            this.Psp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminBindingSource, "type_carte", true));
            this.Psp.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.adminBindingSource, "type_carte", true));
            this.Psp.Location = new System.Drawing.Point(233, 47);
            this.Psp.Name = "Psp";
            this.Psp.Size = new System.Drawing.Size(90, 21);
            this.Psp.TabIndex = 12;
            this.Psp.TabStop = true;
            this.Psp.Text = "Passeport";
            this.Psp.UseVisualStyleBackColor = true;
            this.Psp.CheckedChanged += new System.EventHandler(this.Psp_CheckedChanged);
            // 
            // Add_Admin
            // 
            this.AcceptButton = this.Validate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Add_Admin";
            this.Text = "Add_Admin";
            this.Load += new System.EventHandler(this.Add_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private gestion_bankDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem1;
        private System.Windows.Forms.RadioButton Psp;
        private System.Windows.Forms.RadioButton Cni;
    }
}