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
            preencherComboBox();
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
            try
            {
                txtQuantidade.Clear();
                txtPago.Clear();
                lblEstoque.Text = "0";
                lblTroco.Text = "0";
                lblValorUnitario.Text = "0";
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            registrar();
            updateEstoque();
        }

        private void registrar()
        {
            try
            {


                ConStr.Open();

                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Venda(Item, Quantidade, Valor) VALUES('" + comboBoxItem.Text + "', '" + int.Parse(txtQuantidade.Text) + "', replace('" + Convert.ToDecimal((int.Parse(txtQuantidade.Text) * float.Parse(lblValorUnitario.Text))) + "',',','.'))";

                cmd.ExecuteNonQuery();

                ConStr.Close();

                MessageBox.Show("Venda Registrada!");
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }
        private void preencherComboBox()
        {
            try
            {
                comboBoxItem.Items.Clear();

                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Item FROM Produtos";
                cmd.ExecuteNonQuery();
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxItem.Items.Add(reader.GetString(0));
                }

                ConStr.Close();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            valorAPagar();
            
        }

        private void valorUnitario()
        {
            try
            {
                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ValorVenda FROM Produtos WHERE Item = '" + comboBoxItem.SelectedItem + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblValorUnitario.Text = reader.GetDecimal(0).ToString();
                }


                ConStr.Close();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void valorAPagar()
        {
            try
            {
                if (txtQuantidade.TextLength > 0 )
                {

                    lblValorPagar.Text = (int.Parse(txtQuantidade.Text) * float.Parse(lblValorUnitario.Text)).ToString("c");
                }
                else
                {
                    lblValorPagar.Text = "0,00";
                }
            }
            catch
            {
                MessageBox.Show("Preencha os campos corretamente");
            }

        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            preenchendoEstoque();

        }

        private void preenchendoEstoque()
        {
            try
            {
                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Quantidade,Id_item FROM Produtos WHERE Item = '" + comboBoxItem.SelectedItem + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblEstoque.Text = reader.GetInt32(0).ToString();
                    txtIdtem.Text = reader.GetInt32(1).ToString();
                }

                ConStr.Close();

                valorUnitario();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void troco()
        {
            try
            {
                lblTroco.Text = (float.Parse(txtPago.Text) - (int.Parse(txtQuantidade.Text) * float.Parse(lblValorUnitario.Text))).ToString("c");
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            if (txtPago.TextLength > 0)
            {
                troco();
            }
        }

        private void updateEstoque()
        {
            try
            {
                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Produtos SET Quantidade = Quantidade - '" + int.Parse(txtQuantidade.Text) + "' WHERE Id_item = '" + int.Parse(txtIdtem.Text) + "'";
                cmd.ExecuteNonQuery();


                ConStr.Close();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }
    }
}
