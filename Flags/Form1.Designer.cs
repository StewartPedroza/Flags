namespace Flags
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
            this.FlagViewerLabel = new System.Windows.Forms.Label();
            this.PhilippinesRadioButton = new System.Windows.Forms.RadioButton();
            this.ColumbiaRadioButton = new System.Windows.Forms.RadioButton();
            this.USARadioButton = new System.Windows.Forms.RadioButton();
            this.FranceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TitleCheckbox = new System.Windows.Forms.CheckBox();
            this.NameCheckbox = new System.Windows.Forms.CheckBox();
            this.ProgrammerCheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlagViewerLabel
            // 
            this.FlagViewerLabel.AutoSize = true;
            this.FlagViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagViewerLabel.Location = new System.Drawing.Point(398, 73);
            this.FlagViewerLabel.Name = "FlagViewerLabel";
            this.FlagViewerLabel.Size = new System.Drawing.Size(136, 25);
            this.FlagViewerLabel.TabIndex = 0;
            this.FlagViewerLabel.Text = "Flag Viewer";
            this.FlagViewerLabel.Visible = false;
            // 
            // PhilippinesRadioButton
            // 
            this.PhilippinesRadioButton.AutoSize = true;
            this.PhilippinesRadioButton.Location = new System.Drawing.Point(25, 29);
            this.PhilippinesRadioButton.Name = "PhilippinesRadioButton";
            this.PhilippinesRadioButton.Size = new System.Drawing.Size(75, 17);
            this.PhilippinesRadioButton.TabIndex = 1;
            this.PhilippinesRadioButton.TabStop = true;
            this.PhilippinesRadioButton.Text = "Philippines";
            this.PhilippinesRadioButton.UseVisualStyleBackColor = true;
            this.PhilippinesRadioButton.CheckedChanged += new System.EventHandler(this.PhilippinesRadioButton_CheckedChanged);
            // 
            // ColumbiaRadioButton
            // 
            this.ColumbiaRadioButton.AutoSize = true;
            this.ColumbiaRadioButton.Location = new System.Drawing.Point(25, 52);
            this.ColumbiaRadioButton.Name = "ColumbiaRadioButton";
            this.ColumbiaRadioButton.Size = new System.Drawing.Size(68, 17);
            this.ColumbiaRadioButton.TabIndex = 2;
            this.ColumbiaRadioButton.TabStop = true;
            this.ColumbiaRadioButton.Text = "Columbia";
            this.ColumbiaRadioButton.UseVisualStyleBackColor = true;
            this.ColumbiaRadioButton.CheckedChanged += new System.EventHandler(this.ColumbiaRadioButton_CheckedChanged);
            // 
            // USARadioButton
            // 
            this.USARadioButton.AutoSize = true;
            this.USARadioButton.Location = new System.Drawing.Point(25, 75);
            this.USARadioButton.Name = "USARadioButton";
            this.USARadioButton.Size = new System.Drawing.Size(47, 17);
            this.USARadioButton.TabIndex = 3;
            this.USARadioButton.TabStop = true;
            this.USARadioButton.Text = "USA";
            this.USARadioButton.UseVisualStyleBackColor = true;
            this.USARadioButton.CheckedChanged += new System.EventHandler(this.USARadioButton_CheckedChanged);
            // 
            // FranceRadioButton
            // 
            this.FranceRadioButton.AutoSize = true;
            this.FranceRadioButton.Location = new System.Drawing.Point(25, 98);
            this.FranceRadioButton.Name = "FranceRadioButton";
            this.FranceRadioButton.Size = new System.Drawing.Size(58, 17);
            this.FranceRadioButton.TabIndex = 4;
            this.FranceRadioButton.TabStop = true;
            this.FranceRadioButton.Text = "France";
            this.FranceRadioButton.UseVisualStyleBackColor = true;
            this.FranceRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhilippinesRadioButton);
            this.groupBox1.Controls.Add(this.FranceRadioButton);
            this.groupBox1.Controls.Add(this.ColumbiaRadioButton);
            this.groupBox1.Controls.Add(this.USARadioButton);
            this.groupBox1.Location = new System.Drawing.Point(90, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProgrammerCheckbox);
            this.groupBox2.Controls.Add(this.NameCheckbox);
            this.groupBox2.Controls.Add(this.TitleCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(647, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // TitleCheckbox
            // 
            this.TitleCheckbox.AutoSize = true;
            this.TitleCheckbox.Location = new System.Drawing.Point(24, 20);
            this.TitleCheckbox.Name = "TitleCheckbox";
            this.TitleCheckbox.Size = new System.Drawing.Size(46, 17);
            this.TitleCheckbox.TabIndex = 0;
            this.TitleCheckbox.Text = "Title";
            this.TitleCheckbox.UseVisualStyleBackColor = true;
            this.TitleCheckbox.CheckedChanged += new System.EventHandler(this.TitleCheckbox_CheckedChanged);
            // 
            // NameCheckbox
            // 
            this.NameCheckbox.AutoSize = true;
            this.NameCheckbox.Location = new System.Drawing.Point(24, 44);
            this.NameCheckbox.Name = "NameCheckbox";
            this.NameCheckbox.Size = new System.Drawing.Size(93, 17);
            this.NameCheckbox.TabIndex = 1;
            this.NameCheckbox.Text = "Country Name";
            this.NameCheckbox.UseVisualStyleBackColor = true;
            this.NameCheckbox.CheckedChanged += new System.EventHandler(this.NameCheckbox_CheckedChanged);
            // 
            // ProgrammerCheckbox
            // 
            this.ProgrammerCheckbox.AutoSize = true;
            this.ProgrammerCheckbox.Location = new System.Drawing.Point(24, 68);
            this.ProgrammerCheckbox.Name = "ProgrammerCheckbox";
            this.ProgrammerCheckbox.Size = new System.Drawing.Size(82, 17);
            this.ProgrammerCheckbox.TabIndex = 2;
            this.ProgrammerCheckbox.Text = "Programmer";
            this.ProgrammerCheckbox.UseVisualStyleBackColor = true;
            this.ProgrammerCheckbox.CheckedChanged += new System.EventHandler(this.ProgrammerCheckbox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(345, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Location = new System.Drawing.Point(448, 315);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(0, 13);
            this.CountryNameLabel.TabIndex = 8;
            this.CountryNameLabel.Visible = false;
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Location = new System.Drawing.Point(115, 334);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgrammerLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 410);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FlagViewerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlagViewerLabel;
        private System.Windows.Forms.RadioButton PhilippinesRadioButton;
        private System.Windows.Forms.RadioButton ColumbiaRadioButton;
        private System.Windows.Forms.RadioButton USARadioButton;
        private System.Windows.Forms.RadioButton FranceRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ProgrammerCheckbox;
        private System.Windows.Forms.CheckBox NameCheckbox;
        private System.Windows.Forms.CheckBox TitleCheckbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.Label ProgrammerLabel;
    }
}

