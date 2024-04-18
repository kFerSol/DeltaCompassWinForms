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
    public partial class MdiTeste : Form
    {
        PaginaConversao conversao;

        public MdiTeste()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conversao == null)
            {
                conversao = new PaginaConversao();
                conversao.FormClosed += Conversao_FormClosed;
                conversao.MdiParent = this;
                conversao.Show();
            }
            else
            {
                conversao.Activate();
            }
        }

        private void Conversao_FormClosed(object sender, FormClosedEventArgs e)
        {
            conversao = null;
        }
    }
}
