using RoundTextBoxProject.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaCompass
{
    public partial class RoundControl : UserControl
    {
        private int radius = 10;
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        private SolidBrush backgroundBrush = new SolidBrush(SystemColors.Control);
        private Color backgroundColor = SystemColors.Control;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundBrush = new SolidBrush(backgroundColor = value);
                Invalidate();
            }
        }
        private Color borderColor = Color.FromArgb(46, 43, 194);
        private Pen borderPen = new Pen(ControlPaint.Light(Color.FromArgb(46, 43, 194), 0.0f), 0);
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderPen = new Pen(ControlPaint.Light(borderColor, 0.0f), borderWidth);
                Invalidate();
            }
        }
        private float borderWidth = 1.0f;
        public float BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                borderPen = new Pen(ControlPaint.Light(BorderColor, 0.0f), borderWidth);
                Invalidate();
            }
        }
        
        public RoundControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawBorder(g);
            drawBackground(g);
        }
        private void drawBorder(Graphics g) =>
            g.DrawRoundedRectangle(borderPen, 10, 10, Width - 20, Height - 20, radius);
        private void drawBackground(Graphics g) =>
            g.FillRoundedRectangle(backgroundBrush, 10, 10, Width - 20, Height - 20, radius);

        private void RoundControl_Load(object sender, EventArgs e)
        {

        }
    }
}
