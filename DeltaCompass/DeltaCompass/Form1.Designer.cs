namespace DeltaCompass
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            titleBarControl1 = new TitleBarControl();
            sidebarFundo = new Panel();
            sidebarFlowPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            btnSidebar = new PictureBox();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            btnPerfil = new Button();
            panel3 = new Panel();
            btnConversao = new Button();
            panel4 = new Panel();
            btnBusca = new Button();
            panel5 = new Panel();
            btnCla = new Button();
            panel6 = new Panel();
            panel8 = new Panel();
            btnSuporte = new Button();
            panel7 = new Panel();
            btnConfiguracao = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            sidebarFundo.SuspendLayout();
            sidebarFlowPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSidebar).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(17, 17, 17);
            titleBarControl1.Dock = DockStyle.Top;
            titleBarControl1.ForeColor = Color.CornflowerBlue;
            titleBarControl1.Location = new Point(0, 0);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Size = new Size(800, 30);
            titleBarControl1.TabIndex = 1;
            // 
            // sidebarFundo
            // 
            sidebarFundo.BackColor = Color.FromArgb(46, 43, 194);
            sidebarFundo.Controls.Add(sidebarFlowPanel);
            sidebarFundo.Dock = DockStyle.Left;
            sidebarFundo.Location = new Point(0, 30);
            sidebarFundo.MaximumSize = new Size(274, 456);
            sidebarFundo.MinimumSize = new Size(48, 456);
            sidebarFundo.Name = "sidebarFundo";
            sidebarFundo.Size = new Size(48, 456);
            sidebarFundo.TabIndex = 2;
            // 
            // sidebarFlowPanel
            // 
            sidebarFlowPanel.BackColor = Color.FromArgb(28, 28, 28);
            sidebarFlowPanel.Controls.Add(panel2);
            sidebarFlowPanel.Controls.Add(panel1);
            sidebarFlowPanel.Controls.Add(panel3);
            sidebarFlowPanel.Controls.Add(panel4);
            sidebarFlowPanel.Controls.Add(panel5);
            sidebarFlowPanel.Controls.Add(panel6);
            sidebarFlowPanel.Controls.Add(panel7);
            sidebarFlowPanel.Dock = DockStyle.Left;
            sidebarFlowPanel.Location = new Point(0, 0);
            sidebarFlowPanel.MaximumSize = new Size(272, 456);
            sidebarFlowPanel.MinimumSize = new Size(46, 456);
            sidebarFlowPanel.Name = "sidebarFlowPanel";
            sidebarFlowPanel.Size = new Size(46, 456);
            sidebarFlowPanel.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSidebar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 61);
            panel2.TabIndex = 4;
            // 
            // btnSidebar
            // 
            btnSidebar.Image = Properties.Resources.logo_delta1;
            btnSidebar.Location = new Point(2, 21);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(38, 36);
            btnSidebar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSidebar.TabIndex = 3;
            btnSidebar.TabStop = false;
            btnSidebar.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(46, 43, 194);
            label2.Location = new Point(46, 53);
            label2.Name = "label2";
            label2.Size = new Size(187, 2);
            label2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(28, 28, 28);
            button2.Font = new Font("Verdana", 11F);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.logo_delta1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-8, -13);
            button2.Name = "button2";
            button2.Padding = new Padding(60, 0, 0, 0);
            button2.Size = new Size(289, 88);
            button2.TabIndex = 0;
            button2.Text = "        Delta Compass";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPerfil);
            panel1.Location = new Point(3, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 40);
            panel1.TabIndex = 3;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(28, 28, 28);
            btnPerfil.Font = new Font("Verdana", 11F);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Image = Properties.Resources.user_delta;
            btnPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerfil.Location = new Point(-26, -13);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Padding = new Padding(25, 0, 0, 0);
            btnPerfil.Size = new Size(289, 69);
            btnPerfil.TabIndex = 0;
            btnPerfil.Text = "          Perfil";
            btnPerfil.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(btnPerfil, "Perfil do Usuário");
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            btnPerfil.MouseEnter += btnPerfil_MouseEnter;
            btnPerfil.MouseLeave += btnPerfil_MouseLeave;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnConversao);
            panel3.Location = new Point(3, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 40);
            panel3.TabIndex = 5;
            // 
            // btnConversao
            // 
            btnConversao.BackColor = Color.FromArgb(28, 28, 28);
            btnConversao.Font = new Font("Verdana", 11F);
            btnConversao.ForeColor = Color.White;
            btnConversao.Image = Properties.Resources.sync_delta;
            btnConversao.ImageAlign = ContentAlignment.MiddleLeft;
            btnConversao.Location = new Point(-26, -13);
            btnConversao.Name = "btnConversao";
            btnConversao.Padding = new Padding(25, 0, 0, 0);
            btnConversao.Size = new Size(289, 69);
            btnConversao.TabIndex = 0;
            btnConversao.Text = "          Conversão Automatizada";
            btnConversao.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(btnConversao, "Conversão de Sensibilidade");
            btnConversao.UseVisualStyleBackColor = false;
            btnConversao.Click += btnConversao_Click;
            btnConversao.MouseEnter += btnConversao_MouseEnter;
            btnConversao.MouseLeave += btnConversao_MouseLeave;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBusca);
            panel4.Location = new Point(3, 162);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 40);
            panel4.TabIndex = 6;
            // 
            // btnBusca
            // 
            btnBusca.BackColor = Color.FromArgb(28, 28, 28);
            btnBusca.Font = new Font("Verdana", 11F);
            btnBusca.ForeColor = Color.White;
            btnBusca.Image = Properties.Resources.users_delta;
            btnBusca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusca.Location = new Point(-26, -13);
            btnBusca.Name = "btnBusca";
            btnBusca.Padding = new Padding(25, 0, 0, 0);
            btnBusca.Size = new Size(289, 69);
            btnBusca.TabIndex = 0;
            btnBusca.Text = "          Buscar Usuários";
            btnBusca.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(btnBusca, "Buscar outros usuários");
            btnBusca.UseVisualStyleBackColor = false;
            btnBusca.Click += btnBusca_Click;
            btnBusca.MouseEnter += btnBusca_MouseEnter;
            btnBusca.MouseLeave += btnBusca_MouseLeave;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCla);
            panel5.Location = new Point(3, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(239, 40);
            panel5.TabIndex = 7;
            // 
            // btnCla
            // 
            btnCla.BackColor = Color.FromArgb(28, 28, 28);
            btnCla.Font = new Font("Verdana", 11F);
            btnCla.ForeColor = Color.White;
            btnCla.Image = Properties.Resources.shield_delta;
            btnCla.ImageAlign = ContentAlignment.MiddleLeft;
            btnCla.Location = new Point(-26, -13);
            btnCla.Name = "btnCla";
            btnCla.Padding = new Padding(25, 0, 0, 0);
            btnCla.Size = new Size(289, 69);
            btnCla.TabIndex = 0;
            btnCla.Text = "          Clã";
            btnCla.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(btnCla, "Criação de Clã");
            btnCla.UseVisualStyleBackColor = false;
            btnCla.Click += btnCla_Click;
            btnCla.MouseEnter += btnCla_MouseEnter;
            btnCla.MouseLeave += btnCla_MouseLeave;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(3, 254);
            panel6.Name = "panel6";
            panel6.Size = new Size(239, 129);
            panel6.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnSuporte);
            panel8.Location = new Point(0, 89);
            panel8.Name = "panel8";
            panel8.Size = new Size(239, 40);
            panel8.TabIndex = 4;
            // 
            // btnSuporte
            // 
            btnSuporte.BackColor = Color.FromArgb(28, 28, 28);
            btnSuporte.Font = new Font("Verdana", 11F);
            btnSuporte.ForeColor = Color.White;
            btnSuporte.Image = Properties.Resources.message_delta;
            btnSuporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuporte.Location = new Point(-26, -13);
            btnSuporte.Name = "btnSuporte";
            btnSuporte.Padding = new Padding(25, 0, 0, 0);
            btnSuporte.Size = new Size(289, 69);
            btnSuporte.TabIndex = 0;
            btnSuporte.Text = "          Fale Conosco";
            btnSuporte.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(btnSuporte, "Suporte");
            btnSuporte.UseVisualStyleBackColor = false;
            btnSuporte.Click += btnSuporte_Click;
            btnSuporte.MouseEnter += btnSuporte_MouseEnter;
            btnSuporte.MouseLeave += btnSuporte_MouseLeave;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnConfiguracao);
            panel7.Location = new Point(3, 389);
            panel7.Name = "panel7";
            panel7.Size = new Size(239, 40);
            panel7.TabIndex = 8;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.BackColor = Color.FromArgb(28, 28, 28);
            btnConfiguracao.Font = new Font("Verdana", 11F);
            btnConfiguracao.ForeColor = Color.White;
            btnConfiguracao.Image = Properties.Resources.slider_delta;
            btnConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracao.Location = new Point(-26, -13);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Padding = new Padding(25, 0, 0, 0);
            btnConfiguracao.Size = new Size(289, 69);
            btnConfiguracao.TabIndex = 0;
            btnConfiguracao.Text = "          Configurações";
            btnConfiguracao.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(btnConfiguracao, "Configurações");
            btnConfiguracao.UseVisualStyleBackColor = false;
            btnConfiguracao.Click += btnConfiguracao_Click;
            btnConfiguracao.MouseEnter += btnConfiguracao_MouseEnter;
            btnConfiguracao.MouseLeave += btnConfiguracao_MouseLeave;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(800, 486);
            Controls.Add(sidebarFundo);
            Controls.Add(titleBarControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(0, 486);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            sidebarFundo.ResumeLayout(false);
            sidebarFlowPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSidebar).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TitleBarControl titleBarControl1;
        private Panel sidebarFundo;
        private FlowLayoutPanel sidebarFlowPanel;
        private Panel panel1;
        private Button btnPerfil;
        private Panel panel2;
        private Button button2;
        private Label label2;
        private Panel panel3;
        private Button btnConversao;
        private Panel panel4;
        private Button btnBusca;
        private Panel panel5;
        private Button btnCla;
        private Panel panel6;
        private Panel panel8;
        private Button btnSuporte;
        private Panel panel7;
        private Button btnConfiguracao;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox btnSidebar;
        private ToolTip toolTip1;
    }
}
