namespace BazaDanych
{
    partial class CreateTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.textTableName = new System.Windows.Forms.TextBox();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.buttonCreateNewTable = new System.Windows.Forms.Button();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonDeleteFiels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table name:";
            // 
            // textTableName
            // 
            this.textTableName.Location = new System.Drawing.Point(84, 6);
            this.textTableName.Name = "textTableName";
            this.textTableName.Size = new System.Drawing.Size(466, 20);
            this.textTableName.TabIndex = 1;
            this.textTableName.TextChanged += new System.EventHandler(this.textTableName_TextChanged);
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.Size = new System.Drawing.Size(538, 366);
            this.dataGridViewTables.TabIndex = 2;
            this.dataGridViewTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTables_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select table:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(466, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAddField
            // 
            this.buttonAddField.Location = new System.Drawing.Point(556, 59);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(132, 23);
            this.buttonAddField.TabIndex = 8;
            this.buttonAddField.Text = "Add field";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // buttonCreateNewTable
            // 
            this.buttonCreateNewTable.Location = new System.Drawing.Point(556, 4);
            this.buttonCreateNewTable.Name = "buttonCreateNewTable";
            this.buttonCreateNewTable.Size = new System.Drawing.Size(132, 23);
            this.buttonCreateNewTable.TabIndex = 9;
            this.buttonCreateNewTable.Text = "Create new table";
            this.buttonCreateNewTable.UseVisualStyleBackColor = true;
            this.buttonCreateNewTable.Click += new System.EventHandler(this.buttonCreateNewTable_Click);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Location = new System.Drawing.Point(556, 117);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(132, 23);
            this.buttonDeleteTable.TabIndex = 10;
            this.buttonDeleteTable.Text = "Delete selected table";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // buttonDeleteFiels
            // 
            this.buttonDeleteFiels.Location = new System.Drawing.Point(556, 88);
            this.buttonDeleteFiels.Name = "buttonDeleteFiels";
            this.buttonDeleteFiels.Size = new System.Drawing.Size(132, 23);
            this.buttonDeleteFiels.TabIndex = 11;
            this.buttonDeleteFiels.Text = "Delete field";
            this.buttonDeleteFiels.UseVisualStyleBackColor = true;
            this.buttonDeleteFiels.Click += new System.EventHandler(this.buttonDeleteFiels_Click);
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 437);
            this.Controls.Add(this.buttonDeleteFiels);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.buttonCreateNewTable);
            this.Controls.Add(this.buttonAddField);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewTables);
            this.Controls.Add(this.textTableName);
            this.Controls.Add(this.label1);
            this.Name = "CreateTable";
            this.Text = "CreateTable";
            this.Load += new System.EventHandler(this.CreateTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTableName;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.Button buttonCreateNewTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonDeleteFiels;
    }
}