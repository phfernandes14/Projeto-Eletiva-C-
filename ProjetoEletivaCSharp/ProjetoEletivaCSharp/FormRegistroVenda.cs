using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjetoEletivaCSharp
{
    public partial class FormRegistroVenda : Form
    {
        SqlConnection ConStr = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security = True; Connect Timeout = 30");

        public FormRegistroVenda()
        {
            InitializeComponent();
        }

        private void FormRegistroVenda_Load(object sender, EventArgs e)
        {

        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            txtQuantidade.Clear();
            txtPago.Clear();
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {


                ConStr.Open();

                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Venda VALUES()";

                cmd.ExecuteNonQuery();

                ConStr.Close();

                MessageBox.Show("O Produto foi adicionado!");
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }
    }
}
