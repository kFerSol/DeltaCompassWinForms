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
            sidebar.Width = 272;
            this.Width = sidebar.Width;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm.Width > 1000 && sidebar.Width == 272)
            {

            }
            else
            {
                if (expandirSidebar)
                {
                    sidebar.Width -= 10;
                    this.Width = sidebar.Width;
                    if (sidebar.Width <= 48)
                    {
                        expandirSidebar = false;
                        sidebarTimer.Stop();
                        sidebarBtnAbrir.Visible = true;
                        label2.Visible = false;
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    this.Width = sidebar.Width;
                    sidebarBtnAbrir.Visible = false;
                    label2.Visible = true;
                    if (sidebar.Width >= 272)
                    {
                        expandirSidebar = true;
                        sidebarTimer.Stop();
                    }
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

        private void SidebarControl_Resize(object sender, EventArgs e)
        {

        }

        public event EventHandler conversaoAberta;

        private void ConversaoAberta(EventArgs e)
        {
            EventHandler handler = conversaoAberta;
            handler?.Invoke(this, e);
        }

        private void perfilBtn_Click(object sender, EventArgs e)
        {
            Form conversao = new Form();
            conversao.Show();
            ConversaoAberta(EventArgs.Empty);
        }
    }
}
