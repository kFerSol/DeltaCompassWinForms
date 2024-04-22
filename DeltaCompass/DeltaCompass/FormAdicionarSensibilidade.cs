using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaCompass
{
    public partial class FormAdicionarSensibilidade : Form
    {
        public FormAdicionarSensibilidade()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(28, 26, 115);
            button1.ForeColor = Color.DarkGray;
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(46, 43, 194);
            button1.ForeColor = SystemColors.Control;
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(23, 23, 23);
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(17, 17, 17);
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bitmap bmpApex = Properties.Resources.apex_logo;
        Bitmap bmpCs = Properties.Resources.cslogo;
        Bitmap bmpPortal = Properties.Resources.portal_logo;
        Bitmap bmpMwiii = Properties.Resources.MWIII_logo;
        Bitmap bmpRainbow = Properties.Resources.rainbow_logo;

        private void comboBoxControl1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxControl1.SelectedIndex) 
            {
                case 0:
                    pictureBox2.Image = bmpApex;
                    break;
                case 1:
                    pictureBox2.Image = bmpMwiii;
                    break;
                case 2:
                    pictureBox2.Image = bmpCs;
                    break;
                case 3:
                    pictureBox2.Image = bmpPortal;
                    break;
                case 4:
                    pictureBox2.Image = bmpRainbow;
                    break;
            }
        }
    }
}
