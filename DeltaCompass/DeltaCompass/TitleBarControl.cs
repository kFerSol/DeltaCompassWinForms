using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaCompass
{
    public partial class TitleBarControl : UserControl
    {
        public FormWindowState WindowState { get; internal set; }

        public event EventHandler MinimizarPagina;
        public event EventHandler MaximizarPagina;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public TitleBarControl()
        {
            InitializeComponent();
            MouseDown += TitleBarControl_MouseDown;
            MouseMove += TitleBarControl_MouseMove;
            MouseUp += TitleBarControl_MouseUp;
        }

        protected virtual void OnMinimizar(EventArgs e)
        {
            MinimizarPagina?.Invoke(this, e);
        }

        protected virtual void OnMaximizar(EventArgs e)
        {
            MaximizarPagina?.Invoke(this, e);
        }

        private void fecharBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharBtn_MouseEnter(object sender, EventArgs e)
        {
            fecharBtn.BackColor = Color.FromArgb(46, 43, 194);
        }

        private void fecharBtn_MouseLeave(object sender, EventArgs e)
        {
            fecharBtn.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void maximizarBtn_MouseEnter(object sender, EventArgs e)
        {
            maximizarBtn.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void maximizarBtn_MouseLeave(object sender, EventArgs e)
        {
            maximizarBtn.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void minimizarBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizarBtn.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void minimizarBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizarBtn.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void maximizarBtn_Click(object sender, EventArgs e)
        {
            OnMaximizar(EventArgs.Empty);
        }

        private void minimizarBtn_Click(object sender, EventArgs e)
        {
            OnMinimizar(EventArgs.Empty);
        }

        private void TitleBarControl_Load(object sender, EventArgs e)
        {

        }

        private void TitleBarControl_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void TitleBarControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleBarControl_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
