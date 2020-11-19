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
    public partial class FormRelatórios : Form
    {
        public FormRelatórios()
        {
            InitializeComponent();
        }

        private void FormRelatórios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postoDataSet2.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.postoDataSet2.Venda);


        }
    }
}
