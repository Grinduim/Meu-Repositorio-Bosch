
namespace FormulariosDeCadastro
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Salvar1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SalvarF = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EnderecoF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SetorF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DataDemF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefoneF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NomeF = new System.Windows.Forms.MaskedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.NomeU = new System.Windows.Forms.TextBox();
            this.SalvarU = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SenhaU = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.NomeDeU = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TelefoneFo = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.IN = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnderecoFo = new System.Windows.Forms.TextBox();
            this.CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.CPFF = new System.Windows.Forms.MaskedTextBox();
            this.SalvarFo = new System.Windows.Forms.Button();
            this.Venda = new System.Windows.Forms.MaskedTextBox();
            this.Compra = new System.Windows.Forms.MaskedTextBox();
            this.CidadeF = new System.Windows.Forms.MaskedTextBox();
            this.BairroF = new System.Windows.Forms.MaskedTextBox();
            this.BairroFo = new System.Windows.Forms.TextBox();
            this.CidadeFo = new System.Windows.Forms.TextBox();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(829, 463);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Compra);
            this.tabPage1.Controls.Add(this.Venda);
            this.tabPage1.Controls.Add(this.Salvar1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Estoque);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Descricao);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Salvar1
            // 
            this.Salvar1.Location = new System.Drawing.Point(23, 374);
            this.Salvar1.Name = "Salvar1";
            this.Salvar1.Size = new System.Drawing.Size(75, 23);
            this.Salvar1.TabIndex = 8;
            this.Salvar1.Text = "Salvar";
            this.Salvar1.UseVisualStyleBackColor = true;
            this.Salvar1.Click += new System.EventHandler(this.Salvar1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estoque";
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(126, 114);
            this.Estoque.Mask = "00000";
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(100, 22);
            this.Estoque.TabIndex = 6;
            this.Estoque.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço de venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço de compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(467, 62);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(216, 336);
            this.Descricao.TabIndex = 0;
            this.Descricao.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BairroF);
            this.tabPage2.Controls.Add(this.CidadeF);
            this.tabPage2.Controls.Add(this.SalvarF);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.EnderecoF);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.SetorF);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.DataDemF);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TelefoneF);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.NomeF);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Funcionário";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SalvarF
            // 
            this.SalvarF.Location = new System.Drawing.Point(25, 352);
            this.SalvarF.Name = "SalvarF";
            this.SalvarF.Size = new System.Drawing.Size(75, 23);
            this.SalvarF.TabIndex = 18;
            this.SalvarF.Text = "Salvar";
            this.SalvarF.UseVisualStyleBackColor = true;
            this.SalvarF.Click += new System.EventHandler(this.SalvarF_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Endereço";
            // 
            // EnderecoF
            // 
            this.EnderecoF.Location = new System.Drawing.Point(91, 211);
            this.EnderecoF.Name = "EnderecoF";
            this.EnderecoF.Size = new System.Drawing.Size(100, 22);
            this.EnderecoF.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Setor de trabalho";
            // 
            // SetorF
            // 
            this.SetorF.Location = new System.Drawing.Point(394, 71);
            this.SetorF.Name = "SetorF";
            this.SetorF.Size = new System.Drawing.Size(100, 22);
            this.SetorF.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data de demissão";
            // 
            // DataDemF
            // 
            this.DataDemF.Location = new System.Drawing.Point(394, 45);
            this.DataDemF.Mask = "00/00/0000";
            this.DataDemF.Name = "DataDemF";
            this.DataDemF.Size = new System.Drawing.Size(100, 22);
            this.DataDemF.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telefone";
            // 
            // TelefoneF
            // 
            this.TelefoneF.Location = new System.Drawing.Point(91, 74);
            this.TelefoneF.Mask = "(99) 00000-0000";
            this.TelefoneF.Name = "TelefoneF";
            this.TelefoneF.Size = new System.Drawing.Size(100, 22);
            this.TelefoneF.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome";
            // 
            // NomeF
            // 
            this.NomeF.Location = new System.Drawing.Point(91, 48);
            this.NomeF.Name = "NomeF";
            this.NomeF.Size = new System.Drawing.Size(100, 22);
            this.NomeF.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.NomeU);
            this.tabPage3.Controls.Add(this.SalvarU);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.SenhaU);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.NomeDeU);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(821, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usuário";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Nome";
            // 
            // NomeU
            // 
            this.NomeU.Location = new System.Drawing.Point(128, 16);
            this.NomeU.Name = "NomeU";
            this.NomeU.Size = new System.Drawing.Size(100, 22);
            this.NomeU.TabIndex = 14;
            // 
            // SalvarU
            // 
            this.SalvarU.Location = new System.Drawing.Point(25, 328);
            this.SalvarU.Name = "SalvarU";
            this.SalvarU.Size = new System.Drawing.Size(75, 23);
            this.SalvarU.TabIndex = 13;
            this.SalvarU.Text = "Salvar";
            this.SalvarU.UseVisualStyleBackColor = true;
            this.SalvarU.Click += new System.EventHandler(this.SalvarU_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Senha";
            // 
            // SenhaU
            // 
            this.SenhaU.Location = new System.Drawing.Point(128, 68);
            this.SenhaU.Name = "SenhaU";
            this.SenhaU.Size = new System.Drawing.Size(100, 22);
            this.SenhaU.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nome de Usuario";
            // 
            // NomeDeU
            // 
            this.NomeDeU.Location = new System.Drawing.Point(128, 42);
            this.NomeDeU.Name = "NomeDeU";
            this.NomeDeU.Size = new System.Drawing.Size(100, 22);
            this.NomeDeU.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BairroFo);
            this.tabPage4.Controls.Add(this.CidadeFo);
            this.tabPage4.Controls.Add(this.SalvarFo);
            this.tabPage4.Controls.Add(this.TelefoneFo);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.IN);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.EnderecoFo);
            this.tabPage4.Controls.Add(this.CNPJ);
            this.tabPage4.Controls.Add(this.CPFF);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(821, 434);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fornecedor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TelefoneFo
            // 
            this.TelefoneFo.Location = new System.Drawing.Point(327, 143);
            this.TelefoneFo.Mask = "(99) 00000-0000";
            this.TelefoneFo.Name = "TelefoneFo";
            this.TelefoneFo.Size = new System.Drawing.Size(121, 22);
            this.TelefoneFo.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 16);
            this.label22.TabIndex = 15;
            this.label22.Text = "IN";
            // 
            // IN
            // 
            this.IN.Location = new System.Drawing.Point(89, 118);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(121, 22);
            this.IN.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(263, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Telefone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(263, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 16);
            this.label20.TabIndex = 12;
            this.label20.Text = "Cidade";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(263, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Bairro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(263, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Endereço";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF";
            // 
            // EnderecoFo
            // 
            this.EnderecoFo.Location = new System.Drawing.Point(327, 62);
            this.EnderecoFo.Name = "EnderecoFo";
            this.EnderecoFo.Size = new System.Drawing.Size(121, 22);
            this.EnderecoFo.TabIndex = 3;
            // 
            // CNPJ
            // 
            this.CNPJ.Location = new System.Drawing.Point(89, 90);
            this.CNPJ.Mask = "00.000.000/0000-00";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Size = new System.Drawing.Size(121, 22);
            this.CNPJ.TabIndex = 2;
            // 
            // CPFF
            // 
            this.CPFF.Location = new System.Drawing.Point(89, 64);
            this.CPFF.Mask = "000.000.000-00";
            this.CPFF.Name = "CPFF";
            this.CPFF.Size = new System.Drawing.Size(121, 22);
            this.CPFF.TabIndex = 1;
            this.CPFF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // SalvarFo
            // 
            this.SalvarFo.Location = new System.Drawing.Point(24, 328);
            this.SalvarFo.Name = "SalvarFo";
            this.SalvarFo.Size = new System.Drawing.Size(75, 23);
            this.SalvarFo.TabIndex = 17;
            this.SalvarFo.Text = "Salvar";
            this.SalvarFo.UseVisualStyleBackColor = true;
            this.SalvarFo.Click += new System.EventHandler(this.SalvarFo_Click);
            // 
            // Venda
            // 
            this.Venda.Location = new System.Drawing.Point(129, 93);
            this.Venda.Mask = "$0000";
            this.Venda.Name = "Venda";
            this.Venda.Size = new System.Drawing.Size(100, 22);
            this.Venda.TabIndex = 9;
            this.Venda.ValidatingType = typeof(int);
            // 
            // Compra
            // 
            this.Compra.Location = new System.Drawing.Point(137, 65);
            this.Compra.Mask = "$00000";
            this.Compra.Name = "Compra";
            this.Compra.Size = new System.Drawing.Size(100, 22);
            this.Compra.TabIndex = 10;
            this.Compra.ValidatingType = typeof(int);
            // 
            // CidadeF
            // 
            this.CidadeF.Location = new System.Drawing.Point(91, 268);
            this.CidadeF.Name = "CidadeF";
            this.CidadeF.Size = new System.Drawing.Size(100, 22);
            this.CidadeF.TabIndex = 19;
            // 
            // BairroF
            // 
            this.BairroF.Location = new System.Drawing.Point(91, 240);
            this.BairroF.Name = "BairroF";
            this.BairroF.Size = new System.Drawing.Size(100, 22);
            this.BairroF.TabIndex = 20;
            // 
            // BairroFo
            // 
            this.BairroFo.Location = new System.Drawing.Point(327, 85);
            this.BairroFo.Name = "BairroFo";
            this.BairroFo.Size = new System.Drawing.Size(121, 22);
            this.BairroFo.TabIndex = 19;
            // 
            // CidadeFo
            // 
            this.CidadeFo.Location = new System.Drawing.Point(327, 113);
            this.CidadeFo.Name = "CidadeFo";
            this.CidadeFo.Size = new System.Drawing.Size(121, 22);
            this.CidadeFo.TabIndex = 18;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(853, 487);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Produto;
        private System.Windows.Forms.TabPage Funcionarios;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Salvar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Estoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Descricao;
        private System.Windows.Forms.Button SalvarF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EnderecoF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox SetorF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox DataDemF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TelefoneF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox NomeF;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox NomeU;
        private System.Windows.Forms.Button SalvarU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox SenhaU;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NomeDeU;
        private System.Windows.Forms.MaskedTextBox CNPJ;
        private System.Windows.Forms.MaskedTextBox CPFF;
        private System.Windows.Forms.MaskedTextBox TelefoneFo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox IN;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EnderecoFo;
        private System.Windows.Forms.MaskedTextBox Compra;
        private System.Windows.Forms.MaskedTextBox Venda;
        private System.Windows.Forms.Button SalvarFo;
        private System.Windows.Forms.MaskedTextBox BairroF;
        private System.Windows.Forms.MaskedTextBox CidadeF;
        private System.Windows.Forms.TextBox BairroFo;
        private System.Windows.Forms.TextBox CidadeFo;
    }
}

