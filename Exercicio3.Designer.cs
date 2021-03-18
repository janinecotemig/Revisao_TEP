namespace WindowsFormsApp1
{
    partial class Exercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumeroConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.rdbSaque = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.flowLayoutPanelDadosConta = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxMovimentacao = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // textBoxNumeroConta
            // 
            this.textBoxNumeroConta.Location = new System.Drawing.Point(148, 28);
            this.textBoxNumeroConta.Name = "textBoxNumeroConta";
            this.textBoxNumeroConta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroConta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número da conta:";
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.Location = new System.Drawing.Point(148, 74);
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.Size = new System.Drawing.Size(246, 20);
            this.textBoxTitular.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular:";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaldo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxSaldo.Location = new System.Drawing.Point(148, 109);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(80, 26);
            this.textBoxSaldo.TabIndex = 4;
            this.textBoxSaldo.Text = "0";
            this.textBoxSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo:";
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbDeposito.Location = new System.Drawing.Point(41, 187);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(67, 17);
            this.rdbDeposito.TabIndex = 7;
            this.rdbDeposito.Text = "Depósito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // rdbSaque
            // 
            this.rdbSaque.AutoSize = true;
            this.rdbSaque.Location = new System.Drawing.Point(41, 226);
            this.rdbSaque.Name = "rdbSaque";
            this.rdbSaque.Size = new System.Drawing.Size(56, 17);
            this.rdbSaque.TabIndex = 8;
            this.rdbSaque.Text = "Saque";
            this.rdbSaque.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxValor.Location = new System.Drawing.Point(280, 212);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(114, 26);
            this.textBoxValor.TabIndex = 9;
            this.textBoxValor.Text = "0";
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaConta.Location = new System.Drawing.Point(243, 298);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(130, 35);
            this.btnNovaConta.TabIndex = 11;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(41, 295);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(101, 38);
            this.btnExecutar.TabIndex = 12;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // flowLayoutPanelDadosConta
            // 
            this.flowLayoutPanelDadosConta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelDadosConta.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanelDadosConta.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelDadosConta.Name = "flowLayoutPanelDadosConta";
            this.flowLayoutPanelDadosConta.Size = new System.Drawing.Size(396, 142);
            this.flowLayoutPanelDadosConta.TabIndex = 6;
            // 
            // groupBoxMovimentacao
            // 
            this.groupBoxMovimentacao.Location = new System.Drawing.Point(12, 160);
            this.groupBoxMovimentacao.Name = "groupBoxMovimentacao";
            this.groupBoxMovimentacao.Size = new System.Drawing.Size(394, 100);
            this.groupBoxMovimentacao.TabIndex = 13;
            this.groupBoxMovimentacao.TabStop = false;
            this.groupBoxMovimentacao.Text = "Movimentação";
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 346);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.rdbSaque);
            this.Controls.Add(this.rdbDeposito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumeroConta);
            this.Controls.Add(this.flowLayoutPanelDadosConta);
            this.Controls.Add(this.groupBoxMovimentacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Exercicio3";
            this.Text = "Conta Bancária";
            this.Load += new System.EventHandler(this.Exercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.RadioButton rdbSaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDadosConta;
        private System.Windows.Forms.GroupBox groupBoxMovimentacao;
    }
}