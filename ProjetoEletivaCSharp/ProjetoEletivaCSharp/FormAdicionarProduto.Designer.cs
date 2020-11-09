namespace ProjetoEletivaCSharp
{
    partial class FormAdicionarProduto
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
            this.labelAdicionarProduto = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelValorCompra = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.bttnCadastrar = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.flowLayoutPanelAviso = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGuia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.flowLayoutPanelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(95, 58);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 56);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // labelAdicionarProduto
            // 
            this.labelAdicionarProduto.AutoSize = true;
            this.labelAdicionarProduto.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdicionarProduto.Location = new System.Drawing.Point(158, 44);
            this.labelAdicionarProduto.Name = "labelAdicionarProduto";
            this.labelAdicionarProduto.Size = new System.Drawing.Size(403, 70);
            this.labelAdicionarProduto.TabIndex = 3;
            this.labelAdicionarProduto.Text = "Adicionar Produto";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNome.Location = new System.Drawing.Point(46, 189);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 19);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFornecedor.Location = new System.Drawing.Point(46, 300);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(91, 19);
            this.labelFornecedor.TabIndex = 7;
            this.labelFornecedor.Text = "Fornecedor";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelValorVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelValorVenda.Location = new System.Drawing.Point(46, 264);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(118, 19);
            this.labelValorVenda.TabIndex = 8;
            this.labelValorVenda.Text = "Valor de Venda";
            // 
            // labelValorCompra
            // 
            this.labelValorCompra.AutoSize = true;
            this.labelValorCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.labelValorCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelValorCompra.Location = new System.Drawing.Point(46, 224);
            this.labelValorCompra.Name = "labelValorCompra";
            this.labelValorCompra.Size = new System.Drawing.Size(130, 19);
            this.labelValorCompra.TabIndex = 9;
            this.labelValorCompra.Text = "Valor de Compra";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(187, 191);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(187, 302);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 11;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(187, 264);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 12;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(187, 226);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtValorCompra.TabIndex = 13;
            // 
            // bttnCadastrar
            // 
            this.bttnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCadastrar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCadastrar.Location = new System.Drawing.Point(170, 389);
            this.bttnCadastrar.Name = "bttnCadastrar";
            this.bttnCadastrar.Size = new System.Drawing.Size(116, 30);
            this.bttnCadastrar.TabIndex = 21;
            this.bttnCadastrar.Text = "Cadastrar";
            this.bttnCadastrar.UseVisualStyleBackColor = true;
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLimpar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpar.Location = new System.Drawing.Point(354, 389);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(116, 30);
            this.bttnLimpar.TabIndex = 22;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // flowLayoutPanelAviso
            // 
            this.flowLayoutPanelAviso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelAviso.Controls.Add(this.labelGuia);
            this.flowLayoutPanelAviso.Controls.Add(this.label1);
            this.flowLayoutPanelAviso.Location = new System.Drawing.Point(399, 206);
            this.flowLayoutPanelAviso.Name = "flowLayoutPanelAviso";
            this.flowLayoutPanelAviso.Size = new System.Drawing.Size(232, 88);
            this.flowLayoutPanelAviso.TabIndex = 26;
            // 
            // labelGuia
            // 
            this.labelGuia.AutoSize = true;
            this.labelGuia.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuia.Location = new System.Drawing.Point(3, 0);
            this.labelGuia.Name = "labelGuia";
            this.labelGuia.Size = new System.Drawing.Size(48, 21);
            this.labelGuia.TabIndex = 1;
            this.labelGuia.Text = "Aviso";
            this.labelGuia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nLembre-se que todos os campos são obrigatórios.";
            // 
            // FormAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 529);
            this.Controls.Add(this.flowLayoutPanelAviso);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnCadastrar);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelValorCompra);
            this.Controls.Add(this.labelValorVenda);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelAdicionarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdicionarProduto";
            this.Text = "AdicionarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.flowLayoutPanelAviso.ResumeLayout(false);
            this.flowLayoutPanelAviso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelAdicionarProduto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelValorVenda;
        private System.Windows.Forms.Label labelValorCompra;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Button bttnCadastrar;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAviso;
        private System.Windows.Forms.Label labelGuia;
        private System.Windows.Forms.Label label1;
    }
}