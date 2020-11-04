namespace ProjetoEletivaCSharp
{
    partial class FormCadastroProduto
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
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_cod_item = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_cod_item = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.groupBox_cadastro_produto = new System.Windows.Forms.GroupBox();
            this.groupBox_cadastro_produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(92, 96);
            this.lbl_item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(48, 24);
            this.lbl_item.TabIndex = 0;
            this.lbl_item.Text = "Item";
            this.lbl_item.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_cod_item
            // 
            this.lbl_cod_item.AutoSize = true;
            this.lbl_cod_item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_item.Location = new System.Drawing.Point(31, 52);
            this.lbl_cod_item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cod_item.Name = "lbl_cod_item";
            this.lbl_cod_item.Size = new System.Drawing.Size(145, 24);
            this.lbl_cod_item.TabIndex = 1;
            this.lbl_cod_item.Text = "Código do Item";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(84, 142);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(56, 24);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(65, 196);
            this.lbl_quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(113, 24);
            this.lbl_quantidade.TabIndex = 3;
            this.lbl_quantidade.Text = "Quantidade";
            this.lbl_quantidade.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_cod_item
            // 
            this.txt_cod_item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_item.Location = new System.Drawing.Point(239, 52);
            this.txt_cod_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cod_item.Name = "txt_cod_item";
            this.txt_cod_item.Size = new System.Drawing.Size(132, 30);
            this.txt_cod_item.TabIndex = 4;
            // 
            // txt_item
            // 
            this.txt_item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item.Location = new System.Drawing.Point(239, 98);
            this.txt_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(132, 30);
            this.txt_item.TabIndex = 5;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(239, 144);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(132, 30);
            this.txt_valor.TabIndex = 6;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(239, 196);
            this.txt_quantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(132, 30);
            this.txt_quantidade.TabIndex = 7;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(404, 76);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(127, 52);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(404, 149);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(127, 52);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // groupBox_cadastro_produto
            // 
            this.groupBox_cadastro_produto.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox_cadastro_produto.Controls.Add(this.txt_cod_item);
            this.groupBox_cadastro_produto.Controls.Add(this.btn_limpar);
            this.groupBox_cadastro_produto.Controls.Add(this.lbl_item);
            this.groupBox_cadastro_produto.Controls.Add(this.btn_cadastrar);
            this.groupBox_cadastro_produto.Controls.Add(this.lbl_cod_item);
            this.groupBox_cadastro_produto.Controls.Add(this.txt_quantidade);
            this.groupBox_cadastro_produto.Controls.Add(this.lbl_valor);
            this.groupBox_cadastro_produto.Controls.Add(this.txt_valor);
            this.groupBox_cadastro_produto.Controls.Add(this.lbl_quantidade);
            this.groupBox_cadastro_produto.Controls.Add(this.txt_item);
            this.groupBox_cadastro_produto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_cadastro_produto.Location = new System.Drawing.Point(16, 15);
            this.groupBox_cadastro_produto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_cadastro_produto.Name = "groupBox_cadastro_produto";
            this.groupBox_cadastro_produto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_cadastro_produto.Size = new System.Drawing.Size(568, 257);
            this.groupBox_cadastro_produto.TabIndex = 10;
            this.groupBox_cadastro_produto.TabStop = false;
            this.groupBox_cadastro_produto.Text = "Cadastro de Produto";
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(601, 289);
            this.Controls.Add(this.groupBox_cadastro_produto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCadastroProduto";
            this.Text = "Vendas";
            this.groupBox_cadastro_produto.ResumeLayout(false);
            this.groupBox_cadastro_produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_cod_item;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_cod_item;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.GroupBox groupBox_cadastro_produto;
    }
}