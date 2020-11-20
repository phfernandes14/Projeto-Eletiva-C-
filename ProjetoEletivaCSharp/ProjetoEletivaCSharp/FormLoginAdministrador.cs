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
    public partial class FormLoginAdministrador : Form
    {
        public FormLoginAdministrador()
        {
            InitializeComponent();
        }

        public int teste { get; set; }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            try
            {
                FormMain formMain = new FormMain();
                if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
                {
                    (this.Owner as FormMain).panelSubMenu.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretor");

                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado");
            }
        }
    }
}
