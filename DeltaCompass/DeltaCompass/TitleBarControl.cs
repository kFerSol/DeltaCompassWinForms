﻿using System;
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
    public partial class TitleBarControl : UserControl
    {
        public TitleBarControl()
        {
            InitializeComponent();
        }

        private void fecharBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharBtn_MouseEnter(object sender, EventArgs e)
        {
            fecharBtn.BackColor = Color.FromArgb(46, 43, 194);
        }

        private void fecharBtn_MouseLeave(object sender, EventArgs e)
        {
            fecharBtn.BackColor = Color.FromArgb(28, 28, 28);
        }
    }
}