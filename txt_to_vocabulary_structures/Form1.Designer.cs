namespace CHaszo6
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
            this.filetime_label = new System.Windows.Forms.Label();
            this.twostructure_label = new System.Windows.Forms.Label();
            this.threesctructure_label = new System.Windows.Forms.Label();
            this.filetime_Timelabel = new System.Windows.Forms.Label();
            this.twostructure_Timelabel = new System.Windows.Forms.Label();
            this.threestructure_Timelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filetime_label
            // 
            this.filetime_label.AutoSize = true;
            this.filetime_label.Location = new System.Drawing.Point(134, 33);
            this.filetime_label.Name = "filetime_label";
            this.filetime_label.Size = new System.Drawing.Size(75, 13);
            this.filetime_label.TabIndex = 0;
            this.filetime_label.Text = "File read time: ";
            // 
            // twostructure_label
            // 
            this.twostructure_label.AutoSize = true;
            this.twostructure_label.Location = new System.Drawing.Point(25, 58);
            this.twostructure_label.Name = "twostructure_label";
            this.twostructure_label.Size = new System.Drawing.Size(184, 13);
            this.twostructure_label.TabIndex = 1;
            this.twostructure_label.Text = "Two letters structure generation time: ";
            // 
            // threesctructure_label
            // 
            this.threesctructure_label.AutoSize = true;
            this.threesctructure_label.Location = new System.Drawing.Point(18, 84);
            this.threesctructure_label.Name = "threesctructure_label";
            this.threesctructure_label.Size = new System.Drawing.Size(191, 13);
            this.threesctructure_label.TabIndex = 2;
            this.threesctructure_label.Text = "Three letters structure generation time: ";
            // 
            // filetime_Timelabel
            // 
            this.filetime_Timelabel.AutoSize = true;
            this.filetime_Timelabel.Location = new System.Drawing.Point(215, 33);
            this.filetime_Timelabel.Name = "filetime_Timelabel";
            this.filetime_Timelabel.Size = new System.Drawing.Size(16, 13);
            this.filetime_Timelabel.TabIndex = 3;
            this.filetime_Timelabel.Text = "---";
            // 
            // twostructure_Timelabel
            // 
            this.twostructure_Timelabel.AutoSize = true;
            this.twostructure_Timelabel.Location = new System.Drawing.Point(215, 58);
            this.twostructure_Timelabel.Name = "twostructure_Timelabel";
            this.twostructure_Timelabel.Size = new System.Drawing.Size(16, 13);
            this.twostructure_Timelabel.TabIndex = 4;
            this.twostructure_Timelabel.Text = "---";
            // 
            // threestructure_Timelabel
            // 
            this.threestructure_Timelabel.AutoSize = true;
            this.threestructure_Timelabel.Location = new System.Drawing.Point(215, 84);
            this.threestructure_Timelabel.Name = "threestructure_Timelabel";
            this.threestructure_Timelabel.Size = new System.Drawing.Size(16, 13);
            this.threestructure_Timelabel.TabIndex = 5;
            this.threestructure_Timelabel.Text = "---";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 240);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.threestructure_Timelabel);
            this.Controls.Add(this.twostructure_Timelabel);
            this.Controls.Add(this.filetime_Timelabel);
            this.Controls.Add(this.threesctructure_label);
            this.Controls.Add(this.twostructure_label);
            this.Controls.Add(this.filetime_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filetime_label;
        private System.Windows.Forms.Label twostructure_label;
        private System.Windows.Forms.Label threesctructure_label;
        private System.Windows.Forms.Label filetime_Timelabel;
        private System.Windows.Forms.Label twostructure_Timelabel;
        private System.Windows.Forms.Label threestructure_Timelabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

