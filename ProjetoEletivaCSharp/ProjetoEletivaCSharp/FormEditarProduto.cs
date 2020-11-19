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
    public partial class FormEditarProduto : Form
    {
        SqlConnection ConStr = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security = True; Connect Timeout = 30");

        public FormEditarProduto()
        {
            InitializeComponent();
            preencherComboBox();
            preencherComboBoxFornecedor();
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            txtQuantidade.Clear();
        }

        private void preencherComboBox()
        {
            comboProdutoEditar.Items.Clear();

            ConStr.Open();
            SqlCommand cmd = ConStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Item FROM Produtos";
            cmd.ExecuteNonQuery();
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboProdutoEditar.Items.Add(reader.GetString(0));
            }

            ConStr.Close();

        }
        private void preencherComboBoxFornecedor()
        {
            comboBoxFornecedor.Items.Clear();

            ConStr.Open();
            SqlCommand cmd = ConStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Razao_social FROM Fornecedores";
            cmd.ExecuteNonQuery();
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxFornecedor.Items.Add(reader.GetString(0));
            }

            ConStr.Close();

        }

        private void autoCompletar()
        {
            ConStr.Open();
            SqlCommand cmd = ConStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Produtos WHERE Item = '" + comboProdutoEditar.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                txtNome.Text = reader.GetString(1);
                txtValorCompra.Text = reader.GetDecimal(2).ToString();
                txtValorVenda.Text = reader.GetDecimal(4).ToString();
                txtQuantidade.Text = reader.GetInt32(3).ToString();
                txtId.Text = reader.GetInt32(0).ToString();
                comboBoxFornecedor.Text = reader.GetString(5);

            }
            ConStr.Close();
        }

        private void comboProdutoEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoCompletar();
        }
        private void updateProduto()
        {
            ConStr.Open();
            SqlCommand cmd = ConStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Produtos SET Item = '"+ txtNome.Text + "', ValorCompra = replace('" + Convert.ToDecimal(txtValorCompra.Text) + "',',','.'), ValorVenda = replace('" + Convert.ToDecimal(txtValorVenda.Text) + "',',','.'), Fornecedor = '"+ comboBoxFornecedor.Text +"', Quantidade = '"+ int.Parse(txtQuantidade.Text) +"' WHERE Id_item = '"+ txtId.Text +"'";
            cmd.ExecuteNonQuery();

            ConStr.Close();
        }

        private void bttnSalvar_Click(object sender, EventArgs e)
        {
            updateProduto();
        }

        private void deletProduto()
        {
            ConStr.Open();
            SqlCommand cmd = ConStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Produtos WHERE Id_item = '"+ int.Parse(txtId.Text) +"' ";
            cmd.ExecuteNonQuery();

            ConStr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo))
            {
                deletProduto();
                Limpar();
                preencherComboBox();

            }
        }
    }
}
