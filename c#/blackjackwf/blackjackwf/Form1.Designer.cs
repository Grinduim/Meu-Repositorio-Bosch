
namespace blackjackwf
{
    partial class Form1
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
            this.BtnApostar = new System.Windows.Forms.Button();
            this.TextAposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CartasJogador = new System.Windows.Forms.Label();
            this.CartasMesa = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnApostar
            // 
            this.BtnApostar.Location = new System.Drawing.Point(3, 3);
            this.BtnApostar.Name = "BtnApostar";
            this.BtnApostar.Size = new System.Drawing.Size(80, 23);
            this.BtnApostar.TabIndex = 0;
            this.BtnApostar.Text = "Apostar";
            this.BtnApostar.UseVisualStyleBackColor = true;
            this.BtnApostar.Click += new System.EventHandler(this.BtnApostar_Click);
            // 
            // TextAposta
            // 
            this.TextAposta.Location = new System.Drawing.Point(204, 5);
            this.TextAposta.Name = "TextAposta";
            this.TextAposta.Size = new System.Drawing.Size(100, 20);
            this.TextAposta.TabIndex = 1;
            this.TextAposta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor R$";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(3, 54);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saldo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CartasJogador
            // 
            this.CartasJogador.AutoSize = true;
            this.CartasJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartasJogador.Location = new System.Drawing.Point(12, 120);
            this.CartasJogador.Name = "CartasJogador";
            this.CartasJogador.Size = new System.Drawing.Size(89, 17);
            this.CartasJogador.TabIndex = 5;
            this.CartasJogador.Text = "Suas Cartas:";
            // 
            // CartasMesa
            // 
            this.CartasMesa.AutoSize = true;
            this.CartasMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartasMesa.Location = new System.Drawing.Point(12, 158);
            this.CartasMesa.Name = "CartasMesa";
            this.CartasMesa.Size = new System.Drawing.Size(0, 17);
            this.CartasMesa.TabIndex = 6;
            this.CartasMesa.Click += new System.EventHandler(this.CartasMesa_Click);
            // 
            // BtnHit
            // 
            this.BtnHit.Location = new System.Drawing.Point(455, 120);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(75, 23);
            this.BtnHit.TabIndex = 7;
            this.BtnHit.Text = "Hit!";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.CartasMesa);
            this.Controls.Add(this.CartasJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAposta);
            this.Controls.Add(this.BtnApostar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApostar;
        private System.Windows.Forms.TextBox TextAposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CartasJogador;
        private System.Windows.Forms.Label CartasMesa;
        private System.Windows.Forms.Button BtnHit;
    }
}

