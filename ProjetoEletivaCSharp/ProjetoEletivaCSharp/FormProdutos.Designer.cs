namespace ProjetoEletivaCSharp
{
    partial class FormProdutos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelListaProdutos = new System.Windows.Forms.Label();
            this.postoDataSet2 = new ProjetoEletivaCSharp.PostoDataSet2();
            this.postoDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new ProjetoEletivaCSharp.PostoDataSet2TableAdapters.ProdutosTableAdapter();
            this.iditemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AutoGenerateColumns = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iditemDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.valorCompraDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorVendaDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn});
            this.dataGridViewProdutos.DataSource = this.produtosBindingSource;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(697, 417);
            this.dataGridViewProdutos.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(123, 25);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 56);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // labelListaProdutos
            // 
            this.labelListaProdutos.AutoSize = true;
            this.labelListaProdutos.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaProdutos.Location = new System.Drawing.Point(186, 11);
            this.labelListaProdutos.Name = "labelListaProdutos";
            this.labelListaProdutos.Size = new System.Drawing.Size(385, 70);
            this.labelListaProdutos.TabIndex = 3;
            this.labelListaProdutos.Text = "Lista de Produtos";
            // 
            // postoDataSet2
            // 
            this.postoDataSet2.DataSetName = "PostoDataSet2";
            this.postoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postoDataSet2BindingSource
            // 
            this.postoDataSet2BindingSource.DataSource = this.postoDataSet2;
            this.postoDataSet2BindingSource.Position = 0;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.postoDataSet2BindingSource;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // iditemDataGridViewTextBoxColumn
            // 
            this.iditemDataGridViewTextBoxColumn.DataPropertyName = "Id_item";
            this.iditemDataGridViewTextBoxColumn.HeaderText = "Id_item";
            this.iditemDataGridViewTextBoxColumn.Name = "iditemDataGridViewTextBoxColumn";
            this.iditemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            this.valorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra";
            this.valorCompraDataGridViewTextBoxColumn.HeaderText = "ValorCompra";
            this.valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            this.valorCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorVendaDataGridViewTextBoxColumn
            // 
            this.valorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda";
            this.valorVendaDataGridViewTextBoxColumn.HeaderText = "ValorVenda";
            this.valorVendaDataGridViewTextBoxColumn.Name = "valorVendaDataGridViewTextBoxColumn";
            this.valorVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 529);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelListaProdutos);
            this.Controls.Add(this.dataGridViewProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelListaProdutos;
        private System.Windows.Forms.BindingSource postoDataSet2BindingSource;
        private PostoDataSet2 postoDataSet2;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private PostoDataSet2TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
    }
}