namespace ProjetoEletivaCSharp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdicionarProduto = new FontAwesome.Sharp.IconButton();
            this.iconButtonHome = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonAdministrador = new FontAwesome.Sharp.IconButton();
            this.iconButtonRelatorio = new FontAwesome.Sharp.IconButton();
            this.iconButtonVenda = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanelTxtBemvindo = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTxtBemVindo = new System.Windows.Forms.Label();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.flowLayoutPanelTxtBemvindo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.iconButtonHome);
            this.panelMenu.Controls.Add(this.iconPictureBox1);
            this.panelMenu.Controls.Add(this.iconButtonAdministrador);
            this.panelMenu.Controls.Add(this.iconButtonRelatorio);
            this.panelMenu.Controls.Add(this.iconButtonVenda);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 568);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSubMenu.Controls.Add(this.iconButton3);
            this.panelSubMenu.Controls.Add(this.iconButton2);
            this.panelSubMenu.Controls.Add(this.iconButtonAdicionarProduto);
            this.panelSubMenu.Location = new System.Drawing.Point(0, 353);
            this.panelSubMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(180, 94);
            this.panelSubMenu.TabIndex = 4;
            this.panelSubMenu.Visible = false;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 22;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(12, 56);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(168, 28);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "    Editar Preço";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 22;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(12, 28);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(168, 28);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "  Adicionar Fornecedor";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonAdicionarProduto
            // 
            this.iconButtonAdicionarProduto.FlatAppearance.BorderSize = 0;
            this.iconButtonAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdicionarProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdicionarProduto.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdicionarProduto.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.iconButtonAdicionarProduto.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdicionarProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdicionarProduto.IconSize = 22;
            this.iconButtonAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdicionarProduto.Location = new System.Drawing.Point(12, 0);
            this.iconButtonAdicionarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdicionarProduto.Name = "iconButtonAdicionarProduto";
            this.iconButtonAdicionarProduto.Rotation = 0D;
            this.iconButtonAdicionarProduto.Size = new System.Drawing.Size(168, 28);
            this.iconButtonAdicionarProduto.TabIndex = 0;
            this.iconButtonAdicionarProduto.Text = "Adicionar Produto";
            this.iconButtonAdicionarProduto.UseVisualStyleBackColor = true;
            this.iconButtonAdicionarProduto.Click += new System.EventHandler(this.iconButtonAdicionarProduto_Click);
            // 
            // iconButtonHome
            // 
            this.iconButtonHome.FlatAppearance.BorderSize = 0;
            this.iconButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHome.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHome.IconColor = System.Drawing.Color.Black;
            this.iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHome.IconSize = 25;
            this.iconButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.Location = new System.Drawing.Point(0, 212);
            this.iconButtonHome.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonHome.Name = "iconButtonHome";
            this.iconButtonHome.Rotation = 0D;
            this.iconButtonHome.Size = new System.Drawing.Size(180, 35);
            this.iconButtonHome.TabIndex = 3;
            this.iconButtonHome.Text = "    Inicio";
            this.iconButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHome.UseVisualStyleBackColor = true;
            this.iconButtonHome.Click += new System.EventHandler(this.iconButtonHome_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.GasPump;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 67;
            this.iconPictureBox1.Location = new System.Drawing.Point(54, 33);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(67, 76);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconButtonAdministrador
            // 
            this.iconButtonAdministrador.FlatAppearance.BorderSize = 0;
            this.iconButtonAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdministrador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdministrador.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.iconButtonAdministrador.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonAdministrador.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdministrador.IconSize = 25;
            this.iconButtonAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdministrador.Location = new System.Drawing.Point(0, 317);
            this.iconButtonAdministrador.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdministrador.Name = "iconButtonAdministrador";
            this.iconButtonAdministrador.Rotation = 0D;
            this.iconButtonAdministrador.Size = new System.Drawing.Size(180, 36);
            this.iconButtonAdministrador.TabIndex = 2;
            this.iconButtonAdministrador.Text = "    Administrador";
            this.iconButtonAdministrador.UseVisualStyleBackColor = true;
            this.iconButtonAdministrador.Click += new System.EventHandler(this.iconButtonAdministrador_Click);
            // 
            // iconButtonRelatorio
            // 
            this.iconButtonRelatorio.FlatAppearance.BorderSize = 0;
            this.iconButtonRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRelatorio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRelatorio.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.iconButtonRelatorio.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.iconButtonRelatorio.IconColor = System.Drawing.Color.Black;
            this.iconButtonRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRelatorio.IconSize = 25;
            this.iconButtonRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRelatorio.Location = new System.Drawing.Point(0, 282);
            this.iconButtonRelatorio.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonRelatorio.Name = "iconButtonRelatorio";
            this.iconButtonRelatorio.Rotation = 0D;
            this.iconButtonRelatorio.Size = new System.Drawing.Size(180, 35);
            this.iconButtonRelatorio.TabIndex = 1;
            this.iconButtonRelatorio.Text = "Relatórios";
            this.iconButtonRelatorio.UseVisualStyleBackColor = true;
            // 
            // iconButtonVenda
            // 
            this.iconButtonVenda.FlatAppearance.BorderSize = 0;
            this.iconButtonVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonVenda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonVenda.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonVenda.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonVenda.IconColor = System.Drawing.Color.Black;
            this.iconButtonVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonVenda.IconSize = 25;
            this.iconButtonVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVenda.Location = new System.Drawing.Point(0, 247);
            this.iconButtonVenda.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonVenda.Name = "iconButtonVenda";
            this.iconButtonVenda.Rotation = 0D;
            this.iconButtonVenda.Size = new System.Drawing.Size(180, 35);
            this.iconButtonVenda.TabIndex = 0;
            this.iconButtonVenda.Text = "    Vendas";
            this.iconButtonVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonVenda.UseVisualStyleBackColor = true;
            this.iconButtonVenda.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.iconPictureBox2);
            this.panelChildForm.Controls.Add(this.flowLayoutPanelTxtBemvindo);
            this.panelChildForm.Controls.Add(this.labelBemVindo);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(180, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(737, 568);
            this.panelChildForm.TabIndex = 1;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(157, 77);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(57, 56);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // flowLayoutPanelTxtBemvindo
            // 
            this.flowLayoutPanelTxtBemvindo.Controls.Add(this.labelTxtBemVindo);
            this.flowLayoutPanelTxtBemvindo.Location = new System.Drawing.Point(121, 209);
            this.flowLayoutPanelTxtBemvindo.Name = "flowLayoutPanelTxtBemvindo";
            this.flowLayoutPanelTxtBemvindo.Size = new System.Drawing.Size(465, 178);
            this.flowLayoutPanelTxtBemvindo.TabIndex = 1;
            // 
            // labelTxtBemVindo
            // 
            this.labelTxtBemVindo.AutoSize = true;
            this.labelTxtBemVindo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtBemVindo.Location = new System.Drawing.Point(3, 0);
            this.labelTxtBemVindo.Name = "labelTxtBemVindo";
            this.labelTxtBemVindo.Size = new System.Drawing.Size(458, 138);
            this.labelTxtBemVindo.TabIndex = 0;
            this.labelTxtBemVindo.Text = resources.GetString("labelTxtBemVindo.Text");
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.Location = new System.Drawing.Point(220, 63);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(254, 70);
            this.labelBemVindo.TabIndex = 0;
            this.labelBemVindo.Text = "Bem Vindo";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 568);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Tela Principal";
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.flowLayoutPanelTxtBemvindo.ResumeLayout(false);
            this.flowLayoutPanelTxtBemvindo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton iconButtonAdministrador;
        private FontAwesome.Sharp.IconButton iconButtonRelatorio;
        private FontAwesome.Sharp.IconButton iconButtonVenda;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTxtBemvindo;
        private System.Windows.Forms.Label labelTxtBemVindo;
        private System.Windows.Forms.Label labelBemVindo;
        private FontAwesome.Sharp.IconButton iconButtonHome;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButtonAdicionarProduto;
    }
}