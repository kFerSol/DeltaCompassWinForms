namespace DeltaCompass
{
    partial class FormVisualizarConfiguracao
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
            panel5 = new Panel();
            button1 = new Button();
            txtSens1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 17);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 34);
            panel1.TabIndex = 0;
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
            pictureBox1.Location = new Point(372, 0);
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
            panel5.Location = new Point(137, 145);
            panel5.Name = "panel5";
            panel5.Size = new Size(139, 27);
            panel5.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 43, 194);
            button1.Font = new Font("Nirmala UI Semilight", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-6, -15);
            button1.Name = "button1";
            button1.Size = new Size(156, 55);
            button1.TabIndex = 16;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = false;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // txtSens1
            // 
            txtSens1.AutoSize = true;
            txtSens1.Font = new Font("Verdana", 11F);
            txtSens1.ForeColor = SystemColors.Control;
            txtSens1.Location = new Point(92, 92);
            txtSens1.Name = "txtSens1";
            txtSens1.Size = new Size(108, 18);
            txtSens1.TabIndex = 19;
            txtSens1.Text = "Sensibilidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(194, 92);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 20;
            label2.Text = "1.5544";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.trash_delta;
            pictureBox2.Location = new Point(270, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.editbox_delta;
            pictureBox3.Location = new Point(319, 85);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 43, 194);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 36);
            panel2.TabIndex = 23;
            // 
            // FormVisualizarConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(416, 195);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(txtSens1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVisualizarConfiguracao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormVisualizarConfiguracao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button button1;
        private Label label1;
        private Label txtSens1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
    }
}