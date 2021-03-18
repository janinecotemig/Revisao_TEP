using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int angulo1, angulo2, angulo3;
            
            //Na linha abaixo está verificando se tem algum campo do formulário sem preencher
            if (textBoxAngulo1.Text == String.Empty || textBoxAngulo2.Text.Equals("") || textBoxAngulo3.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
                
            }
            else
            {
                // Entrará neste else se todos os campos forem preenchidos.
                //Nas três linhas abaixo está acontecendo a conversão dos valores para inteiro
                angulo1 = int.Parse(textBoxAngulo1.Text);
                angulo2 = int.Parse(textBoxAngulo2.Text);
                angulo3 = int.Parse(textBoxAngulo3.Text);

                // Nas condições abaixo está sendo classificado o tipo de triângulo.
                if ((angulo1 == 90 && angulo2 != 90 && angulo3 != 90) || (angulo2 == 90 && angulo1 != 90 && angulo3 != 90) || (angulo3 == 90 && angulo1 != 90 && angulo2 != 90))
                {
                    MessageBox.Show("Triângulo Retângulo");
                }
                else if ((angulo1 > 90 && angulo2 < 90 && angulo3 < 90) || (angulo2 > 90 && angulo1 < 90 && angulo3 < 90) || (angulo3 > 90 && angulo1 < 90 && angulo2 < 90))
                {
                    MessageBox.Show("Triângulo Obtusângulo");
                }
                else if (angulo1 < 90 && angulo2 < 90 && angulo3 < 90)
                {
                    MessageBox.Show("Triângulo Obtusângulo");
                }
                else 
                {
                    MessageBox.Show("Os valores digitados não correspondem a um triângulo");
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxAngulo1.Clear();
            textBoxAngulo2.Clear();
            textBoxAngulo3.Clear();
        }
    }
}

