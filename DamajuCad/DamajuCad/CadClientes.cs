using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamajuCad
{
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }
        
        private void Cadastrar_Click(object sender, EventArgs e)
        {

            String conexaoString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_cliente ( ID_Clientes, Nome, Senha, Email, Cep, Cpf, Numero, Telefone ) VALUES (@Nome, @Email, @Cpf, @Telefone)";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {

                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@Nome", Nome.Text);
                        comando.Parameters.AddWithValue("@Email", Email.Text);
                        comando.Parameters.AddWithValue("@Cpf", Cpf.Text);
                        comando.Parameters.AddWithValue("@Telefone", Telefone.Text);


                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        Nome.Text = "";
                        Email.Text = "";
                        Cpf.Text = "";
                        Telefone.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        
        private void Cadastrar_Clientes_Click_1(object sender, EventArgs e)
        {

        }
    }
}    

