namespace DeltaCompass
{
    partial class TitleBarControl
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
            panel1 = new Panel();
            fecharBtn = new Button();
            panel2 = new Panel();
            maximizarBtn = new Button();
            panel3 = new Panel();
            minimizarBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(fecharBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(756, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 30);
            panel1.TabIndex = 0;
            // 
            // fecharBtn
            // 
            fecharBtn.BackColor = Color.FromArgb(28, 28, 28);
            fecharBtn.Image = Properties.Resources.close_delta1;
            fecharBtn.Location = new Point(-15, -8);
            fecharBtn.Name = "fecharBtn";
            fecharBtn.Size = new Size(75, 47);
            fecharBtn.TabIndex = 1;
            fecharBtn.UseVisualStyleBackColor = false;
            fecharBtn.Click += fecharBtn_Click;
            fecharBtn.MouseEnter += fecharBtn_MouseEnter;
            fecharBtn.MouseLeave += fecharBtn_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(maximizarBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(712, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(44, 30);
            panel2.TabIndex = 1;
            // 
            // maximizarBtn
            // 
            maximizarBtn.BackColor = Color.FromArgb(28, 28, 28);
            maximizarBtn.Image = Properties.Resources.square_delta;
            maximizarBtn.Location = new Point(-15, -8);
            maximizarBtn.Name = "maximizarBtn";
            maximizarBtn.Size = new Size(75, 47);
            maximizarBtn.TabIndex = 1;
            maximizarBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(minimizarBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(668, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 30);
            panel3.TabIndex = 2;
            // 
            // minimizarBtn
            // 
            minimizarBtn.BackColor = Color.FromArgb(28, 28, 28);
            minimizarBtn.Image = Properties.Resources.minus_delta;
            minimizarBtn.Location = new Point(-15, -8);
            minimizarBtn.Name = "minimizarBtn";
            minimizarBtn.Size = new Size(75, 47);
            minimizarBtn.TabIndex = 1;
            minimizarBtn.UseVisualStyleBackColor = false;
            // 
            // TitleBarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.CornflowerBlue;
            Name = "TitleBarControl";
            Size = new Size(800, 30);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button fecharBtn;
        private Panel panel2;
        private Button maximizarBtn;
        private Panel panel3;
        private Button minimizarBtn;
    }
}
