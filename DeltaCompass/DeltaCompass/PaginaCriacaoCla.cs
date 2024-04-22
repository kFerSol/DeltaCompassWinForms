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
    public partial class PaginaCriacaoCla : Form
    {
        public PaginaCriacaoCla()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(28, 26, 115);
            button3.ForeColor = Color.DarkGray;
            this.Cursor = Cursors.Hand;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(46, 43, 194);
            button3.ForeColor = SystemColors.Control;
            this.Cursor = Cursors.Default;
        }

        private void roundControl1_MouseEnter(object sender, EventArgs e)
        {
            roundControl1.BackgroundColor = Color.FromArgb(49, 49, 49);
            this.Cursor = Cursors.Hand;
        }

        private void roundControl1_MouseLeave(object sender, EventArgs e)
        {
            roundControl1.BackgroundColor = Color.FromArgb(69, 69, 69);
            this.Cursor = Cursors.Default;
        }

        public event EventHandler CriarClaClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            CriarClaClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PaginaCriacaoCla_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
