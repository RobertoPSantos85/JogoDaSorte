using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaSorte
{
    public class ValidaDados
    {
        public bool Valida;
        public bool ValidaCampo(string s)
        {
            try
            {
                if (s != "")
                {
                    int h = int.Parse(s);

                    if (h < 0 || h > 60)
                    {
                        MessageBox.Show("Digite um número entre 00 e 60");
                        return Valida = false;


                    }
                    return Valida = true;
                }
                else
                {
                    MessageBox.Show("Digite um número entre 00 e 60");
                    return Valida = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return Valida;


        }

        public bool ValidaAposta(int[] a)
        {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    if (i != j)
                        if (a[i] == a[j])
                        {
                            return Valida = true;
                        }
            return Valida = false;

        }
    }
}
