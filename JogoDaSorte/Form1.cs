using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaSorte
{
    public partial class FrmBemVindo : Form
    {
        public FrmBemVindo()
        {
            InitializeComponent();
        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {
            FrmJogo j = new FrmJogo();
            j.Show();
        }
    }
}
