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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
            textBoxNumeroConta.Enabled = false;
            textBoxTitular.Enabled = false;
            textBoxSaldo.Enabled = false;
            textBoxValor.Enabled = false;
            rdbDeposito.Enabled = false;
            rdbSaque.Enabled = false;

        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            
            //RadioButton rbnSelecionado = null;
            float saldo, saldoFinal, valor;
            saldo = Int32.Parse(textBoxSaldo.Text);
            valor = Int32.Parse(textBoxValor.Text);

            if (rdbDeposito.Checked==true)
            {
                saldoFinal = saldo + valor;
                textBoxSaldo.Text = saldoFinal.ToString();

            }
            else if (rdbSaque.Checked == true)
            {
                if(saldo > valor)
                {
                    saldoFinal = saldo - valor;
                    textBoxSaldo.Text = saldoFinal.ToString();
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            textBoxNumeroConta.Enabled = true;
            textBoxTitular.Enabled = true;
            textBoxSaldo.Enabled = true;
            textBoxValor.Enabled = true;            
            rdbDeposito.Enabled = true;
            rdbSaque.Enabled = true;
        }

        
    }
}

