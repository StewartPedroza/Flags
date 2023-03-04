using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (FranceRadioButton.Checked)
            {
                CountryNameLabel.Text = "France";
                pictureBox1.Image = Image.FromFile(@"C:\AppsDev VS Studio\Flags\France.png");
            }
            else
                {
                CountryNameLabel.Text = "";
                pictureBox1.Image = null;
                }
        }

        private void PhilippinesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PhilippinesRadioButton.Checked)
                {
                CountryNameLabel.Text = "Philippines";
                pictureBox1.Image = Image.FromFile(@"C:\AppsDev VS Studio\Flags\Philippines.png");
            }
            else 
                {
                CountryNameLabel.Text = "";
                pictureBox1.Image = null;
            }
        }

        private void ColumbiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ColumbiaRadioButton.Checked)
            {
                CountryNameLabel.Text = "Columbia";
                pictureBox1.Image = Image.FromFile(@"C:\AppsDev VS Studio\Flags\Columbia.png");
            }
            else
            {
                CountryNameLabel.Text = "";
                pictureBox1.Image = null;
            }
        }

        private void USARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (USARadioButton.Checked)
            {
                CountryNameLabel.Text = "USA";
                pictureBox1.Image = Image.FromFile(@"C:\AppsDev VS Studio\Flags\USA.jpg");
            }
            else
            {
                CountryNameLabel.Text = "";
                pictureBox1.Image = null;
            }
        }

        private void TitleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleCheckbox.Checked) 
                {
                FlagViewerLabel.Visible = true;
                }
            else
            {
                FlagViewerLabel.Visible = false;
            }
        }

        private void NameCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NameCheckbox.Checked) 
                {
                CountryNameLabel.Visible = true;
                pictureBox1.Visible = true;
            }
            else
                {
                CountryNameLabel.Visible = false;
                pictureBox1.Visible = false;
                }
        }

        private void ProgrammerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProgrammerCheckbox.Checked) 
                {
                ProgrammerLabel.Visible = true;
                ProgrammerLabel.Text = "Pro grammer";
                }
            else 
                { 
                    ProgrammerLabel.Visible = false;
                }
        }
    }
}
