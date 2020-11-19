namespace ProjetoEletivaCSharp
{
    partial class FormRelatórios
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
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelListaRelatórios = new System.Windows.Forms.Label();
            this.dataGridViewRelatorios = new System.Windows.Forms.DataGridView();
            this.postoDataSet2 = new ProjetoEletivaCSharp.PostoDataSet2();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new ProjetoEletivaCSharp.PostoDataSet2TableAdapters.VendaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(172, 22);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 56);
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            // 
            // labelListaRelatórios
            // 
            this.labelListaRelatórios.AutoSize = true;
            this.labelListaRelatórios.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaRelatórios.Location = new System.Drawing.Point(235, 8);
            this.labelListaRelatórios.Name = "labelListaRelatórios";
            this.labelListaRelatórios.Size = new System.Drawing.Size(228, 70);
            this.labelListaRelatórios.TabIndex = 6;
            this.labelListaRelatórios.Text = "Relatórios";
            // 
            // dataGridViewRelatorios
            // 
            this.dataGridViewRelatorios.AutoGenerateColumns = false;
            this.dataGridViewRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridViewRelatorios.DataSource = this.vendaBindingSource;
            this.dataGridViewRelatorios.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewRelatorios.Name = "dataGridViewRelatorios";
            this.dataGridViewRelatorios.Size = new System.Drawing.Size(697, 417);
            this.dataGridViewRelatorios.TabIndex = 5;
            // 
            // postoDataSet2
            // 
            this.postoDataSet2.DataSetName = "PostoDataSet2";
            this.postoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.postoDataSet2;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // FormRelatórios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 529);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelListaRelatórios);
            this.Controls.Add(this.dataGridViewRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelatórios";
            this.Text = "FormRelatórios";
            this.Load += new System.EventHandler(this.FormRelatórios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelListaRelatórios;
        private System.Windows.Forms.DataGridView dataGridViewRelatorios;
        private PostoDataSet2 postoDataSet2;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private PostoDataSet2TableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}