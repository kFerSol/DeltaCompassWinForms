namespace DeltaCompass
{
    partial class SensAplicadaAlert
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 58);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close_delta2;
            pictureBox1.Location = new Point(190, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI Semilight", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 0;
            label1.Text = "Conversão Aplicada.";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SensAplicadaAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 43, 194);
            ClientSize = new Size(232, 61);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SensAplicadaAlert";
            Text = "SensAplicadaAlert";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}