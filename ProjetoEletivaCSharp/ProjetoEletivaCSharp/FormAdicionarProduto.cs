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
    public partial class FormAdicionarProduto : Form
    {
        public FormAdicionarProduto()
        {
            InitializeComponent();
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            txtFornecedor.Clear();
            txtNome.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
        }
    }
}
