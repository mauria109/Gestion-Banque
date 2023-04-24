
namespace GestionBankApp.View
{
    partial class ListeVirement
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
            this.virementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.virementTableAdapter = new GestionBankApp.gestion_bankDataSetTableAdapters.virementTableAdapter();
            this.idviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomexpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virementBindingSource)).BeginInit();
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
            this.idviDataGridViewTextBoxColumn,
            this.labelviDataGridViewTextBoxColumn,
            this.typeviDataGridViewTextBoxColumn,
            this.idcomemDataGridViewTextBoxColumn,
            this.idcomexpDataGridViewTextBoxColumn,
            this.montantviDataGridViewTextBoxColumn,
            this.dateviDataGridViewTextBoxColumn,
            this.statutviDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.virementBindingSource;
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
            // virementBindingSource
            // 
            this.virementBindingSource.DataMember = "virement";
            this.virementBindingSource.DataSource = this.gestion_bankDataSet;
            // 
            // virementTableAdapter
            // 
            this.virementTableAdapter.ClearBeforeFill = true;
            // 
            // idviDataGridViewTextBoxColumn
            // 
            this.idviDataGridViewTextBoxColumn.DataPropertyName = "id_vi";
            this.idviDataGridViewTextBoxColumn.HeaderText = "id_vi";
            this.idviDataGridViewTextBoxColumn.Name = "idviDataGridViewTextBoxColumn";
            // 
            // labelviDataGridViewTextBoxColumn
            // 
            this.labelviDataGridViewTextBoxColumn.DataPropertyName = "label_vi";
            this.labelviDataGridViewTextBoxColumn.HeaderText = "label_vi";
            this.labelviDataGridViewTextBoxColumn.Name = "labelviDataGridViewTextBoxColumn";
            // 
            // typeviDataGridViewTextBoxColumn
            // 
            this.typeviDataGridViewTextBoxColumn.DataPropertyName = "type_vi";
            this.typeviDataGridViewTextBoxColumn.HeaderText = "type_vi";
            this.typeviDataGridViewTextBoxColumn.Name = "typeviDataGridViewTextBoxColumn";
            // 
            // idcomemDataGridViewTextBoxColumn
            // 
            this.idcomemDataGridViewTextBoxColumn.DataPropertyName = "id_com_em";
            this.idcomemDataGridViewTextBoxColumn.HeaderText = "id_com_em";
            this.idcomemDataGridViewTextBoxColumn.Name = "idcomemDataGridViewTextBoxColumn";
            // 
            // idcomexpDataGridViewTextBoxColumn
            // 
            this.idcomexpDataGridViewTextBoxColumn.DataPropertyName = "id_com_exp";
            this.idcomexpDataGridViewTextBoxColumn.HeaderText = "id_com_exp";
            this.idcomexpDataGridViewTextBoxColumn.Name = "idcomexpDataGridViewTextBoxColumn";
            // 
            // montantviDataGridViewTextBoxColumn
            // 
            this.montantviDataGridViewTextBoxColumn.DataPropertyName = "montant_vi";
            this.montantviDataGridViewTextBoxColumn.HeaderText = "montant_vi";
            this.montantviDataGridViewTextBoxColumn.Name = "montantviDataGridViewTextBoxColumn";
            // 
            // dateviDataGridViewTextBoxColumn
            // 
            this.dateviDataGridViewTextBoxColumn.DataPropertyName = "date_vi";
            this.dateviDataGridViewTextBoxColumn.HeaderText = "date_vi";
            this.dateviDataGridViewTextBoxColumn.Name = "dateviDataGridViewTextBoxColumn";
            // 
            // statutviDataGridViewTextBoxColumn
            // 
            this.statutviDataGridViewTextBoxColumn.DataPropertyName = "statut_vi";
            this.statutviDataGridViewTextBoxColumn.HeaderText = "statut_vi";
            this.statutviDataGridViewTextBoxColumn.Name = "statutviDataGridViewTextBoxColumn";
            // 
            // ListeVirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListeVirement";
            this.Text = "ListeVirement";
            this.Load += new System.EventHandler(this.ListeVirement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem généralToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gestion_bankDataSet gestion_bankDataSet;
        private System.Windows.Forms.BindingSource virementBindingSource;
        private gestion_bankDataSetTableAdapters.virementTableAdapter virementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomexpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutviDataGridViewTextBoxColumn;
    }
}