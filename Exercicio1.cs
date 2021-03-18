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
    
    public partial class Exercicio1 : Form
    {
        
        public Exercicio1()
        {
                //Carregando os componentes do formulário
                InitializeComponent();
    
        }

          
     //Botão Entrar    
    private void button1_Click(object sender, EventArgs e)
        {
              //Se o texto digitado no textBoxSenha for igual a 1234
             if (textBoxSenha.Text.Equals("1234") )
             {
                //Exibindo a caixa de mensagem com o texto Acesso Permitido
                MessageBox.Show("Acesso Permitido!");
                
                //Fechando o formulário(janela)
                this.Close();
             }
            else
            {
                //Exibindo a caixa de texto com a mensagem Acesso Negado.
                MessageBox.Show("Acesso Negado!");

                //Limpando o textBoxSenha para ser digitado outro valor
                textBoxSenha.Text = "";                
             }            
    
    }
        //Botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando os campos de texto usuário e senha
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
        }

        private void Exercicio1_Load(object sender, EventArgs e)
        {
            

        }
    }


    
    }

   

