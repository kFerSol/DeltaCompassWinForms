using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaCompass
{
    public partial class FormVisualizarConfiguracao : Form
    {
        public FormVisualizarConfiguracao()
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

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(74, 74, 74);
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(43, 43, 43);
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(74, 74, 74);
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(43, 43, 43);
            this.Cursor = Cursors.Default;
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
    }
}
