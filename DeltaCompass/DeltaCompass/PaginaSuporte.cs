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
    public partial class PaginaSuporte : Form
    {
        public PaginaSuporte()
        {
            InitializeComponent();
        }

        private void PaginaSuporte_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
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

        public void Alert(string msg)
        {
            SensAplicadaAlert frm = new SensAplicadaAlert();
            frm.showAlert(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Alert("Ticket Enviado.");
            textBoxControl1.Texts = "";
            textBoxControl2.Texts = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(39, 39, 39);
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }
    }
}
