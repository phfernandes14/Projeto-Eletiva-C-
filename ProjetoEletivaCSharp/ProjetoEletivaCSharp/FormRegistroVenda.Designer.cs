namespace ProjetoEletivaCSharp
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
            this.groupBoxRegistroVenda = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.groupBoxRegistroVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegistroVenda
            // 
            this.groupBoxRegistroVenda.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxRegistroVenda.Controls.Add(this.btn_limpar);
            this.groupBoxRegistroVenda.Controls.Add(this.btn_registrar);
            this.groupBoxRegistroVenda.Controls.Add(this.txt_quantidade);
            this.groupBoxRegistroVenda.Controls.Add(this.txt_valor);
            this.groupBoxRegistroVenda.Controls.Add(this.txt_item);
            this.groupBoxRegistroVenda.Controls.Add(this.lbl_quantidade);
            this.groupBoxRegistroVenda.Controls.Add(this.lbl_valor);
            this.groupBoxRegistroVenda.Controls.Add(this.lbl_item);
            this.groupBoxRegistroVenda.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxRegistroVenda.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegistroVenda.Name = "groupBoxRegistroVenda";
            this.groupBoxRegistroVenda.Size = new System.Drawing.Size(370, 178);
            this.groupBoxRegistroVenda.TabIndex = 0;
            this.groupBoxRegistroVenda.TabStop = false;
            this.groupBoxRegistroVenda.Text = "Registro de Venda";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.Location = new System.Drawing.Point(244, 104);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(102, 55);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_registrar.Location = new System.Drawing.Point(244, 31);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(102, 55);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_quantidade.Location = new System.Drawing.Point(114, 126);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 26);
            this.txt_quantidade.TabIndex = 5;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_valor.Location = new System.Drawing.Point(68, 81);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 26);
            this.txt_valor.TabIndex = 4;
            // 
            // txt_item
            // 
            this.txt_item.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txt_item.Location = new System.Drawing.Point(62, 36);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(100, 26);
            this.txt_item.TabIndex = 3;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_quantidade.Location = new System.Drawing.Point(16, 129);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(92, 19);
            this.lbl_quantidade.TabIndex = 2;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_valor.Location = new System.Drawing.Point(16, 84);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(46, 19);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lbl_item.Location = new System.Drawing.Point(16, 39);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(40, 19);
            this.lbl_item.TabIndex = 0;
            this.lbl_item.Text = "Item";
            // 
            // FormRegistroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(394, 202);
            this.Controls.Add(this.groupBoxRegistroVenda);
            this.Name = "FormRegistroVenda";
            this.Text = "FormRegistroVenda";
            this.groupBoxRegistroVenda.ResumeLayout(false);
            this.groupBoxRegistroVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistroVenda;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_registrar;
    }
}