namespace DeltaCompass
{
    partial class SidebarControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            sidebarBtnAbrir = new PictureBox();
            label2 = new Label();
            sidebarBtnFechar = new Button();
            panel3 = new Panel();
            perfilBtn = new Button();
            panel5 = new Panel();
            ConversaoBtn = new Button();
            panel4 = new Panel();
            buscarUsuarioBtn = new Button();
            panel6 = new Panel();
            claBtn = new Button();
            panel7 = new Panel();
            label3 = new Label();
            suporteBtn = new Button();
            panel8 = new Panel();
            configuracaoBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarBtnAbrir).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel2);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(272, 456);
            sidebar.MinimumSize = new Size(48, 456);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(272, 456);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(sidebarBtnAbrir);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(sidebarBtnFechar);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 61);
            panel1.TabIndex = 0;
            // 
            // sidebarBtnAbrir
            // 
            sidebarBtnAbrir.Image = Properties.Resources.delta_logo;
            sidebarBtnAbrir.Location = new Point(3, 17);
            sidebarBtnAbrir.Name = "sidebarBtnAbrir";
            sidebarBtnAbrir.Size = new Size(42, 40);
            sidebarBtnAbrir.TabIndex = 4;
            sidebarBtnAbrir.TabStop = false;
            sidebarBtnAbrir.Visible = false;
            sidebarBtnAbrir.Click += deltaLogo_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(46, 43, 194);
            label2.Location = new Point(43, 58);
            label2.Name = "label2";
            label2.Size = new Size(187, 2);
            label2.TabIndex = 3;
            // 
            // sidebarBtnFechar
            // 
            sidebarBtnFechar.BackColor = Color.FromArgb(28, 28, 28);
            sidebarBtnFechar.Font = new Font("ModeSeven", 12F);
            sidebarBtnFechar.ForeColor = SystemColors.Control;
            sidebarBtnFechar.Image = Properties.Resources.delta_logo;
            sidebarBtnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            sidebarBtnFechar.Location = new Point(-18, -15);
            sidebarBtnFechar.Name = "sidebarBtnFechar";
            sidebarBtnFechar.Padding = new Padding(60, 0, 0, 0);
            sidebarBtnFechar.Size = new Size(276, 102);
            sidebarBtnFechar.TabIndex = 2;
            sidebarBtnFechar.Text = "   Delta Compass";
            sidebarBtnFechar.TextAlign = ContentAlignment.MiddleLeft;
            sidebarBtnFechar.UseVisualStyleBackColor = false;
            sidebarBtnFechar.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(perfilBtn);
            panel3.Location = new Point(3, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 55);
            panel3.TabIndex = 3;
            // 
            // perfilBtn
            // 
            perfilBtn.BackColor = Color.FromArgb(28, 28, 28);
            perfilBtn.Font = new Font("Poppins", 11F);
            perfilBtn.ForeColor = SystemColors.Control;
            perfilBtn.Image = Properties.Resources.user_delta;
            perfilBtn.ImageAlign = ContentAlignment.MiddleLeft;
            perfilBtn.Location = new Point(-18, -4);
            perfilBtn.Name = "perfilBtn";
            perfilBtn.Padding = new Padding(20, 0, 0, 0);
            perfilBtn.Size = new Size(287, 69);
            perfilBtn.TabIndex = 2;
            perfilBtn.Text = "         Perfil";
            perfilBtn.TextAlign = ContentAlignment.MiddleLeft;
            perfilBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(ConversaoBtn);
            panel5.Location = new Point(3, 131);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 55);
            panel5.TabIndex = 5;
            // 
            // ConversaoBtn
            // 
            ConversaoBtn.BackColor = Color.FromArgb(28, 28, 28);
            ConversaoBtn.Font = new Font("Poppins", 11F);
            ConversaoBtn.ForeColor = SystemColors.Control;
            ConversaoBtn.Image = Properties.Resources.sync_delta;
            ConversaoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConversaoBtn.Location = new Point(-18, -4);
            ConversaoBtn.Name = "ConversaoBtn";
            ConversaoBtn.Padding = new Padding(20, 0, 0, 0);
            ConversaoBtn.Size = new Size(287, 69);
            ConversaoBtn.TabIndex = 2;
            ConversaoBtn.Text = "         Conversão Automatizada";
            ConversaoBtn.TextAlign = ContentAlignment.MiddleLeft;
            ConversaoBtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(buscarUsuarioBtn);
            panel4.Location = new Point(3, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 55);
            panel4.TabIndex = 4;
            // 
            // buscarUsuarioBtn
            // 
            buscarUsuarioBtn.BackColor = Color.FromArgb(28, 28, 28);
            buscarUsuarioBtn.Font = new Font("Poppins", 11F);
            buscarUsuarioBtn.ForeColor = SystemColors.Control;
            buscarUsuarioBtn.Image = Properties.Resources.users_delta;
            buscarUsuarioBtn.ImageAlign = ContentAlignment.MiddleLeft;
            buscarUsuarioBtn.Location = new Point(-18, -4);
            buscarUsuarioBtn.Name = "buscarUsuarioBtn";
            buscarUsuarioBtn.Padding = new Padding(20, 0, 0, 0);
            buscarUsuarioBtn.Size = new Size(287, 69);
            buscarUsuarioBtn.TabIndex = 2;
            buscarUsuarioBtn.Text = "         Buscar Usuários";
            buscarUsuarioBtn.TextAlign = ContentAlignment.MiddleLeft;
            buscarUsuarioBtn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(claBtn);
            panel6.Location = new Point(3, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 55);
            panel6.TabIndex = 4;
            // 
            // claBtn
            // 
            claBtn.BackColor = Color.FromArgb(28, 28, 28);
            claBtn.Font = new Font("Poppins", 11F);
            claBtn.ForeColor = SystemColors.Control;
            claBtn.Image = Properties.Resources.shield_delta;
            claBtn.ImageAlign = ContentAlignment.MiddleLeft;
            claBtn.Location = new Point(-18, -4);
            claBtn.Name = "claBtn";
            claBtn.Padding = new Padding(20, 0, 0, 0);
            claBtn.Size = new Size(287, 69);
            claBtn.TabIndex = 2;
            claBtn.Text = "         Clã";
            claBtn.TextAlign = ContentAlignment.MiddleLeft;
            claBtn.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(label3);
            panel7.Controls.Add(suporteBtn);
            panel7.Location = new Point(3, 314);
            panel7.Name = "panel7";
            panel7.Size = new Size(252, 91);
            panel7.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(0, 32);
            label3.Name = "label3";
            label3.Size = new Size(252, 23);
            label3.TabIndex = 1;
            // 
            // suporteBtn
            // 
            suporteBtn.BackColor = Color.FromArgb(28, 28, 28);
            suporteBtn.Font = new Font("Poppins", 11F);
            suporteBtn.ForeColor = SystemColors.Control;
            suporteBtn.Image = Properties.Resources.message_delta;
            suporteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            suporteBtn.Location = new Point(-19, 39);
            suporteBtn.Name = "suporteBtn";
            suporteBtn.Padding = new Padding(20, 0, 0, 0);
            suporteBtn.Size = new Size(276, 60);
            suporteBtn.TabIndex = 0;
            suporteBtn.Text = "          Fale Conosco";
            suporteBtn.TextAlign = ContentAlignment.MiddleLeft;
            suporteBtn.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(configuracaoBtn);
            panel8.Location = new Point(3, 411);
            panel8.Name = "panel8";
            panel8.Size = new Size(252, 40);
            panel8.TabIndex = 7;
            // 
            // configuracaoBtn
            // 
            configuracaoBtn.BackColor = Color.FromArgb(28, 28, 28);
            configuracaoBtn.Font = new Font("Poppins", 11F);
            configuracaoBtn.ForeColor = SystemColors.Control;
            configuracaoBtn.Image = Properties.Resources.slider_delta;
            configuracaoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            configuracaoBtn.Location = new Point(-21, -11);
            configuracaoBtn.Name = "configuracaoBtn";
            configuracaoBtn.Padding = new Padding(20, 0, 0, 0);
            configuracaoBtn.Size = new Size(290, 60);
            configuracaoBtn.TabIndex = 0;
            configuracaoBtn.Text = "          Configurações";
            configuracaoBtn.TextAlign = ContentAlignment.MiddleLeft;
            configuracaoBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(261, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 453);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(46, 43, 194);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(2, 454);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // SidebarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            Controls.Add(sidebar);
            MaximumSize = new Size(272, 456);
            MinimumSize = new Size(48, 456);
            Name = "SidebarControl";
            Size = new Size(272, 456);
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sidebarBtnAbrir).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button sidebarBtnFechar;
        private Label label2;
        private Panel panel3;
        private Button perfilBtn;
        private Panel panel5;
        private Button ConversaoBtn;
        private Panel panel4;
        private Button buscarUsuarioBtn;
        private Panel panel6;
        private Button claBtn;
        private Panel panel7;
        private Button suporteBtn;
        private Label label3;
        private Panel panel8;
        private Button configuracaoBtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox sidebarBtnAbrir;
    }
}
