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
    public partial class Gerenciamento_Produtos : Form
    {
        public Gerenciamento_Produtos()
        {
            InitializeComponent();
        }
        private void RemoverProdutos_Click_1(object sender, EventArgs e)
        {
            if (GerenciarProdutos.SelectedRows.Count > 0)
            {
                //Pega ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(GerenciarProdutos.SelectedRows[0].Cells["ID_produto"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

                    try
                    {
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            consulta.Open();

                            string listagem = "DELETE FROM tb_produtos WHERE ID_Produto = @ID_Produto";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("ID_Produto", clienteID);

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
        private void PesquisarProdutos_Click_1(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT Id_produto, Nome, Valor, Categoria FROM tb_produtos";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosProdutos = new DataTable();
                        dadosProdutos.Load(reader);

                        GerenciarProdutos.DataSource = dadosProdutos;
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

