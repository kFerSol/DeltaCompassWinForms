using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace DeltaCompass
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class ComboBoxClass : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        public event EventHandler OnSelectedIndexChanged;

        public ComboBoxClass()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name,10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);
            /*lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);*/

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void Icon_Paint(object? sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen (iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            lblText.Text = cmbList.Text;
        }

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }

        private void Icon_Click(object? sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void Surface_Click(object? sender, EventArgs e)
        {
            this.OnClick(e);
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }
    }
}
