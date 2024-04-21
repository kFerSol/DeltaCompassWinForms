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
            label3 = new Label();
            btnBuscarCla = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btnBuscarUsuario = new Button();
            roundControl1 = new RoundControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundControl2 = new RoundControl();
            label8 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBuscarCla);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 42);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(46, 43, 194);
            label3.Font = new Font("Poppins", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(4, 35);
            label3.Name = "label3";
            label3.Size = new Size(50, 2);
            label3.TabIndex = 24;
            label3.Visible = false;
            // 
            // btnBuscarCla
            // 
            btnBuscarCla.BackColor = Color.FromArgb(28, 28, 28);
            btnBuscarCla.Font = new Font("Poppins", 12F);
            btnBuscarCla.ForeColor = SystemColors.Control;
            btnBuscarCla.Location = new Point(-37, -6);
            btnBuscarCla.Name = "btnBuscarCla";
            btnBuscarCla.Size = new Size(132, 65);
            btnBuscarCla.TabIndex = 11;
            btnBuscarCla.Text = "Clã";
            btnBuscarCla.UseVisualStyleBackColor = false;
            btnBuscarCla.Click += btnBuscarCla_Click;
            btnBuscarCla.MouseEnter += btnBuscarCla_MouseEnter;
            btnBuscarCla.MouseLeave += btnBuscarCla_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnBuscarUsuario);
            panel2.Location = new Point(101, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(76, 42);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(46, 43, 194);
            label1.Font = new Font("Poppins", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(8, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 2);
            label1.TabIndex = 25;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(28, 28, 28);
            btnBuscarUsuario.Font = new Font("Poppins", 12F);
            btnBuscarUsuario.ForeColor = SystemColors.Control;
            btnBuscarUsuario.Location = new Point(-31, -6);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(132, 65);
            btnBuscarUsuario.TabIndex = 11;
            btnBuscarUsuario.Text = "Usuário";
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            btnBuscarUsuario.MouseEnter += btnBuscarUsuario_MouseEnter;
            btnBuscarUsuario.MouseLeave += btnBuscarUsuario_MouseLeave;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(29, 29, 29);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 10F);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(537, 24);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Jogo, usuário ou equipe...";
            textBox1.Size = new Size(185, 20);
            textBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.filter_deltaw;
            pictureBox1.Location = new Point(494, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(39, 39, 39);
            pictureBox2.Image = Properties.Resources.trash;
            pictureBox2.Location = new Point(690, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // PaginaBusca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(753, 453);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(roundControl2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(roundControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaginaBusca";
            Text = "PaginaBusca";
            Load += PaginaBusca_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnBuscarCla;
        private Panel panel2;
        private Button btnBuscarUsuario;
        private RoundControl roundControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RoundControl roundControl2;
        private Label label8;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
    }
}