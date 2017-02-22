namespace BazaDanych
{
    partial class NewTable
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
            this.dataGridViewNewTable = new System.Windows.Forms.DataGridView();
            this.labelTable = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddField = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNewTable
            // 
            this.dataGridViewNewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNewTable.Name = "dataGridViewNewTable";
            this.dataGridViewNewTable.Size = new System.Drawing.Size(749, 77);
            this.dataGridViewNewTable.TabIndex = 4;
            this.dataGridViewNewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewTable_CellContentClick);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTable.Location = new System.Drawing.Point(12, 102);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(57, 16);
            this.labelTable.TabIndex = 5;
            this.labelTable.Text = "Table: ";
            this.labelTable.Click += new System.EventHandler(this.labelTable_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(686, 99);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddField
            // 
            this.buttonAddField.Location = new System.Drawing.Point(605, 99);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(75, 23);
            this.buttonAddField.TabIndex = 6;
            this.buttonAddField.Text = "Add field";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 127);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddField);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.dataGridViewNewTable);
            this.Name = "NewTable";
            this.Text = "NewTable";
            this.Load += new System.EventHandler(this.NewTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNewTable;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddField;
    }
}