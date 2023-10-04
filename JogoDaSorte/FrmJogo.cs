using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaSorte
{
    public partial class FrmJogo : Form
    {
        
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            TxtN1.Focus();
        }

        ValidaDados valida = new ValidaDados();

        private void BtnSorteio_Click(object sender, EventArgs e)
        {
           

            try
            {

                int[] apostas = new int[6];

                apostas[0] = int.Parse(TxtN1.Text);
                apostas[1] = int.Parse(TxtN2.Text);
                apostas[2] = int.Parse(TxtN3.Text);
                apostas[3] = int.Parse(TxtN4.Text);
                apostas[4] = int.Parse(TxtN5.Text);
                apostas[5] = int.Parse(TxtN6.Text);

                if(valida.ValidaAposta(apostas) == true)
                {
                    MessageBox.Show("Certifique - se que não há repetição de números na aposta.");
                }
                else
                {
                    
                    if(valida.ValidaAposta(Sorteio()) == false)
                    {
                        int[] sorteios = Sorteio();
                        int acerto = 0;
                        foreach (int aposta in apostas)
                            foreach(int sorteio in sorteios)
                            {
                                if (sorteio == aposta)
                                {
                                    acerto++;
                                }
                            }
                        LblNumeros.Text = sorteios[0] + " " + sorteios[1] + " " + sorteios[2] + " " + sorteios[3] + " " + sorteios[4] + " "
                            + sorteios[5];

                        MessageBox.Show("Você acertou: " + acerto);
                        BtnSorteio.Enabled = false;
                        
                    }
                    else
                    {
                        Sorteio();
                    }

                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ops! Ocorreu um erro inesperado!");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN1.Focus();
            TxtN2.Clear();
            TxtN3.Clear();
            TxtN4.Clear();
            TxtN5.Clear();
            TxtN6.Clear();
            LblNumeros.Text = " ";
            BtnSorteio.Enabled = true; 
        }

       

        private void TxtN1_Leave(object sender, EventArgs e)
        { 
            
            if (valida.ValidaCampo(TxtN1.Text) == false)
            {
                TxtN1.Focus();
            }
        }

        private void TxtN2_Leave(object sender, EventArgs e)
        {
            if (valida.ValidaCampo(TxtN2.Text) == false)
            {
                TxtN2.Focus();
            }
        }

        private void TxtN3_Leave(object sender, EventArgs e)
        {
            if (valida.ValidaCampo(TxtN3.Text) == false)
            {
                TxtN3.Focus();
            }
        }

        private void TxtN4_Leave(object sender, EventArgs e)
        {
            if (valida.ValidaCampo(TxtN4.Text) == false)
            {
                TxtN4.Focus();
            }
        }

        private void TxtN5_Leave(object sender, EventArgs e)
        {
            if (valida.ValidaCampo(TxtN5.Text) == false)
            {
                TxtN5.Focus();
            }
        }

        private void TxtN6_Leave(object sender, EventArgs e)
        {
            if (valida.ValidaCampo(TxtN6.Text) == false)
            {
                TxtN6.Focus();
            }
        }

        

        public int[] Sorteio()
        {
            Random sorte = new Random();
            int[] sorteios = new int[6];

            for (int i = 0; i < 6; i++)
            {
                sorteios[i] = sorte.Next(0, 61);
            }

            return sorteios;
        }
    }
}
