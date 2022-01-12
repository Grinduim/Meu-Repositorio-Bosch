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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection Conect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=usbw;database=db_agenda;"; // dados da conexao com o bd

                Conect = new MySqlConnection(data_source); // conectando ao data souce

                string sql = $"INSERT INTO cliente2 (nome,cpf,endereco,bairro,cidade,telefone,data_Nasc) VALUES('{txName.Text}','{txCPF.Text}','{txEndereco.Text}','{txBairro.Text}','{txCidade.Text}','{txTel.Text}','{Convert.ToDateTime(txNasc.Value)}')"; // comando de insert no MySQL

                MySqlCommand command = new MySqlCommand(sql, Conect); // invocando o comando e em qual BD e conexao

                Conect.Open(); // abrindo a conexao

                command.ExecuteReader(); // executando o comando SQL

                MessageBox.Show("Inserido com sucesso"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conect.Close(); // fechando a conexao
            }

        }

        private void txName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
