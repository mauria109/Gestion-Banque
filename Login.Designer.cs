
namespace GestionBankApp.View
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Psp = new System.Windows.Forms.RadioButton();
            this.Cni = new System.Windows.Forms.RadioButton();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Pseudo = new System.Windows.Forms.TextBox();
            this.NumId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.généralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authentificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Psp);
            this.groupBox1.Controls.Add(this.Cni);
            this.groupBox1.Controls.Add(this.Pwd);
            this.groupBox1.Controls.Add(this.Pseudo);
            this.groupBox1.Controls.Add(this.NumId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos connexion";
            // 
            // Psp
            // 
            this.Psp.AutoSize = true;
            this.Psp.Location = new System.Drawing.Point(316, 38);
            this.Psp.Name = "Psp";
            this.Psp.Size = new System.Drawing.Size(94, 22);
            this.Psp.TabIndex = 8;
            this.Psp.TabStop = true;
            this.Psp.Text = "Passeport";
            this.Psp.UseVisualStyleBackColor = true;
            // 
            // Cni
            // 
            this.Cni.AutoSize = true;
            this.Cni.Location = new System.Drawing.Point(139, 38);
            this.Cni.Name = "Cni";
            this.Cni.Size = new System.Drawing.Size(51, 22);
            this.Cni.TabIndex = 7;
            this.Cni.TabStop = true;
            this.Cni.Text = "CNI";
            this.Cni.UseVisualStyleBackColor = true;
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(139, 192);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(313, 24);
            this.Pwd.TabIndex = 6;
            // 
            // Pseudo
            // 
            this.Pseudo.Location = new System.Drawing.Point(139, 137);
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.Size = new System.Drawing.Size(313, 24);
            this.Pseudo.TabIndex = 5;
            // 
            // NumId
            // 
            this.NumId.Location = new System.Drawing.Point(139, 84);
            this.NumId.Name = "NumId";
            this.NumId.Size = new System.Drawing.Size(313, 24);
            this.NumId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pseudo/email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro identité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type identité";
            // 
            // Valid
            // 
            this.Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valid.Location = new System.Drawing.Point(43, 394);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(301, 44);
            this.Valid.TabIndex = 1;
            this.Valid.Text = "Connexion";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Create);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(446, 394);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(272, 44);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.généralToolStripMenuItem,
            this.administrateursToolStripMenuItem});
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
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // administrateursToolStripMenuItem
            // 
            this.administrateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authentificationToolStripMenuItem});
            this.administrateursToolStripMenuItem.Name = "administrateursToolStripMenuItem";
            this.administrateursToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.administrateursToolStripMenuItem.Text = "Administrateurs";
            // 
            // authentificationToolStripMenuItem
            // 
            this.authentificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionToolStripMenuItem});
            this.authentificationToolStripMenuItem.Name = "authentificationToolStripMenuItem";
            this.authentificationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.authentificationToolStripMenuItem.Text = "Authentification";
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            // 
            // Login
            // 
            this.AcceptButton = this.Valid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Psp;
        private System.Windows.Forms.RadioButton Cni;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox Pseudo;
        private System.Windows.Forms.TextBox NumId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authentificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
    }
}