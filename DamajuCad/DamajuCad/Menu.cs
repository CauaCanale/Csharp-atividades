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
    public partial class Menu : Form
    {

        bool VerSenhaTxt = false;
        private string UsuarioCorreto = "David";
        private string SenhaCorreta = "123456";

        public Menu()
        {
            InitializeComponent();
        }

        private void ocultar_senha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                ocultar_senha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                ocultar_senha.Text = "Mostrar Senha";
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == UsuarioCorreto && senha == SenhaCorreta)
            {
                labelMenssagem.Text = "Login bem-sucedido";
                labelMenssagem.ForeColor = Color.Green;
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                labelMenssagem.Text = "Usuário ou senha Invalida";
                labelMenssagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
