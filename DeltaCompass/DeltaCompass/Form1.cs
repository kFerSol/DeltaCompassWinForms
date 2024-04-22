using System;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeltaCompass
{
    public partial class FormPrincipal : Form
    {
        PaginaPerfil? perfil;
        PaginaSuporte? suporte;
        PaginaConfiguracao? configuracao;
        PaginaCriacaoCla? criacaoCla;
        PaginaPerfilCla? cla;
        PaginaOutroPerfil? outroPerfil;
        PaginaConversao? conversao;
        PaginaBusca? busca;

        public FormPrincipal()
        {
            InitializeComponent();
            titleBarControl1.MinimizarPagina += TitleBarControl1_MinimizarPagina;
            titleBarControl1.MaximizarPagina += TitleBarControl1_MaximizarPagina;
            this.IsMdiContainer = true;
            MdiPropriedades();
            criacaoCla = new PaginaCriacaoCla();
            criacaoCla.CriarClaClicked += PaginaCriacaoCla_CriarClaClicked;
        }

        private void PaginaCriacaoCla_CriarClaClicked(object? sender, EventArgs e)
        {
            cla = Application.OpenForms.OfType<PaginaPerfilCla>().FirstOrDefault();

            if (cla == null)
            {
                cla = new PaginaPerfilCla();
                cla.MdiParent = this;
                cla.Show();
            }
            else
            {
                cla.Activate();
            }
            criacaoCla.Close();
        }

        bool expandirSidebar = true;

        private void MdiPropriedades()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(28, 28, 28);
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

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (expandirSidebar)
            {
                sidebarFlowPanel.Width -= 10;
                sidebarFundo.Width = sidebarFlowPanel.Width + 2;
                if (sidebarFlowPanel.Width <= 46)
                {
                    expandirSidebar = false;
                    sidebarTimer.Stop();
                    btnSidebar.Visible = true;
                }
            }
            else
            {
                sidebarFlowPanel.Width += 10;
                sidebarFundo.Width = sidebarFlowPanel.Width + 2;
                btnSidebar.Visible = false;
                if (sidebarFlowPanel.Width >= 272)
                {
                    expandirSidebar = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (perfil == null)
            {
                perfil = new PaginaPerfil();
                perfil.FormClosed += Perfil_FormClosed;
                perfil.MdiParent = this;
                perfil.Dock = DockStyle.Fill;
                perfil.Show();
            }
            else
            {
                perfil.Activate();
            }

        }

        private void Perfil_FormClosed(object? sender, FormClosedEventArgs e)
        {
            perfil = null;
        }


        private void btnConversao_Click(object sender, EventArgs e)
        {
            if (conversao == null)
            {
                conversao = new PaginaConversao();
                conversao.FormClosed += Conversao_FormClosed;
                conversao.MdiParent = this;
                conversao.Dock = DockStyle.Fill;
                conversao.Show();
            }
            else
            {
                conversao.Activate();
            }
        }

        private void Conversao_FormClosed(object? sender, FormClosedEventArgs e)
        {
            conversao = null;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (busca == null)
            {
                busca = new PaginaBusca();
                busca.FormClosed += Busca_FormClosed;
                busca.MdiParent = this;
                busca.Dock = DockStyle.Fill;
                busca.Show();
            }
            else
            {
                busca.Activate();
            }
        }

        private void Busca_FormClosed(object? sender, FormClosedEventArgs e)
        {
            busca = null;
        }

        private void btnCla_Click(object sender, EventArgs e)
        {
            if (criacaoCla != null)
            {
                criacaoCla = new PaginaCriacaoCla();
                criacaoCla.FormClosed += CriacaoCla_FormClosed;
                criacaoCla.MdiParent = this;
                criacaoCla.Dock = DockStyle.Fill;
                criacaoCla.Show();
            }
            else
            {
                criacaoCla.Activate();
            }
        }

        private void CriacaoCla_FormClosed(object? sender, FormClosedEventArgs e)
        {
            criacaoCla = null;
        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            if (suporte == null)
            {
                suporte = new PaginaSuporte();
                suporte.FormClosed += Suporte_FormClosed;
                suporte.MdiParent = this;
                suporte.Dock = DockStyle.Fill;
                suporte.Show();
            }
            else
            {
                suporte.Activate();
            }
        }

        private void Suporte_FormClosed(object? sender, FormClosedEventArgs e)
        {
            suporte = null;
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            if (configuracao == null)
            {
                configuracao = new PaginaConfiguracao();
                configuracao.FormClosed += Configuracao_FormClosed;
                configuracao.MdiParent = this;
                configuracao.Dock = DockStyle.Fill;
                configuracao.Show();
            }
            else
            {
                configuracao.Activate();
            }
        }

        private void Configuracao_FormClosed(object? sender, FormClosedEventArgs e)
        {
            configuracao = null;
        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }

        private void btnConversao_MouseEnter(object sender, EventArgs e)
        {
            btnConversao.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void btnConversao_MouseLeave(object sender, EventArgs e)
        {
            btnConversao.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }

        private void btnBusca_MouseEnter(object sender, EventArgs e)
        {
            btnBusca.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void btnBusca_MouseLeave(object sender, EventArgs e)
        {
            btnBusca.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }

        private void btnCla_MouseEnter(object sender, EventArgs e)
        {
            btnCla.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void btnCla_MouseLeave(object sender, EventArgs e)
        {
            btnCla.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }

        private void btnSuporte_MouseEnter(object sender, EventArgs e)
        {
            btnSuporte.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void btnSuporte_MouseLeave(object sender, EventArgs e)
        {
            btnSuporte.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }

        private void btnConfiguracao_MouseEnter(object sender, EventArgs e)
        {
            btnConfiguracao.BackColor = Color.FromArgb(59, 59, 59);
            this.Cursor = Cursors.Hand;
        }

        private void btnConfiguracao_MouseLeave(object sender, EventArgs e)
        {
            btnConfiguracao.BackColor = Color.FromArgb(28, 28, 28);
            this.Cursor = Cursors.Default;
        }
    }
}
