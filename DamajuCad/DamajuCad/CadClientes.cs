using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
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

        private void Cadastrar_Clientes_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF VÁLIDO";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {

                labelAlert.Text = "CPF INVÁLIDO";
                labelAlert.ForeColor = Color.Red;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
                return;
            }

            String conexaoString = "Server=localhost; Port=3306; Database=bd_damaju; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_cliente ( Nome, Senha, Email, Cep, Cpf, Numero, Telefone ) VALUES (@Nome, @Senha, @Email, @Cep, @Cpf, @Numero, @Telefone)";

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
                        comando.Parameters.AddWithValue("@Senha", Senha.Text);
                        comando.Parameters.AddWithValue("@Email", Email.Text);
                        comando.Parameters.AddWithValue("@Cep", Cep.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@Numero", Numero.Text);
                        comando.Parameters.AddWithValue("@Telefone", Telefone.Text);


                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        Nome.Text = "";
                        Senha.Text = "";
                        Email.Text = "";
                        Cep.Text = "";
                        maskedTextBoxCPF.Text = "";
                        Numero.Text = "";
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
         private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
         }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

