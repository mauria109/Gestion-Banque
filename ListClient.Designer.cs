
namespace GestionBankApp.View
{
    partial class ListClient
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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.clientTableAdapter();
            this.typecarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agecliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taillecliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typecarteDataGridViewTextBoxColumn,
            this.numcarteDataGridViewTextBoxColumn,
            this.nomcliDataGridViewTextBoxColumn,
            this.prenomcliDataGridViewTextBoxColumn,
            this.agecliDataGridViewTextBoxColumn,
            this.taillecliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_bankDataSet
            // 
            this.gestion_bankDataSet.DataSetName = "gestion_bankDataSet";
            this.gestion_bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gestion_bankDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
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
            // nomcliDataGridViewTextBoxColumn
            // 
            this.nomcliDataGridViewTextBoxColumn.DataPropertyName = "nom_cli";
            this.nomcliDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            // 
            // prenomcliDataGridViewTextBoxColumn
            // 
            this.prenomcliDataGridViewTextBoxColumn.DataPropertyName = "prenom_cli";
            this.prenomcliDataGridViewTextBoxColumn.HeaderText = "Prénoms";
            this.prenomcliDataGridViewTextBoxColumn.Name = "prenomcliDataGridViewTextBoxColumn";
            // 
            // agecliDataGridViewTextBoxColumn
            // 
            this.agecliDataGridViewTextBoxColumn.DataPropertyName = "age_cli";
            this.agecliDataGridViewTextBoxColumn.HeaderText = "Age";
            this.agecliDataGridViewTextBoxColumn.Name = "agecliDataGridViewTextBoxColumn";
            // 
            // taillecliDataGridViewTextBoxColumn
            // 
            this.taillecliDataGridViewTextBoxColumn.DataPropertyName = "taille_cli";
            this.taillecliDataGridViewTextBoxColumn.HeaderText = "Taille";
            this.taillecliDataGridViewTextBoxColumn.Name = "taillecliDataGridViewTextBoxColumn";
            // 
            // ListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListClient";
            this.Text = "ListClient";
            this.Load += new System.EventHandler(this.ListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private gestion_bankDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agecliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taillecliDataGridViewTextBoxColumn;
    }
}