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
    public partial class PaginaConversao : Form
    {
        public PaginaConversao()
        {
            InitializeComponent();
        }

        private void PaginaConversao_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            if (!travarBtn)
            {
                button1.BackColor = Color.FromArgb(103, 103, 103);
            }
            else
            {
                button1.BackColor = Color.FromArgb(46, 43, 194);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (switchLock1 == true && switchLock2 == true)
            {
                button1.BackColor = Color.FromArgb(28, 26, 115);
                button1.ForeColor = Color.DarkGray;
                this.Cursor = Cursors.Hand;
            }
            else
            {
                button1.BackColor = Color.FromArgb(67, 67, 67);
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (switchLock1 == true && switchLock2 == true)
            {
                button1.BackColor = Color.FromArgb(46, 43, 194);
                button1.ForeColor = SystemColors.Control;
                this.Cursor = Cursors.Default;
            }
            else
            {
                button1.BackColor = Color.FromArgb(103, 103, 103);
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(39, 39, 39);
            panel6.BackColor = Color.FromArgb(39, 39, 39);
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(28, 28, 28);
            panel6.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }

        Bitmap bmpApex = Properties.Resources.apex_logo;
        Bitmap bmpCs = Properties.Resources.cslogo;
        Bitmap bmpPortal = Properties.Resources.portal_logo;
        Bitmap bmpMwiii = Properties.Resources.MWIII_logo;
        Bitmap bmpRainbow = Properties.Resources.rainbow_logo;

        bool switchLock1 = false;
        bool switchLock2 = false;
        bool travarBtn = false;

        private void comboBoxControl1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxControl1.SelectedIndex)
            {
                case 0:
                    pictureBox2.Image = bmpApex;
                    txtDpi1.Text = "DPI do Mouse: 800";
                    txtSens1.Text = "Sensibilidade:";
                    txtSensValor1.Text = "1.5";
                    txtResolucao1.Text = "Resolução: 1920x1080";
                    txtProporcao1.Text = "Proporção: 16:9";
                    txtPolegadas1.Text = "Polegadas do Monitor: 34\"";
                    switchLock1 = true;
                    break;
                case 1:
                    pictureBox2.Image = bmpMwiii;
                    txtDpi1.Text = "DPI do Mouse: 800";
                    txtSens1.Text = "Sensibilidade:";
                    txtSensValor1.Text = "1.6848";
                    txtResolucao1.Text = "Resolução: 1920x1080";
                    txtProporcao1.Text = "Proporção: 16:9";
                    txtPolegadas1.Text = "Polegadas do Monitor: 34\"";
                    switchLock1 = true;
                    break;
                case 2:
                    pictureBox2.Image = bmpCs;
                    txtDpi1.Text = "DPI do Mouse: 800";
                    txtSens1.Text = "Sensibilidade:";
                    txtSensValor1.Text = "1.5544";
                    txtResolucao1.Text = "Resolução: 1920x1080";
                    txtProporcao1.Text = "Proporção: 16:9";
                    txtPolegadas1.Text = "Polegadas do Monitor: 34\"";
                    switchLock1 = true;
                    break;
                case 3:
                    pictureBox2.Image = bmpPortal;
                    txtDpi1.Text = "DPI do Mouse: 800";
                    txtSens1.Text = "Sensibilidade:";
                    txtSensValor1.Text = "1.55444";
                    txtResolucao1.Text = "Resolução: 1920x1080";
                    txtProporcao1.Text = "Proporção: 16:9";
                    txtPolegadas1.Text = "Polegadas do Monitor: 34\"";
                    switchLock1 = true;
                    break;
                case 4:
                    pictureBox2.Image = bmpRainbow;
                    txtDpi1.Text = "DPI do Mouse: 800";
                    txtSens1.Text = "Sensibilidade:";
                    txtSensValor1.Text = "0.008443";
                    txtResolucao1.Text = "Resolução: 1920x1080";
                    txtProporcao1.Text = "Proporção: 16:9";
                    txtPolegadas1.Text = "Polegadas do Monitor: 34\"";
                    switchLock1 = true;
                    break;
            }
            if (switchLock1 == true && switchLock2 == true)
                button1.BackColor = Color.FromArgb(46, 43, 194);
        }

        private void comboBoxControl2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxControl2.SelectedIndex)
            {
                case 0:
                    pictureBox3.Image = bmpApex;
                    txtDpi2.Text = "DPI do Mouse: 800";
                    txtSens2.Text = "Sensibilidade:";
                    txtSensValor2.Text = "1.5";
                    txtResolucao2.Text = "Resolução: 1920x1080";
                    txtProporcao2.Text = "Proporção: 16:9";
                    txtPolegadas2.Text = "Polegadas do Monitor: 34\"";
                    switchLock2 = true;
                    break;
                case 1:
                    pictureBox3.Image = bmpMwiii;
                    txtDpi2.Text = "DPI do Mouse: 800";
                    txtSens2.Text = "Sensibilidade:";
                    txtSensValor2.Text = "2.6448";
                    txtResolucao2.Text = "Resolução: 1920x1080";
                    txtProporcao2.Text = "Proporção: 16:9";
                    txtPolegadas2.Text = "Polegadas do Monitor: 34\"";
                    switchLock2 = true;
                    break;
                case 2:
                    pictureBox3.Image = bmpCs;
                    txtDpi2.Text = "DPI do Mouse: 800";
                    txtSens2.Text = "Sensibilidade:";
                    txtSensValor2.Text = "0.246815";
                    txtResolucao2.Text = "Resolução: 1920x1080";
                    txtProporcao2.Text = "Proporção: 16:9";
                    txtPolegadas2.Text = "Polegadas do Monitor: 34\"";
                    switchLock2 = true;
                    break;
                case 3:
                    pictureBox3.Image = bmpPortal;
                    txtDpi2.Text = "DPI do Mouse: 800";
                    txtSens2.Text = "Sensibilidade:";
                    txtSensValor2.Text = "1.5651";
                    txtResolucao2.Text = "Resolução: 1920x1080";
                    txtProporcao2.Text = "Proporção: 16:9";
                    txtPolegadas2.Text = "Polegadas do Monitor: 34\"";
                    switchLock2 = true;
                    break;
                case 4:
                    pictureBox3.Image = bmpRainbow;
                    txtDpi2.Text = "DPI do Mouse: 800";
                    txtSens2.Text = "Sensibilidade:";
                    txtSensValor2.Text = "0.002304";
                    txtResolucao2.Text = "Resolução: 1920x1080";
                    txtProporcao2.Text = "Proporção: 16:9";
                    txtPolegadas2.Text = "Polegadas do Monitor: 34\"";
                    switchLock2 = true;
                    break;
            }
            if (switchLock1 == true && switchLock2 == true)
                button1.BackColor = Color.FromArgb(46, 43, 194);
        }

        public void Alert(string msg)
        {
            SensAplicadaAlert frm = new SensAplicadaAlert();
            frm.showAlert(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (switchLock1 == true && switchLock2 == true)
            {
                travarBtn = true;
            }
            if (travarBtn)
            {
                txtSensValor2.ForeColor = Color.Lime;
                this.Alert("Conversão Aplicada");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x;
            x = comboBoxControl1.SelectedIndex;
            comboBoxControl1.SelectedIndex = comboBoxControl2.SelectedIndex;
            comboBoxControl2.SelectedIndex = x;
        }
    }
}
