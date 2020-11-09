using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEletivaCSharp
{
    public partial class FormCadastroFornecedores : Form
    {
        public FormCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void bttnLimpar_Click(object sender, EventArgs e)
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
    }
}
