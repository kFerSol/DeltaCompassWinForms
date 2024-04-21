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

        bool btnSelecionado = true;

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (btnSelecionado)
            {
                label1.Visible = true;
                label3.Visible = false;
            }
        }

        private void btnBuscarCla_Click(object sender, EventArgs e)
        {
            if (btnSelecionado)
            {
                label1.Visible = false;
                label3.Visible = true;
            }
        }

        private void btnBuscarCla_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarCla.ForeColor = Color.FromArgb(162, 162, 162);
        }

        private void btnBuscarCla_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarCla.ForeColor = Color.White;
        }

        private void btnBuscarUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarUsuario.ForeColor = Color.FromArgb(162, 162, 162);
        }

        private void btnBuscarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarUsuario.ForeColor = Color.White;
        }
    }
}
