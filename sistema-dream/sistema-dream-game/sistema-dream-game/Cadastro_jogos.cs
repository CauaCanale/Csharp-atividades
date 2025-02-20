using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sistema_dream_game
{
    public partial class Cadastro_jogos : Form
    {
        public Cadastro_jogos()
        {
            InitializeComponent();
        }
        
        private void CadastrarJogo_Click(object sender, EventArgs e)
        {

            string conexaoString = "Server=localhost; Port=3306; Database=bd_dream-game; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_games (Titulo, Avaliacao, Tamanho, Ano, Descricao, Valor, Desenvolvedor, Genero) VALUES (@Titulo, @Avaliacao, @Tamanho, @Ano, @Descricao, @Valor, @Desenvolvedor, @Genero)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    //Crie o comando SQL

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {

                        comando.Parameters.AddWithValue("@Titulo", Titulo.Text);
                        comando.Parameters.AddWithValue("@Avaliacao", Avaliacao.Text);
                        comando.Parameters.AddWithValue("@Tamanho", Tamanho.Text);
                        comando.Parameters.AddWithValue("@Ano", Ano.Text);
                        comando.Parameters.AddWithValue("@Descricao", Descricao.Text);
                        comando.Parameters.AddWithValue("@Valor", Valor.Text);
                        comando.Parameters.AddWithValue("@Desenvolvedor", Desenvolvedor.Text);
                        comando.Parameters.AddWithValue("@Genero", Genero.Text);


                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");

                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void VoltarCampo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

