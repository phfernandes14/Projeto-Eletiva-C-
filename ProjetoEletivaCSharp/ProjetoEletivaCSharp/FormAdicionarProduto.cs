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
    public partial class FormAdicionarProduto : Form
    {
        SqlConnection ConStr = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security = True; Connect Timeout = 30");

        public FormAdicionarProduto()
        {
            InitializeComponent();
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            try
            {
                txtQuantidade.Clear();
                txtNome.Clear();
                txtValorCompra.Clear();
                txtValorVenda.Clear();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");

            }
        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            AddProdutos();

        }

        private void AddProdutos()
        {
            try
            {

               
                ConStr.Open();

                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Produtos(Item, ValorCompra, Quantidade, ValorVenda, Fornecedor) VALUES('" + txtNome.Text + "', replace('" + Convert.ToDecimal(txtValorCompra.Text) + "',',','.'), '" + int.Parse(txtQuantidade.Text) + "',replace('" + Convert.ToDecimal(txtValorVenda.Text) + "',',','.'),'" + comboBoxFornecedor.Text + "')";

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
