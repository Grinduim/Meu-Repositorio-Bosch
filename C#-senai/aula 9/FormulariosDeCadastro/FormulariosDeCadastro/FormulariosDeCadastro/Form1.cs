using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormulariosDeCadastro
{
    public partial class Form1 : Form
    {
        MySqlConnection Connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Salvar1_Click(object sender, EventArgs e)
        {
            try
            {
                //dados do banco
                string data_source = "datasource=localhost;username=root;password=usbw;database=empresa";

                //criando conecao4
                Connection = new MySqlConnection(data_source);

                // comando de insert
                string sql =  $"INSERT INTO PRODUTO (Descricao,PrecoCompra,PrecoVenda, QtdEstoque) VALUES('{Descricao.Text}','{Compra.Text}','{Venda.Text}','{Estoque}')";

                MySqlCommand cmd = new MySqlCommand(sql, Connection);

                Connection.Open();// abrindo conecao

                cmd.ExecuteReader();// executando inset

                MessageBox.Show("Enviado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        private void SalvarF_Click(object sender, EventArgs e) // enviar dados do cliente para o bd
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=usbw;database=empresa"; // endereco de criacao

                Connection = new MySqlConnection(data_source); // gerabdo a coneção

                // comando para o insert
                string sql = $"INSERT INTO funcionario (nome,endereco,bairro,cidade,telefone,setor,dataDemissao) values ('" +
    NomeF.Text + "', '" + EnderecoF.Text + "','" + BairroF.Text + "','" +
    CidadeF.Text + "','" + TelefoneF.Text + "','" +
     SetorF.Text + "','" + DataDemF.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sql, Connection); // criando o comando

                Connection.Open(); // abrindo caminho
                cmd.ExecuteReader(); //executando insert
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close(); // fechando caminho
            }
        }

        //Função responsavel por salvar os dados dos usuarios
        private void SalvarU_Click(object sender, EventArgs e)
        {
            try
            {
                //configurar qual banco sera acessado com usuario e senha
                string data_source =
                "datasource=localhost;username=root;password=usbw;database=empresa";
                //criar conexao com o banco de dados
                Connection = new MySqlConnection(data_source);
                string sql = "INSERT INTO usuario (nome, nomeUsuario, senha)VALUES('" + NomeU.Text + "', '" + NomeDeU.Text + "', '" + SenhaU.Text +"')";
                //Executrar comando mysql
                MySqlCommand comando = new MySqlCommand(sql, Connection);
                Connection.Open();
                comando.ExecuteReader();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        private void SalvarFo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CPFF.Text.Length == 14 || CNPJ.Text.Length == 18)
                {

                    //configurar qual banco sera acessado com usuario e senha
                    string data_source =
                    "datasource=localhost;username=root;password=usbw;database=empresa;";
                    //criar conexao com o banco de dados
                    Connection = new MySqlConnection(data_source);
                    string sql = $"INSERT INTO fornecedor(cpf,cnpj,IE,endereco,bairro,cidade,telefone) VALUES ('{CPFF.Text}', '{CNPJ.Text}','{IE.Text}','{EnderecoFo.Text}','{BairroFo.Text}','{CidadeFo.Text}','{TelefoneFo.Text}')";

                    //Executrar comando mysql
                    MySqlCommand comando = new MySqlCommand(sql, Connection);
                    Connection.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Inserido com sucesso");



                }
                else if (CPFF.Text.Length == 14 || CNPJ.Text.Length != 18)
                {
                    throw new Exception("Erro, o Cnpj dever ser preenchido obrigatoriamente");
                }
                else
                {
                    throw new Exception("Erro, o cpf ou cnpj devems ser preenchidos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
