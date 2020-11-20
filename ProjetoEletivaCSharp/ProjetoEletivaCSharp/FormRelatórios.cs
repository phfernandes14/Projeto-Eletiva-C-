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
    public partial class FormRelatórios : Form
    {
        public FormRelatórios()
        {
            InitializeComponent();
        }

        private void FormRelatórios_Load(object sender, EventArgs e)
        {
            
            
            string varStrCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Posto.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection objConexao = new SqlConnection(varStrCon);
            objConexao.Open();

            string consulta = "select * from Venda";
            SqlDataAdapter objComando = new SqlDataAdapter(consulta, objConexao);
            DataSet ds = new DataSet();
            objComando.Fill(ds);
            dataGridViewRelatorios.DataSource = ds.Tables[0];


        }
    }
}
