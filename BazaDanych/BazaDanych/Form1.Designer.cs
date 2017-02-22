namespace BazaDanych
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.dataGridTableContent = new System.Windows.Forms.DataGridView();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSpecify = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonInsertRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableContent)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.connectButton.Size = new System.Drawing.Size(100, 23);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // dataGridTableContent
            // 
            this.dataGridTableContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTableContent.Location = new System.Drawing.Point(118, 80);
            this.dataGridTableContent.Name = "dataGridTableContent";
            this.dataGridTableContent.Size = new System.Drawing.Size(691, 438);
            this.dataGridTableContent.TabIndex = 12;
            this.dataGridTableContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTableContent_CellContentClick);
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.Location = new System.Drawing.Point(12, 80);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(100, 23);
            this.buttonCreateTable.TabIndex = 16;
            this.buttonCreateTable.Text = "Edit tables";
            this.buttonCreateTable.UseVisualStyleBackColor = true;
            this.buttonCreateTable.Click += new System.EventHandler(this.buttonCreateTable_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select table:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(501, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSpecify
            // 
            this.buttonSpecify.Location = new System.Drawing.Point(694, 51);
            this.buttonSpecify.Name = "buttonSpecify";
            this.buttonSpecify.Size = new System.Drawing.Size(115, 23);
            this.buttonSpecify.TabIndex = 19;
            this.buttonSpecify.Text = "Specify";
            this.buttonSpecify.UseVisualStyleBackColor = true;
            this.buttonSpecify.Click += new System.EventHandler(this.buttonSpecify_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Location = new System.Drawing.Point(12, 138);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteRow.TabIndex = 20;
            this.buttonDeleteRow.Text = "Delete row";
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonInsertRow
            // 
            this.buttonInsertRow.Location = new System.Drawing.Point(12, 109);
            this.buttonInsertRow.Name = "buttonInsertRow";
            this.buttonInsertRow.Size = new System.Drawing.Size(100, 23);
            this.buttonInsertRow.TabIndex = 21;
            this.buttonInsertRow.Text = "Insert row";
            this.buttonInsertRow.UseVisualStyleBackColor = true;
            this.buttonInsertRow.Click += new System.EventHandler(this.buttonInsertRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 530);
            this.Controls.Add(this.buttonInsertRow);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonSpecify);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateTable);
            this.Controls.Add(this.dataGridTableContent);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTableContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.DataGridView dataGridTableContent;
        private System.Windows.Forms.Button buttonCreateTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSpecify;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonInsertRow;
    }
}

