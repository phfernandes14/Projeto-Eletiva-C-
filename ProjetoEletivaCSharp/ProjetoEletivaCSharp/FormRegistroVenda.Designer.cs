﻿namespace ProjetoEletivaCSharp
{
    partial class FormRegistroVenda
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
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelAviso = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.btnTroco = new System.Windows.Forms.Button();
            this.txtIdtem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(169, 264);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_quantidade.Location = new System.Drawing.Point(71, 267);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(92, 19);
            this.lbl_quantidade.TabIndex = 2;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_valor.Location = new System.Drawing.Point(21, 28);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(110, 19);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "Valor a Pagar:";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_item.Location = new System.Drawing.Point(71, 149);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(40, 19);
            this.lbl_item.TabIndex = 0;
            this.lbl_item.Text = "Item";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 43;
            this.iconPictureBox1.Location = new System.Drawing.Point(247, 50);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 43);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.Location = new System.Drawing.Point(289, 32);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(156, 70);
            this.labelBemVindo.TabIndex = 24;
            this.labelBemVindo.Text = "Venda";
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLimpar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpar.Location = new System.Drawing.Point(467, 449);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(116, 30);
            this.bttnLimpar.TabIndex = 6;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.bttnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRegistrar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRegistrar.Location = new System.Drawing.Point(132, 449);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(116, 30);
            this.bttnRegistrar.TabIndex = 4;
            this.bttnRegistrar.Text = "Registrar";
            this.bttnRegistrar.UseVisualStyleBackColor = false;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTroco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblValorPagar);
            this.panel1.Controls.Add(this.lbl_valor);
            this.panel1.Location = new System.Drawing.Point(117, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 73);
            this.panel1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "R$";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(380, 29);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(36, 18);
            this.lblTroco.TabIndex = 4;
            this.lblTroco.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Troco:";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.Location = new System.Drawing.Point(160, 29);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(36, 18);
            this.lblValorPagar.TabIndex = 2;
            this.lblValorPagar.Text = "0,00";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtPago.Location = new System.Drawing.Point(169, 304);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 26);
            this.txtPago.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(71, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pago";
            // 
            // flowLayoutPanelAviso
            // 
            this.flowLayoutPanelAviso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelAviso.Controls.Add(this.label2);
            this.flowLayoutPanelAviso.Controls.Add(this.label4);
            this.flowLayoutPanelAviso.Location = new System.Drawing.Point(416, 190);
            this.flowLayoutPanelAviso.Name = "flowLayoutPanelAviso";
            this.flowLayoutPanelAviso.Size = new System.Drawing.Size(226, 135);
            this.flowLayoutPanelAviso.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 102);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item: selecione o item a ser vendido.\r\nQuantidade: digite a quantidade vendida.\r\n" +
    "Pago: digite o valor dado pelo cliente.";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lblEstoque.Location = new System.Drawing.Point(178, 226);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(18, 19);
            this.lblEstoque.TabIndex = 32;
            this.lblEstoque.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(71, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Em Estoque:";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(169, 151);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(100, 21);
            this.comboBoxItem.TabIndex = 0;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(225, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Valor Unitario:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lblValorUnitario.Location = new System.Drawing.Point(332, 226);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(18, 19);
            this.lblValorUnitario.TabIndex = 35;
            this.lblValorUnitario.Text = "0";
            // 
            // btnTroco
            // 
            this.btnTroco.BackColor = System.Drawing.Color.Transparent;
            this.btnTroco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroco.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroco.Location = new System.Drawing.Point(301, 449);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(126, 30);
            this.btnTroco.TabIndex = 5;
            this.btnTroco.Text = "Calcular Troco";
            this.btnTroco.UseVisualStyleBackColor = false;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // txtIdtem
            // 
            this.txtIdtem.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtIdtem.Location = new System.Drawing.Point(169, 189);
            this.txtIdtem.Name = "txtIdtem";
            this.txtIdtem.ReadOnly = true;
            this.txtIdtem.Size = new System.Drawing.Size(100, 26);
            this.txtIdtem.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(71, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Id do Item";
            // 
            // FormRegistroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 529);
            this.Controls.Add(this.txtIdtem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTroco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.flowLayoutPanelAviso);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.labelBemVindo);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_quantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistroVenda";
            this.Text = "FormRegistroVenda";
            this.Load += new System.EventHandler(this.FormRegistroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelAviso.ResumeLayout(false);
            this.flowLayoutPanelAviso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbl_quantidade;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelBemVindo;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAviso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Button btnTroco;
        private System.Windows.Forms.TextBox txtIdtem;
        private System.Windows.Forms.Label label9;
    }
}