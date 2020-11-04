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

namespace ProjetoEletivaCSharp
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                conString.Open();
                MessageBox.Show("CONECTADO COM O BANCO");

            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO AO CONECTAR COM O BANCO"+erro.Message);
            }        
        }
    }
}
