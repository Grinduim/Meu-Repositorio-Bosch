
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txNasc = new System.Windows.Forms.DateTimePicker();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txTel = new System.Windows.Forms.MaskedTextBox();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(92, 42);
            this.txName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(752, 22);
            this.txName.TabIndex = 1;
            this.txName.TextChanged += new System.EventHandler(this.txName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento";
            // 
            // txNasc
            // 
            this.txNasc.Location = new System.Drawing.Point(563, 81);
            this.txNasc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txNasc.Name = "txNasc";
            this.txNasc.Size = new System.Drawing.Size(281, 22);
            this.txNasc.TabIndex = 3;
            // 
            // txEndereco
            // 
            this.txEndereco.Location = new System.Drawing.Point(95, 128);
            this.txEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txEndereco.MaxLength = 50;
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.Size = new System.Drawing.Size(752, 22);
            this.txEndereco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade";
            // 
            // txCidade
            // 
            this.txCidade.Location = new System.Drawing.Point(95, 177);
            this.txCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(312, 22);
            this.txCidade.TabIndex = 5;
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(548, 177);
            this.txBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(299, 22);
            this.txBairro.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefone";
            // 
            // txTel
            // 
            this.txTel.Location = new System.Drawing.Point(95, 229);
            this.txTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txTel.Mask = "(99) 00000-0000";
            this.txTel.Name = "txTel";
            this.txTel.Size = new System.Drawing.Size(312, 22);
            this.txTel.TabIndex = 7;
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(92, 85);
            this.txCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCPF.Mask = "000.000.000-00";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(200, 22);
            this.txCPF.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(377, 338);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 79);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.txTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txNasc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txNasc;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txTel;
        private System.Windows.Forms.MaskedTextBox txCPF;
        private System.Windows.Forms.Button btnSalvar;
    }
}

