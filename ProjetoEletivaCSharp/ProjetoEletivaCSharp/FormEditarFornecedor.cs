﻿using System;
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
    public partial class FormEditarFornecedor : Form
    {
        SqlConnection ConStr = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security = True; Connect Timeout = 30");



        public FormEditarFornecedor()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void bttnSalvar_Click(object sender, EventArgs e)
        {
            updateFornecedor();
        }

        private void preencherComboBox()
        {
            try
            {
                comboBoxFornecedorEditar.Items.Clear();

                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Razao_social FROM Fornecedores";
                cmd.ExecuteNonQuery();
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxFornecedorEditar.Items.Add(reader.GetString(0));
                }

                ConStr.Close();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void comboBoxFornecedorEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoCompletar();
        }

        private void autoCompletar()
        {
            try
            {
                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Fornecedores WHERE Razao_social = '" + comboBoxFornecedorEditar.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    txtCNPJ.Text = reader.GetInt32(0).ToString();
                    txtRazao.Text = reader.GetString(1);
                    txtInsEstadual.Text = reader.GetInt32(2).ToString();
                    txtInsMunicipal.Text = reader.GetInt32(3).ToString();
                    txtNatureza.Text = reader.GetString(4);
                    txtRamo.Text = reader.GetString(5);
                    txtEndereco.Text = reader.GetString(6);
                    txtEmail.Text = reader.GetString(7);
                    txtTelefone.Text = reader.GetInt32(8).ToString();


                }
                ConStr.Close();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void updateFornecedor()
        {
            try
            {
                ConStr.Open();
                SqlCommand cmd = ConStr.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Fornecedores SET CNPJ = '" + int.Parse(txtCNPJ.Text) + "', Razao_social = '" + txtRazao.Text + "', inscri_estadual ='" + int.Parse(txtInsEstadual.Text) + "', insc_municipal = '" + int.Parse(txtInsMunicipal.Text) + "', Natureza_juridica = '" + txtNatureza.Text + "', Ramo_negocio = '" + txtRamo.Text + "', Endereco = '" + txtEndereco.Text + "', Email = '" + txtEndereco.Text + "', Telefone = '" + int.Parse(txtTelefone.Text) + "' WHERE Razao_social = '" + comboBoxFornecedorEditar.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();

                ConStr.Close();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void deleteFornecedor()
        {
            ConStr.Open();
            SqlCommand cmd = ConStr.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Fornecedores WHERE CNPJ = '" + int.Parse(txtCNPJ.Text) + "' ";
            cmd.ExecuteNonQuery();

            ConStr.Close();
        }

        

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo))
                {
                    deleteFornecedor();
                    Limpar();
                    preencherComboBox();

                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }

        private void Limpar()
        {
            try
            {
                txtCNPJ.Clear();
                txtRazao.Clear();
                txtInsEstadual.Clear();
                txtInsMunicipal.Clear();
                txtNatureza.Clear();
                txtRamo.Clear();
                txtEndereco.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }
    }
}
         