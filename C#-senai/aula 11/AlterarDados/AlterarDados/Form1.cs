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

namespace AlterarDados
{
    public partial class Form1 : Form
    {
        MySqlConnection Connection;

        public Form1()
        {
            InitializeComponent();
            CarregaBanco();
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=usbw;database=teste"; // data source 

                Connection = new MySqlConnection(data_source); // conbeção

                string sql = $"SELECT cod, nome FROM teste1 WHERE nome = {combo.Text}"; // select do item de acordo com o q foi inserido

                MySqlCommand command = new MySqlCommand(sql, Connection); // dita os dados da conexao

                Connection.Open(); // abre coneção

                MySqlDataReader data = command.ExecuteReader(); // armazena todos os dados do selecet e executa ele

                if (data.Read())
                {

                    cod.Text = data.GetString(1);
                }
                else
                {
                    MessageBox.Show("Registro não encontrado");
                }
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

        private void alterar_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=usbw;database=teste";

            Connection = new MySqlConnection(data_source);

            string sql = $"UPDATE teste1 set nome = {combo.Text} where cod = {cod.Text}";

            MySqlCommand command = new MySqlCommand(sql, Connection);   
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         void CarregaBanco () // função para carregar dados do banco
        {
            try
            {

                string data_source = "datasource=localhost;username=root;password=usbw;database=teste"; // data source do banco
                Connection = new MySqlConnection(data_source); // conexão

                string querynome = $"SELECT NOME FROM TESTE1"; // querry

                MySqlCommand command = new MySqlCommand(querynome, Connection);

                Connection.Open();

                MySqlDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    string sNome = myReader.GetString("nome"); // lendo os nomes e adicionando eles an coleção do combo box
                    combo.Items.Add(sNome);
                }

                MessageBox.Show("Banco carregou");
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
    }
}
