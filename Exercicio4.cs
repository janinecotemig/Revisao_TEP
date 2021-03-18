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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
            textBoxOrdemCrescente.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3;
            numero1 = Convert.ToInt32(textBoxNumero1.Text);
            numero2 = Convert.ToInt32(textBoxNumero2.Text);
            numero3 = Convert.ToInt32(textBoxNumero3.Text);

            if(numero1 <= numero2 && numero1 <= numero3 && numero2 <=numero3)
            {
                textBoxOrdemCrescente.Text = numero1.ToString() + ", "+ numero2.ToString() +", "+ numero3.ToString();
            }
            else if (numero1 <= numero2 && numero1 <= numero3 && numero3 <= numero2)
            {
                textBoxOrdemCrescente.Text = numero1.ToString() + ", " + numero3.ToString() + ", " + numero2.ToString();
            }
            else if (numero2 <= numero1 && numero2 <= numero3 && numero1 <= numero3)
            {
                textBoxOrdemCrescente.Text = numero2.ToString() + ", " + numero1.ToString() + ", " + numero3.ToString();
            }
            else if (numero2 <= numero1 && numero2 <= numero3 && numero3 <= numero1)
            {
                textBoxOrdemCrescente.Text = numero2.ToString() + ", " + numero3.ToString() + ", " + numero1.ToString();
            }
            else if (numero3 <= numero1 && numero3 <= numero2 && numero1 <= numero2)
            {
                textBoxOrdemCrescente.Text = numero3.ToString() + ", " + numero1.ToString() + ", " + numero2.ToString();
            }
            else if (numero3 <= numero1 && numero3 <= numero2 && numero2 <= numero1)
            {
                textBoxOrdemCrescente.Text = numero3.ToString() + ", " + numero2.ToString() + ", " + numero1.ToString();
            }
        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
            textBoxNumero3.Clear();
            textBoxOrdemCrescente.Clear();
        }
    }
}
