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
    public partial class FormEditarProduto : Form
    {
        public FormEditarProduto()
        {
            InitializeComponent();
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
        }
    }
}
