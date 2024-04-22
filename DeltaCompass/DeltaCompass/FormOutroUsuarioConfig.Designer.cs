namespace DeltaCompass
{
    partial class FormOutroUsuarioConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            label2 = new Label();
            txtSens1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 17);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 34);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI Semilight", 13F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 5);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 20;
            label1.Text = "Nome do Jogo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close_delta2;
            pictureBox1.Location = new Point(473, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 43, 194);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 36);
            panel2.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(189, 190);
            panel5.Name = "panel5";
            panel5.Size = new Size(139, 27);
            panel5.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 43, 194);
            button1.Font = new Font("Nirmala UI Semilight", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-5, -15);
            button1.Name = "button1";
            button1.Size = new Size(156, 55);
            button1.TabIndex = 16;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(129, 100);
            label2.Name = "label2";
            label2.Size = new Size(33, 18);
            label2.TabIndex = 28;
            label2.Text = "2.0";
            // 
            // txtSens1
            // 
            txtSens1.AutoSize = true;
            txtSens1.Font = new Font("Verdana", 11F);
            txtSens1.ForeColor = SystemColors.Control;
            txtSens1.Location = new Point(24, 100);
            txtSens1.Name = "txtSens1";
            txtSens1.Size = new Size(108, 18);
            txtSens1.TabIndex = 27;
            txtSens1.Text = "Sensibilidade:";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(46, 43, 194);
            label5.Location = new Point(257, 57);
            label5.Name = "label5";
            label5.Size = new Size(2, 120);
            label5.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(24, 67);
            label6.Name = "label6";
            label6.Size = new Size(224, 18);
            label6.TabIndex = 32;
            label6.Text = "Configuração do Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(446, 100);
            label3.Name = "label3";
            label3.Size = new Size(33, 18);
            label3.TabIndex = 34;
            label3.Text = "1.5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(336, 100);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 33;
            label4.Text = "Sensibilidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(316, 67);
            label7.Name = "label7";
            label7.Size = new Size(163, 18);
            label7.TabIndex = 35;
            label7.Text = "Sua Configuração";
            // 
            // FormOutroUsuarioConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(516, 241);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtSens1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOutroUsuarioConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormOutroUsuarioConfig";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel5;
        private Button button1;
        private Label label2;
        private Label txtSens1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label7;
    }
}