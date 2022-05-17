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
        
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            TxtN1.Focus();
        }

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

                foreach(int aposta in apostas)
                {
                    if((aposta < 0) || (aposta > 60 ))
                    {
                        MessageBox.Show("Digite números dentro do intervalo de 00 à 60");
                    }
                }
                
                Random sorte = new Random();
                int[] sorteios = new int[6];
                int acerto = 0;

                for (int i = 0; i < 6; i++)
                {
                    sorteios[i] = sorte.Next(0, 61);
                }

                foreach (int aposta in apostas)
                    foreach (int sorteio in sorteios)
                    {
                        if (sorteio == aposta)
                        {
                            acerto++;
                        }
                    }
                LblNumeros.Text = sorteios[0] + " " + sorteios[1] + " " + sorteios[2] + " " + sorteios[3] + " " + sorteios[4] + " "
                    + sorteios[5];

                MessageBox.Show("Você acertou: " + acerto);
            }
            catch(Exception)
            {
                MessageBox.Show("Ops! Certifique - se de que foram digitados apenas números dentro do intervalo de 0 a 60");
            }

            

            

            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN2.Clear();
            TxtN3.Clear();
            TxtN4.Clear();
            TxtN5.Clear();
            TxtN6.Clear();
            LblNumeros.Text = " ";
        }
    }
}
