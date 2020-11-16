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
    public partial class FormEditarFornecedor : Form
    {
        struct FichaFornecedor
        {
            int CPNJ;
            string razao;
            int inscriEstadual;
            int inscriMunicipal;
            string natureza;
            string ramo;
            string endereco;
            string email;
            int telefone;

        }

        public FormEditarFornecedor()
        {
            InitializeComponent();
        }

        private void bttnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
