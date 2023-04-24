
namespace GestionBankApp.View
{
    partial class ListeComptes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestion_bankDataSet = new GestionBankApp.gestion_bankDataSet();
            this.compteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compteTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.compteTableAdapter();
            this.idcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldecomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouverturecomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.généralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomDataGridViewTextBoxColumn,
            this.labelcomDataGridViewTextBoxColumn,
            this.soldecomDataGridViewTextBoxColumn,
            this.ouverturecomDataGridViewTextBoxColumn,
            this.numcomDataGridViewTextBoxColumn,
            this.idcliDataGridViewTextBoxColumn,
            this.typecomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_bankDataSet
            // 
            this.gestion_bankDataSet.DataSetName = "gestion_bankDataSet";
            this.gestion_bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compteBindingSource
            // 
            this.compteBindingSource.DataMember = "compte";
            this.compteBindingSource.DataSource = this.gestion_bankDataSet;
            // 
            // compteTableAdapter
            // 
            this.compteTableAdapter.ClearBeforeFill = true;
            // 
            // idcomDataGridViewTextBoxColumn
            // 
            this.idcomDataGridViewTextBoxColumn.DataPropertyName = "id_com";
            this.idcomDataGridViewTextBoxColumn.HeaderText = "id_com";
            this.idcomDataGridViewTextBoxColumn.Name = "idcomDataGridViewTextBoxColumn";
            // 
            // labelcomDataGridViewTextBoxColumn
            // 
            this.labelcomDataGridViewTextBoxColumn.DataPropertyName = "label_com";
            this.labelcomDataGridViewTextBoxColumn.HeaderText = "label_com";
            this.labelcomDataGridViewTextBoxColumn.Name = "labelcomDataGridViewTextBoxColumn";
            // 
            // soldecomDataGridViewTextBoxColumn
            // 
            this.soldecomDataGridViewTextBoxColumn.DataPropertyName = "solde_com";
            this.soldecomDataGridViewTextBoxColumn.HeaderText = "solde_com";
            this.soldecomDataGridViewTextBoxColumn.Name = "soldecomDataGridViewTextBoxColumn";
            // 
            // ouverturecomDataGridViewTextBoxColumn
            // 
            this.ouverturecomDataGridViewTextBoxColumn.DataPropertyName = "ouverture_com";
            this.ouverturecomDataGridViewTextBoxColumn.HeaderText = "ouverture_com";
            this.ouverturecomDataGridViewTextBoxColumn.Name = "ouverturecomDataGridViewTextBoxColumn";
            // 
            // numcomDataGridViewTextBoxColumn
            // 
            this.numcomDataGridViewTextBoxColumn.DataPropertyName = "num_com";
            this.numcomDataGridViewTextBoxColumn.HeaderText = "num_com";
            this.numcomDataGridViewTextBoxColumn.Name = "numcomDataGridViewTextBoxColumn";
            // 
            // idcliDataGridViewTextBoxColumn
            // 
            this.idcliDataGridViewTextBoxColumn.DataPropertyName = "id_cli";
            this.idcliDataGridViewTextBoxColumn.HeaderText = "id_cli";
            this.idcliDataGridViewTextBoxColumn.Name = "idcliDataGridViewTextBoxColumn";
            // 
            // typecomDataGridViewTextBoxColumn
            // 
            this.typecomDataGridViewTextBoxColumn.DataPropertyName = "type_com";
            this.typecomDataGridViewTextBoxColumn.HeaderText = "type_com";
            this.typecomDataGridViewTextBoxColumn.Name = "typecomDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.généralToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // généralToolStripMenuItem
            // 
            this.généralToolStripMenuItem.Name = "généralToolStripMenuItem";
            this.généralToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.généralToolStripMenuItem.Text = "Général";
            // 
            // ListeComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListeComptes";
            this.Text = "ListeComptes";
            this.Load += new System.EventHandler(this.ListeComptes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource compteBindingSource;
        private gestion_bankDataSetTableAdapters.compteTableAdapter compteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldecomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ouverturecomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecomDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
    }
}