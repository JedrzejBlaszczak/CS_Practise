namespace CHash4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.figurePanel = new System.Windows.Forms.Panel();
            this.radioSwobodne = new System.Windows.Forms.RadioButton();
            this.radioProstokat = new System.Windows.Forms.RadioButton();
            this.radioLinia = new System.Windows.Forms.RadioButton();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorWhiteBox = new System.Windows.Forms.PictureBox();
            this.colorBlueBox = new System.Windows.Forms.PictureBox();
            this.colorGreenBox = new System.Windows.Forms.PictureBox();
            this.colorRedBox = new System.Windows.Forms.PictureBox();
            this.colorBlackBox = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.figurePanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorWhiteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // figurePanel
            // 
            this.figurePanel.Controls.Add(this.radioSwobodne);
            this.figurePanel.Controls.Add(this.radioProstokat);
            this.figurePanel.Controls.Add(this.radioLinia);
            this.figurePanel.Location = new System.Drawing.Point(12, 12);
            this.figurePanel.Name = "figurePanel";
            this.figurePanel.Size = new System.Drawing.Size(197, 75);
            this.figurePanel.TabIndex = 1;
            this.figurePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.figurePanel_Paint);
            // 
            // radioSwobodne
            // 
            this.radioSwobodne.AutoSize = true;
            this.radioSwobodne.Location = new System.Drawing.Point(4, 49);
            this.radioSwobodne.Name = "radioSwobodne";
            this.radioSwobodne.Size = new System.Drawing.Size(126, 17);
            this.radioSwobodne.TabIndex = 2;
            this.radioSwobodne.TabStop = true;
            this.radioSwobodne.Text = "Swobodne rysowanie";
            this.radioSwobodne.UseVisualStyleBackColor = true;
            // 
            // radioProstokat
            // 
            this.radioProstokat.AutoSize = true;
            this.radioProstokat.Location = new System.Drawing.Point(4, 26);
            this.radioProstokat.Name = "radioProstokat";
            this.radioProstokat.Size = new System.Drawing.Size(70, 17);
            this.radioProstokat.TabIndex = 1;
            this.radioProstokat.TabStop = true;
            this.radioProstokat.Text = "Prostokąt";
            this.radioProstokat.UseVisualStyleBackColor = true;
            // 
            // radioLinia
            // 
            this.radioLinia.AutoSize = true;
            this.radioLinia.Location = new System.Drawing.Point(4, 4);
            this.radioLinia.Name = "radioLinia";
            this.radioLinia.Size = new System.Drawing.Size(47, 17);
            this.radioLinia.TabIndex = 0;
            this.radioLinia.TabStop = true;
            this.radioLinia.Text = "Linia";
            this.radioLinia.UseVisualStyleBackColor = true;
            this.radioLinia.CheckedChanged += new System.EventHandler(this.radioLinia_CheckedChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.colorPanel.Controls.Add(this.colorWhiteBox);
            this.colorPanel.Controls.Add(this.colorBlueBox);
            this.colorPanel.Controls.Add(this.colorGreenBox);
            this.colorPanel.Controls.Add(this.colorRedBox);
            this.colorPanel.Controls.Add(this.colorBlackBox);
            this.colorPanel.Location = new System.Drawing.Point(215, 25);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(185, 62);
            this.colorPanel.TabIndex = 2;
            this.colorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPanel_Paint);
            // 
            // colorWhiteBox
            // 
            this.colorWhiteBox.BackColor = System.Drawing.Color.White;
            this.colorWhiteBox.Location = new System.Drawing.Point(142, 18);
            this.colorWhiteBox.Name = "colorWhiteBox";
            this.colorWhiteBox.Size = new System.Drawing.Size(26, 25);
            this.colorWhiteBox.TabIndex = 4;
            this.colorWhiteBox.TabStop = false;
            this.colorWhiteBox.Click += new System.EventHandler(this.colorWhiteBox_Click);
            // 
            // colorBlueBox
            // 
            this.colorBlueBox.BackColor = System.Drawing.Color.Blue;
            this.colorBlueBox.Location = new System.Drawing.Point(110, 18);
            this.colorBlueBox.Name = "colorBlueBox";
            this.colorBlueBox.Size = new System.Drawing.Size(26, 25);
            this.colorBlueBox.TabIndex = 3;
            this.colorBlueBox.TabStop = false;
            this.colorBlueBox.Click += new System.EventHandler(this.colorBlueBox_Click);
            // 
            // colorGreenBox
            // 
            this.colorGreenBox.BackColor = System.Drawing.Color.Green;
            this.colorGreenBox.Location = new System.Drawing.Point(78, 18);
            this.colorGreenBox.Name = "colorGreenBox";
            this.colorGreenBox.Size = new System.Drawing.Size(26, 25);
            this.colorGreenBox.TabIndex = 2;
            this.colorGreenBox.TabStop = false;
            this.colorGreenBox.Click += new System.EventHandler(this.colorGreenBox_Click);
            // 
            // colorRedBox
            // 
            this.colorRedBox.BackColor = System.Drawing.Color.Red;
            this.colorRedBox.Location = new System.Drawing.Point(46, 18);
            this.colorRedBox.Name = "colorRedBox";
            this.colorRedBox.Size = new System.Drawing.Size(26, 25);
            this.colorRedBox.TabIndex = 1;
            this.colorRedBox.TabStop = false;
            this.colorRedBox.Click += new System.EventHandler(this.colorRedBox_Click);
            // 
            // colorBlackBox
            // 
            this.colorBlackBox.BackColor = System.Drawing.Color.Black;
            this.colorBlackBox.Location = new System.Drawing.Point(14, 18);
            this.colorBlackBox.Name = "colorBlackBox";
            this.colorBlackBox.Size = new System.Drawing.Size(26, 25);
            this.colorBlackBox.TabIndex = 0;
            this.colorBlackBox.TabStop = false;
            this.colorBlackBox.Click += new System.EventHandler(this.colorBlackBox_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(406, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 43);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(520, 35);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(520, 61);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 5;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 618);
            this.Controls.Add(this.open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.figurePanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.figurePanel.ResumeLayout(false);
            this.figurePanel.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorWhiteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBlackBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel figurePanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox colorWhiteBox;
        private System.Windows.Forms.PictureBox colorBlueBox;
        private System.Windows.Forms.PictureBox colorGreenBox;
        private System.Windows.Forms.PictureBox colorRedBox;
        private System.Windows.Forms.PictureBox colorBlackBox;
        private System.Windows.Forms.RadioButton radioSwobodne;
        private System.Windows.Forms.RadioButton radioProstokat;
        private System.Windows.Forms.RadioButton radioLinia;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button open;
    }
}

