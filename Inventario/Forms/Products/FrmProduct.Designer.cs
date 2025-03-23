namespace Inventario.Forms.Products
{
	partial class FrmProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
			this.grbProdutos = new System.Windows.Forms.GroupBox();
			this.cmbCompanies = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbCategories = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txbFeatures = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txbPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txbQuantidade = new System.Windows.Forms.TextBox();
			this.grbProdutos.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbProdutos
			// 
			this.grbProdutos.Controls.Add(this.txbQuantidade);
			this.grbProdutos.Controls.Add(this.label6);
			this.grbProdutos.Controls.Add(this.txbPrice);
			this.grbProdutos.Controls.Add(this.label5);
			this.grbProdutos.Controls.Add(this.txbFeatures);
			this.grbProdutos.Controls.Add(this.label4);
			this.grbProdutos.Controls.Add(this.cmbCompanies);
			this.grbProdutos.Controls.Add(this.label3);
			this.grbProdutos.Controls.Add(this.cmbCategories);
			this.grbProdutos.Controls.Add(this.label2);
			this.grbProdutos.Controls.Add(this.txbProductName);
			this.grbProdutos.Controls.Add(this.label1);
			this.grbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.grbProdutos.Location = new System.Drawing.Point(25, 25);
			this.grbProdutos.Name = "grbProdutos";
			this.grbProdutos.Size = new System.Drawing.Size(480, 273);
			this.grbProdutos.TabIndex = 0;
			this.grbProdutos.TabStop = false;
			this.grbProdutos.Text = "Informação do Produto";
			// 
			// cmbCompanies
			// 
			this.cmbCompanies.FormattingEnabled = true;
			this.cmbCompanies.Location = new System.Drawing.Point(164, 238);
			this.cmbCompanies.Name = "cmbCompanies";
			this.cmbCompanies.Size = new System.Drawing.Size(297, 23);
			this.cmbCompanies.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Empresa";
			// 
			// cmbCategories
			// 
			this.cmbCategories.FormattingEnabled = true;
			this.cmbCategories.Location = new System.Drawing.Point(164, 209);
			this.cmbCategories.Name = "cmbCategories";
			this.cmbCategories.Size = new System.Drawing.Size(297, 23);
			this.cmbCategories.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Categoria";
			// 
			// txbProductName
			// 
			this.txbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.txbProductName.Location = new System.Drawing.Point(166, 31);
			this.txbProductName.Name = "txbProductName";
			this.txbProductName.Size = new System.Drawing.Size(297, 23);
			this.txbProductName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome do Produto";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSalvar);
			this.groupBox1.Controls.Add(this.btnNovo);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(304, 304);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(201, 59);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btnSalvar.Location = new System.Drawing.Point(104, 14);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(85, 32);
			this.btnSalvar.TabIndex = 8;
			this.btnSalvar.Text = "&Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnNovo
			// 
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btnNovo.Location = new System.Drawing.Point(13, 14);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(85, 32);
			this.btnNovo.TabIndex = 7;
			this.btnNovo.Text = "&Limpar";
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Caracteristicas";
			// 
			// txbFeatures
			// 
			this.txbFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.txbFeatures.Location = new System.Drawing.Point(165, 65);
			this.txbFeatures.Multiline = true;
			this.txbFeatures.Name = "txbFeatures";
			this.txbFeatures.Size = new System.Drawing.Size(297, 84);
			this.txbFeatures.TabIndex = 2;
			this.txbFeatures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Preço";
			// 
			// txbPrice
			// 
			this.txbPrice.Location = new System.Drawing.Point(166, 155);
			this.txbPrice.MaxLength = 13;
			this.txbPrice.Name = "txbPrice";
			this.txbPrice.Size = new System.Drawing.Size(296, 21);
			this.txbPrice.TabIndex = 3;
			this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
			this.txbPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPrice_KeyUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "Quantidade";
			// 
			// txbQuantidade
			// 
			this.txbQuantidade.Location = new System.Drawing.Point(165, 182);
			this.txbQuantidade.MaxLength = 5;
			this.txbQuantidade.Name = "txbQuantidade";
			this.txbQuantidade.Size = new System.Drawing.Size(296, 21);
			this.txbQuantidade.TabIndex = 4;
			this.txbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantidade_KeyPress);
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(524, 369);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbProdutos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FrmProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Produtos";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProduct_FormClosed);
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			this.grbProdutos.ResumeLayout(false);
			this.grbProdutos.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbProdutos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbCompanies;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbCategories;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txbFeatures;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbPrice;
		private System.Windows.Forms.TextBox txbQuantidade;
		private System.Windows.Forms.Label label6;
	}
}