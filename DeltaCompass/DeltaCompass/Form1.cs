namespace DeltaCompass
{
    public partial class FormPaginaPerfil : Form
    {
        public FormPaginaPerfil()
        {
            InitializeComponent();
            InitializeSideBar();
            titleBarControl1.MinimizarPagina += TitleBarControl1_MinimizarPagina;
            titleBarControl1.MaximizarPagina += TitleBarControl1_MaximizarPagina;
            this.Resize += FormPaginaPerfil_Resize;
            sidebarControl1.conversaoAberta += SidebarControl1_ConversaoAberta;
        }

        private void SidebarControl1_ConversaoAberta(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InitializeSideBar()
        {
            sidebarControl1 = new SidebarControl();
            this.Controls.Add(sidebarControl1);
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

        private void FormPaginaPerfil_Load(object sender, EventArgs e)
        {

        }

        private void FormPaginaPerfil_Resize(object sender, EventArgs e)
        {
            sidebarControl1.Width = this.Width;
            sidebarControl1.Left = 0;
            sidebarControl1.Height = this.ClientSize.Height;
        }

        private void label16_Resize(object sender, EventArgs e)
        {

        }
    }
}
