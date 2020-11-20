namespace ProjetoEletivaCSharp
{
    partial class FormEditarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelEditarProduto = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelValorCompra = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelAviso = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGuia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.bttnSalvar = new System.Windows.Forms.Button();
            this.comboProdutoEditar = new System.Windows.Forms.ComboBox();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.flowLayoutPanelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(116, 37);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 56);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // labelEditarProduto
            // 
            this.labelEditarProduto.AutoSize = true;
            this.labelEditarProduto.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarProduto.Location = new System.Drawing.Point(179, 23);
            this.labelEditarProduto.Name = "labelEditarProduto";
            this.labelEditarProduto.Size = new System.Drawing.Size(336, 70);
            this.labelEditarProduto.TabIndex = 5;
            this.labelEditarProduto.Text = "Editar Produto";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(191, 275);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtValorCompra.TabIndex = 3;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(191, 313);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 240);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // labelValorCompra
            // 
            this.labelValorCompra.AutoSize = true;
            this.labelValorCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelValorCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelValorCompra.Location = new System.Drawing.Point(50, 273);
            this.labelValorCompra.Name = "labelValorCompra";
            this.labelValorCompra.Size = new System.Drawing.Size(130, 19);
            this.labelValorCompra.TabIndex = 17;
            this.labelValorCompra.Text = "Valor de Compra";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelValorVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelValorVenda.Location = new System.Drawing.Point(50, 313);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(118, 19);
            this.labelValorVenda.TabIndex = 16;
            this.labelValorVenda.Text = "Valor de Venda";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFornecedor.Location = new System.Drawing.Point(50, 382);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(91, 19);
            this.labelFornecedor.TabIndex = 15;
            this.labelFornecedor.Text = "Fornecedor";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNome.Location = new System.Drawing.Point(50, 238);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 19);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(200, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Produto a Editar";
            // 
            // flowLayoutPanelAviso
            // 
            this.flowLayoutPanelAviso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelAviso.Controls.Add(this.labelGuia);
            this.flowLayoutPanelAviso.Controls.Add(this.label2);
            this.flowLayoutPanelAviso.Location = new System.Drawing.Point(409, 245);
            this.flowLayoutPanelAviso.Name = "flowLayoutPanelAviso";
            this.flowLayoutPanelAviso.Size = new System.Drawing.Size(232, 126);
            this.flowLayoutPanelAviso.TabIndex = 27;
            // 
            // labelGuia
            // 
            this.labelGuia.AutoSize = true;
            this.labelGuia.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuia.Location = new System.Drawing.Point(3, 0);
            this.labelGuia.Name = "labelGuia";
            this.labelGuia.Size = new System.Drawing.Size(42, 21);
            this.labelGuia.TabIndex = 1;
            this.labelGuia.Text = "Guia";
            this.labelGuia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 85);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\nSelecione o produto a ser editado no campo \"Produto a Editar\", modifique os cam" +
    "po que deseja alterar e clique em salvar.";
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLimpar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpar.Location = new System.Drawing.Point(320, 452);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(116, 30);
            this.bttnLimpar.TabIndex = 8;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // bttnSalvar
            // 
            this.bttnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.bttnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalvar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalvar.Location = new System.Drawing.Point(166, 452);
            this.bttnSalvar.Name = "bttnSalvar";
            this.bttnSalvar.Size = new System.Drawing.Size(116, 30);
            this.bttnSalvar.TabIndex = 7;
            this.bttnSalvar.Text = "Salvar";
            this.bttnSalvar.UseVisualStyleBackColor = false;
            this.bttnSalvar.Click += new System.EventHandler(this.bttnSalvar_Click);
            // 
            // comboProdutoEditar
            // 
            this.comboProdutoEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProdutoEditar.FormattingEnabled = true;
            this.comboProdutoEditar.Location = new System.Drawing.Point(345, 151);
            this.comboProdutoEditar.Name = "comboProdutoEditar";
            this.comboProdutoEditar.Size = new System.Drawing.Size(121, 21);
            this.comboProdutoEditar.TabIndex = 0;
            this.comboProdutoEditar.SelectedIndexChanged += new System.EventHandler(this.comboProdutoEditar_SelectedIndexChanged);
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(191, 382);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFornecedor.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(191, 352);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelQuantidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelQuantidade.Location = new System.Drawing.Point(50, 352);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(92, 19);
            this.labelQuantidade.TabIndex = 32;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(191, 209);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(50, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID";
            // 
            // FormEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 568);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.comboBoxFornecedor);
            this.Controls.Add(this.comboProdutoEditar);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnSalvar);
            this.Controls.Add(this.flowLayoutPanelAviso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelValorCompra);
            this.Controls.Add(this.labelValorVenda);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelEditarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarProduto";
            this.Text = "EditarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.flowLayoutPanelAviso.ResumeLayout(false);
            this.flowLayoutPanelAviso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelEditarProduto;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelValorCompra;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAviso;
        private System.Windows.Forms.Label labelGuia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.Button bttnSalvar;
        private System.Windows.Forms.ComboBox comboProdutoEditar;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}