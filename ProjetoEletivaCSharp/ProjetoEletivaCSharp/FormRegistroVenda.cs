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
    public partial class FormRegistroVenda : Form
    {
        public FormRegistroVenda()
        {
            InitializeComponent();
        }

        private void FormRegistroVenda_Load(object sender, EventArgs e)
        {

        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            txtItem.Clear();
            txtQuantidade.Clear();
            txtPago.Clear();
        }
    }
}
