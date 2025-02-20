using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamajuCad
{
    public partial class Gerenciamento_Clientes : Form
    {
        public Gerenciamento_Clientes()
        {
            InitializeComponent();
        }

        private void Gerenciar_Clientes_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT ID_Clientes, Nome, Numero FROM tb_cliente";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        Gerenciar_Clientes.DataSource = dadosClientes;
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes:" + ex.Message);
            }
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (Gerenciar_Clientes.SelectedRows.Count > 0)
            {
                //Pega ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(Gerenciar_Clientes.SelectedRows[0].Cells["ID_Clientes"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

                    try
                    {
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            consulta.Open();

                            string listagem = "DELETE FROM tb_cliente WHERE ID_Clientes = @ID_Clientes";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("ID_Clientes", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um cliente para excluir");
                }
            }
        }

        private void PesquisarClientes_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT ID_Clientes, Nome, Cpf, Telefone, Email FROM tb_cliente";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        Gerenciar_Clientes.DataSource = dadosClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes:" + ex.Message);
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

