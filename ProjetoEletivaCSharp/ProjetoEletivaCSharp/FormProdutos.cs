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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postoDataSet2.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.postoDataSet2.Produtos);




        }
    }
}
