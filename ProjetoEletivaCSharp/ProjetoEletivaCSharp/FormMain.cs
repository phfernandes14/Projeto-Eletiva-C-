﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm( new FormRegistroVenda());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonAdministrador_Click(object sender, EventArgs e)
        {
            if(panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
            else
            {
                panelSubMenu.Visible = true;
            }
        }

        private void iconButtonAdicionarProduto_Click(object sender, EventArgs e)
        {
           openChildForm(new FormAdicionarProduto());
        }

        private void iconButtonHome_Click(object sender, EventArgs e)
        {
           if(activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCadastroFornecedores());
        }

        private void iconButtonEditarPreco_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditarProduto());
        }

        private void iconButtonEditarFornecedor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditarFornecedor());
        }
    }
}
