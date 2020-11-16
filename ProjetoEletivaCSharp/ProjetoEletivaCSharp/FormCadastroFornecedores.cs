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
    public partial class FormCadastroFornecedores : Form
    {
        SqlConnection ConStr = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security = True; Connect Timeout = 30");

        public FormCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            CadastarFornecedor();
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void CadastarFornecedor()
        {
            try
            {
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Fornecedores(CNPJ, Inscri_estadual, Insc_municipal, Natureza_juridica, Ramo_negocio, Endereco, Razao_Social, Email, Telefone) VALUES('" + int.Parse(txtCNPJ.Text) + "', '" + int.Parse(txtInsEstadual.Text) + "', '" + int.Parse(txtInsMunicipal.Text) + "','" + txtNatureza.Text + "','" + txtRamo.Text + "','" + txtEndereco.Text + "' ,'" + txtRazao.Text + "', '" + txtEmail.Text + "', '" + int.Parse(txtTelefone.Text) + "')";

                ConStr.Open();
                cmd.ExecuteNonQuery();
                ConStr.Close();

                MessageBox.Show("Fornecedor Cadastrado!");
            }
            catch
            {
                MessageBox.Show("Algo de errado aconteceu!");
            }

        }

        private void LimparCampos()
        {
            try
            {
                txtCNPJ.Clear();
                txtEmail.Clear();
                txtEndereco.Clear();
                txtInsEstadual.Clear();
                txtInsMunicipal.Clear();
                txtNatureza.Clear();
                txtRamo.Clear();
                txtRazao.Clear();
                txtTelefone.Clear();
            }
            catch
            {
                MessageBox.Show("Algo de errado aconteceu!");
            }
        }
    }
}
