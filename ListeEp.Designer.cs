
namespace GestionBankApp.View
{
    partial class ListeEp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestion_bankDataSet = new GestionBankApp.gestion_bankDataSet();
            this.epargneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epargneTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.epargneTableAdapter();
            this.idepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plafondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epargneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.généralToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // généralToolStripMenuItem
            // 
            this.généralToolStripMenuItem.Name = "généralToolStripMenuItem";
            this.généralToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.généralToolStripMenuItem.Text = "Général";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idepDataGridViewTextBoxColumn,
            this.idcomDataGridViewTextBoxColumn,
            this.interetDataGridViewTextBoxColumn,
            this.plafondDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.epargneBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // gestion_bankDataSet
            // 
            this.gestion_bankDataSet.DataSetName = "gestion_bankDataSet";
            this.gestion_bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // epargneBindingSource
            // 
            this.epargneBindingSource.DataMember = "epargne";
            this.epargneBindingSource.DataSource = this.gestion_bankDataSet;
            // 
            // epargneTableAdapter
            // 
            this.epargneTableAdapter.ClearBeforeFill = true;
            // 
            // idepDataGridViewTextBoxColumn
            // 
            this.idepDataGridViewTextBoxColumn.DataPropertyName = "id_ep";
            this.idepDataGridViewTextBoxColumn.HeaderText = "id_ep";
            this.idepDataGridViewTextBoxColumn.Name = "idepDataGridViewTextBoxColumn";
            // 
            // idcomDataGridViewTextBoxColumn
            // 
            this.idcomDataGridViewTextBoxColumn.DataPropertyName = "id_com";
            this.idcomDataGridViewTextBoxColumn.HeaderText = "id_com";
            this.idcomDataGridViewTextBoxColumn.Name = "idcomDataGridViewTextBoxColumn";
            // 
            // interetDataGridViewTextBoxColumn
            // 
            this.interetDataGridViewTextBoxColumn.DataPropertyName = "interet";
            this.interetDataGridViewTextBoxColumn.HeaderText = "interet";
            this.interetDataGridViewTextBoxColumn.Name = "interetDataGridViewTextBoxColumn";
            // 
            // plafondDataGridViewTextBoxColumn
            // 
            this.plafondDataGridViewTextBoxColumn.DataPropertyName = "plafond";
            this.plafondDataGridViewTextBoxColumn.HeaderText = "plafond";
            this.plafondDataGridViewTextBoxColumn.Name = "plafondDataGridViewTextBoxColumn";
            // 
            // ListeEp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListeEp";
            this.Text = "ListeEp";
            this.Load += new System.EventHandler(this.ListeEp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epargneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource epargneBindingSource;
        private gestion_bankDataSetTableAdapters.epargneTableAdapter epargneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plafondDataGridViewTextBoxColumn;
    }
}