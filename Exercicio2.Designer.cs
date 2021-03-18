namespace WindowsFormsApp1
{
    partial class Exercicio2
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textNomeProduto = new System.Windows.Forms.TextBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.Label();
            this.textValorUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textTotalCompra = new System.Windows.Forms.TextBox();
            this.textDesconto = new System.Windows.Forms.TextBox();
            this.textTotalFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNomeProduto
            // 
            this.textNomeProduto.Location = new System.Drawing.Point(162, 55);
            this.textNomeProduto.Name = "textNomeProduto";
            this.textNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.textNomeProduto.TabIndex = 1;
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(162, 97);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 3;
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.Location = new System.Drawing.Point(64, 100);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(68, 13);
            this.quantidade.TabIndex = 2;
            this.quantidade.Text = "Quantidade: ";
            // 
            // textValorUnitario
            // 
            this.textValorUnitario.Location = new System.Drawing.Point(162, 139);
            this.textValorUnitario.Name = "textValorUnitario";
            this.textValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.textValorUnitario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço unitário: ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(67, 184);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar  Dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTotalCompra
            // 
            this.textTotalCompra.Location = new System.Drawing.Point(401, 55);
            this.textTotalCompra.Name = "textTotalCompra";
            this.textTotalCompra.Size = new System.Drawing.Size(100, 20);
            this.textTotalCompra.TabIndex = 10;
            // 
            // textDesconto
            // 
            this.textDesconto.Location = new System.Drawing.Point(401, 97);
            this.textDesconto.Name = "textDesconto";
            this.textDesconto.Size = new System.Drawing.Size(100, 20);
            this.textDesconto.TabIndex = 11;
            // 
            // textTotalFinal
            // 
            this.textTotalFinal.Location = new System.Drawing.Point(401, 139);
            this.textTotalFinal.Name = "textTotalFinal";
            this.textTotalFinal.Size = new System.Drawing.Size(100, 20);
            this.textTotalFinal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total da compra: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Desconto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Final:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(308, 184);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 30);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 242);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTotalFinal);
            this.Controls.Add(this.textDesconto);
            this.Controls.Add(this.textTotalCompra);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textValorUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.textNomeProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Exercicio2";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomeProduto;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox textValorUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox textTotalCompra;
        private System.Windows.Forms.TextBox textDesconto;
        private System.Windows.Forms.TextBox textTotalFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
    }
}

