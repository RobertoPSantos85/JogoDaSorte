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
    public partial class FrmJogo : Form
    {
        int n1, n2, n3, n4, n5, n6;
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            TxtN1.Focus();
        }
    }
}
