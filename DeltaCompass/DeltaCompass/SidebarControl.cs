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
    public partial class SidebarControl : UserControl
    {
        public SidebarControl()
        {
            InitializeComponent();
        }

        bool expandirSidebar = true;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (expandirSidebar)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 48)
                {
                    expandirSidebar = false;
                    sidebarTimer.Stop();
                    sidebarBtnAbrir.Visible = true;
                }
            }
            else
            {
                sidebar.Width += 10;
                sidebarBtnAbrir.Visible = false;
                if (sidebar.Width >= 272)
                {
                    expandirSidebar = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void deltaLogo_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            perfilBtn.BackColor = Color.FromArgb(0, 46, 43, 194);
        }
    }
}
