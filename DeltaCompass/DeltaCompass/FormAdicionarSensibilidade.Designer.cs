namespace DeltaCompass
{
    partial class FormAdicionarSensibilidade
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
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            button1 = new Button();
            comboBoxControl1 = new ComboBoxControl();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 43, 194);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 36);
            panel2.TabIndex = 26;
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
            panel1.Size = new Size(404, 34);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI Semilight", 13F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 20;
            label1.Text = "Salvar Configuração";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close_delta2;
            pictureBox1.Location = new Point(361, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(133, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(139, 27);
            panel5.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 43, 194);
            button1.Font = new Font("Nirmala UI Semilight", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-8, -15);
            button1.Name = "button1";
            button1.Size = new Size(156, 55);
            button1.TabIndex = 16;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // comboBoxControl1
            // 
            comboBoxControl1.BackColor = Color.WhiteSmoke;
            comboBoxControl1.BorderColor = Color.FromArgb(46, 43, 194);
            comboBoxControl1.BorderSize = 1;
            comboBoxControl1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxControl1.Font = new Font("Segoe UI", 10F);
            comboBoxControl1.ForeColor = SystemColors.ControlText;
            comboBoxControl1.IconColor = Color.FromArgb(46, 43, 194);
            comboBoxControl1.Items.AddRange(new object[] { "Apex Legends", "Call of Duty MWIII", "Counter Strike 2", "Portal", "Rainbow Six Siege" });
            comboBoxControl1.ListBackColor = Color.FromArgb(230, 228, 245);
            comboBoxControl1.ListTextColor = Color.DimGray;
            comboBoxControl1.Location = new Point(92, 205);
            comboBoxControl1.MinimumSize = new Size(200, 30);
            comboBoxControl1.Name = "comboBoxControl1";
            comboBoxControl1.Padding = new Padding(1);
            comboBoxControl1.Size = new Size(221, 30);
            comboBoxControl1.TabIndex = 28;
            comboBoxControl1.Texts = "";
            comboBoxControl1.OnSelectedIndexChanged += comboBoxControl1_OnSelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.delta_logo1;
            pictureBox2.Location = new Point(116, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 43, 194);
            panel3.Location = new Point(113, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 151);
            panel3.TabIndex = 30;
            // 
            // FormAdicionarSensibilidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(404, 293);
            Controls.Add(pictureBox2);
            Controls.Add(comboBoxControl1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdicionarSensibilidade";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAdicionarSensibilidade";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button button1;
        private ComboBoxControl comboBoxControl1;
        private PictureBox pictureBox2;
        private Panel panel3;
    }
}