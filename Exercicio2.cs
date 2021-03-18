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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
            // Desabilitando os campos de resultado (Total da compra, desconto e total final)
            textTotalCompra.Enabled = false;
            textTotalFinal.Enabled = false;
            textDesconto.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Botão Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            int quantidade;
            double valorUnitario, totalCompra, desconto,totalFinal;
            
            //Variável quantidade recebendo o valor do campo de texto convertido para o tipo inteiro
            quantidade = int.Parse(textQuantidade.Text);
            //Variável quantidade recebendo o valor do campo de texto convertido para o tipo double ou real
            valorUnitario = double.Parse(textValorUnitario.Text);

            //Calculando o total da compra
            totalCompra = quantidade * valorUnitario;
            //Mostrando(atribuindo) o valor da compra no textTotalCompra
            textTotalCompra.Text = totalCompra.ToString();

            // Se a quantidade for entre 1 e 5 
            if (quantidade >= 1 && quantidade <= 5)
            {
                //calculando o desconto, multiplica-se o valor da compra vezes percentual
                desconto = totalCompra * 0.02;
                // total final da compra
                totalFinal = totalCompra - desconto;
                
            }
            else if (quantidade >= 6 && quantidade <= 10)
            {
                //calculando o desconto, multiplica-se o valor da compra vezes percentual
                desconto = totalCompra * 0.03;
                // total final da compra
                totalFinal = totalCompra - desconto;
            }
            else 
            {
                //calculando o desconto, multiplica-se o valor da compra vezes percentual
                desconto = totalCompra * 0.05;
                // total final da compra
                totalFinal = totalCompra - desconto;
            }

            //Atribuindo o desconto do desconto no textDesconto, para isso o valor do desconto deve ser convertido para string
            textDesconto.Text = desconto.ToString();

            // Atribuindo o total final no textTotalFinal, para isso o valor do total final deve ser convertido para string
            textTotalFinal.Text = totalFinal.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
