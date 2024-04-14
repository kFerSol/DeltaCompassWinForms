namespace DeltaCompass
{
    public partial class FormPaginaPerfil : Form
    {
        public FormPaginaPerfil()
        {
            InitializeComponent();
            titleBarControl1.MinimizarPagina += TitleBarControl1_MinimizarPagina;
            titleBarControl1.MaximizarPagina += TitleBarControl1_MaximizarPagina;
            this.Resize += FormPaginaPerfil_Resize;
            sidebarControl1.conversaoAberta += SidebarControl1_ConversaoAberta;
        }

        private void SidebarControl1_ConversaoAberta(object? sender, EventArgs e)
        {
            
        }

        private void TitleBarControl1_MinimizarPagina(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBarControl1_MaximizarPagina(object? sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            if (this.Size == workingArea.Size && this.Location == workingArea.Location)
            {
                this.Size = new Size(800, 486);
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.Size = workingArea.Size;
                this.Location = workingArea.Location;
            }
        }

        private void FormPaginaPerfil_Resize(object sender, EventArgs e)
        {

        }

        private void roundControl1_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox4.Visible = true;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
           // pictureBox4.Visible = true;
        }

        private void roundControl1_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox4.Visible = false;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox4.Visible = false;
        }
    }
}
