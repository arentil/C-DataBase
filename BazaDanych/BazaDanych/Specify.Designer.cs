namespace BazaDanych
{
    partial class Specify
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonLeftLeft = new System.Windows.Forms.Button();
            this.buttonRightRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.buttonRR = new System.Windows.Forms.Button();
            this.buttonLL = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.comboBoxSelectTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 134);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(174, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(105, 134);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(134, 58);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(24, 24);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(134, 148);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(24, 24);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonLeftLeft
            // 
            this.buttonLeftLeft.Location = new System.Drawing.Point(129, 118);
            this.buttonLeftLeft.Name = "buttonLeftLeft";
            this.buttonLeftLeft.Size = new System.Drawing.Size(34, 24);
            this.buttonLeftLeft.TabIndex = 5;
            this.buttonLeftLeft.Text = "<<";
            this.buttonLeftLeft.UseVisualStyleBackColor = true;
            this.buttonLeftLeft.Click += new System.EventHandler(this.buttonLeftLeft_Click);
            // 
            // buttonRightRight
            // 
            this.buttonRightRight.Location = new System.Drawing.Point(129, 88);
            this.buttonRightRight.Name = "buttonRightRight";
            this.buttonRightRight.Size = new System.Drawing.Size(34, 24);
            this.buttonRightRight.TabIndex = 6;
            this.buttonRightRight.Text = ">>";
            this.buttonRightRight.UseVisualStyleBackColor = true;
            this.buttonRightRight.Click += new System.EventHandler(this.buttonRightRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select tables:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected tables:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 255);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(105, 134);
            this.listBox3.TabIndex = 9;
            this.listBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox3_MouseDoubleClick);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(174, 255);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(222, 134);
            this.listBox4.TabIndex = 10;
            this.listBox4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox4_MouseDoubleClick);
            // 
            // buttonRR
            // 
            this.buttonRR.Location = new System.Drawing.Point(129, 294);
            this.buttonRR.Name = "buttonRR";
            this.buttonRR.Size = new System.Drawing.Size(34, 24);
            this.buttonRR.TabIndex = 14;
            this.buttonRR.Text = ">>";
            this.buttonRR.UseVisualStyleBackColor = true;
            this.buttonRR.Click += new System.EventHandler(this.buttonRR_Click);
            // 
            // buttonLL
            // 
            this.buttonLL.Location = new System.Drawing.Point(129, 324);
            this.buttonLL.Name = "buttonLL";
            this.buttonLL.Size = new System.Drawing.Size(34, 24);
            this.buttonLL.TabIndex = 13;
            this.buttonLL.Text = "<<";
            this.buttonLL.UseVisualStyleBackColor = true;
            this.buttonLL.Click += new System.EventHandler(this.buttonLL_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(134, 354);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(24, 24);
            this.buttonL.TabIndex = 12;
            this.buttonL.Text = "<";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(134, 264);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(24, 24);
            this.buttonR.TabIndex = 11;
            this.buttonR.Text = ">";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // comboBoxSelectTable
            // 
            this.comboBoxSelectTable.FormattingEnabled = true;
            this.comboBoxSelectTable.Location = new System.Drawing.Point(12, 228);
            this.comboBoxSelectTable.Name = "comboBoxSelectTable";
            this.comboBoxSelectTable.Size = new System.Drawing.Size(105, 21);
            this.comboBoxSelectTable.TabIndex = 15;
            this.comboBoxSelectTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select table:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Selected columns:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select common column:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Join";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Specify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSelectTable);
            this.Controls.Add(this.buttonRR);
            this.Controls.Add(this.buttonLL);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRightRight);
            this.Controls.Add(this.buttonLeftLeft);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Specify";
            this.Text = "Specify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonLeftLeft;
        private System.Windows.Forms.Button buttonRightRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button buttonRR;
        private System.Windows.Forms.Button buttonLL;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.ComboBox comboBoxSelectTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}