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
    public partial class PaginaConfiguracao : Form
    {
        public PaginaConfiguracao()
        {
            InitializeComponent();
        }

        private void roundControl1_Load(object sender, EventArgs e)
        {

        }

        private void PaginaConfiguracao_Load(object sender, EventArgs e)
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

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.SteelBlue;
            this.Cursor = Cursors.Hand;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.DodgerBlue;
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
            label21.Visible = true;
            flowLayoutPanel1.Visible = false;
            panelConfiguracao.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label20.Visible = true;
            label21.Visible = false;
            flowLayoutPanel1.Visible = true;
            panelConfiguracao.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(162, 162, 162);
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(162, 162, 162);
            this.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(28, 26, 115);
            button4.ForeColor = Color.DarkGray;
            this.Cursor = Cursors.Hand;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(46, 43, 194);
            button4.ForeColor = SystemColors.Control;
            this.Cursor = Cursors.Default;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(28, 26, 115);
            button5.ForeColor = Color.DarkGray;
            this.Cursor = Cursors.Hand;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(46, 43, 194);
            button5.ForeColor = SystemColors.Control;
            this.Cursor = Cursors.Default;
        }

        public void Alert(string msg)
        {
            SensAplicadaAlert frm = new SensAplicadaAlert();
            frm.showAlert(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Alert("Configurações Salvas.");
        }
    }
}
