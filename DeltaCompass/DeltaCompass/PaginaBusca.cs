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
    public partial class PaginaBusca : Form
    {
        public PaginaBusca()
        {
            InitializeComponent();
        }

        private void PaginaBusca_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }


        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            label3.Visible = false;
        }

        private void btnBuscarCla_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = true;
        }

        private void btnBuscarCla_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarCla.ForeColor = Color.FromArgb(162, 162, 162);
            this.Cursor = Cursors.Hand;
        }

        private void btnBuscarCla_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarCla.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void btnBuscarUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarUsuario.ForeColor = Color.FromArgb(162, 162, 162);
            this.Cursor = Cursors.Hand;
        }

        private void btnBuscarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarUsuario.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(39, 39, 39);
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(39, 39, 39);
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }
    }
}
