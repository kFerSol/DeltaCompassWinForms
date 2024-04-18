namespace DeltaCompass
{
    partial class PaginaBusca
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
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            roundControl1 = new RoundControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundControl2 = new RoundControl();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 42);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 28, 28);
            button1.Font = new Font("Poppins", 12F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-37, -6);
            button1.Name = "button1";
            button1.Size = new Size(132, 65);
            button1.TabIndex = 11;
            button1.Text = "Clã";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(101, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(76, 42);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(28, 28, 28);
            button2.Font = new Font("Poppins", 12F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(-31, -6);
            button2.Name = "button2";
            button2.Size = new Size(132, 65);
            button2.TabIndex = 11;
            button2.Text = "Usuário";
            button2.UseVisualStyleBackColor = false;
            // 
            // roundControl1
            // 
            roundControl1.BackgroundColor = Color.FromArgb(39, 39, 39);
            roundControl1.BorderColor = Color.FromArgb(46, 43, 194);
            roundControl1.BorderWidth = 5F;
            roundControl1.Location = new Point(56, 77);
            roundControl1.Name = "roundControl1";
            roundControl1.Radius = 10;
            roundControl1.Size = new Size(463, 352);
            roundControl1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(39, 39, 39);
            flowLayoutPanel1.Location = new Point(70, 91);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(436, 323);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // roundControl2
            // 
            roundControl2.BackgroundColor = Color.FromArgb(39, 39, 39);
            roundControl2.BorderColor = Color.FromArgb(46, 43, 194);
            roundControl2.BorderWidth = 5F;
            roundControl2.Location = new Point(537, 77);
            roundControl2.Name = "roundControl2";
            roundControl2.Radius = 10;
            roundControl2.Size = new Size(196, 190);
            roundControl2.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(39, 39, 39);
            label8.Font = new Font("Poppins", 9F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(552, 99);
            label8.Name = "label8";
            label8.Size = new Size(137, 22);
            label8.TabIndex = 15;
            label8.Text = "Histórico de Pesquisa";
            // 
            // PaginaBusca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(753, 453);
            Controls.Add(label8);
            Controls.Add(roundControl2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(roundControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaginaBusca";
            Text = "PaginaBusca";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private RoundControl roundControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RoundControl roundControl2;
        private Label label8;
    }
}