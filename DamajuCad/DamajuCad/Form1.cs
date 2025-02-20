using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DamajuCad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CadLanche_Click(object sender, EventArgs e)
        {
            Cadprodutos form = new Cadprodutos();
            form.ShowDialog();
          
        }

        private void Gerenciamento_produtos_Click(object sender, EventArgs e)
        {
            Gerenciamento_Produtos form = new Gerenciamento_Produtos();
            form.ShowDialog();
        }

        private void Gerenciamento_Clientes_Click(object sender, EventArgs e)
        {
            Gerenciamento_Clientes form = new Gerenciamento_Clientes();
            form.ShowDialog();
        }

        private void CadCliente_Click(object sender, EventArgs e)
        {
            CadClientes form = new CadClientes();
            form.ShowDialog();
        }
    }
}
