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
    public partial class PaginaPerfil : Form
    {
        public static PaginaPerfil instance;

        public PaginaPerfil()
        {
            InitializeComponent();
            instance = this;
        }

        private void PaginaPerfil_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        Bitmap olho = Properties.Resources.eye_delta;
        Bitmap apex = Properties.Resources.apex_logo;
        Bitmap cs = Properties.Resources.cslogo;

        private void roundControl2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = olho;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = apex;
            this.Cursor = Cursors.Default;
        }

        private void roundControl2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = apex;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = olho;
            this.Cursor = Cursors.Hand;
        }

        private void roundControl3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = olho;
            this.Cursor = Cursors.Hand;
        }

        private void roundControl3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = cs;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = olho;
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = cs;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormVisualizarConfiguracao fvc = new FormVisualizarConfiguracao();
            fvc.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormOutroUsuarioConfig fouc = new FormOutroUsuarioConfig();
            fouc.ShowDialog();
        }

        private void roundControl2_MouseClick(object sender, MouseEventArgs e)
        {
            FormOutroUsuarioConfig fouc = new FormOutroUsuarioConfig();
            fouc.ShowDialog();
        }

        private void roundControl3_MouseClick(object sender, MouseEventArgs e)
        {
            FormVisualizarConfiguracao fvc = new FormVisualizarConfiguracao();
            fvc.ShowDialog();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAdicionarSensibilidade fas = new FormAdicionarSensibilidade();
            fas.ShowDialog();
        }

        private void roundControl4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void roundControl4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void roundControl4_MouseClick(object sender, MouseEventArgs e)
        {
            FormAdicionarSensibilidade fas = new FormAdicionarSensibilidade();
            fas.ShowDialog();
        }
    }
}
