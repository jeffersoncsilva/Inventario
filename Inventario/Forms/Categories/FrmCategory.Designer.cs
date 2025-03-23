namespace Inventario.Forms.Categories
{
	partial class FrmCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
			this.tbNewCategory = new System.Windows.Forms.TabControl();
			this.tabNewCategory = new System.Windows.Forms.TabPage();
			this.btnClearFields = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txbDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbCategoryName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabListCategories = new System.Windows.Forms.TabPage();
			this.btnRemoveCategory = new System.Windows.Forms.Button();
			this.btnSalvarAlteracao = new System.Windows.Forms.Button();
			this.grdCategories = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbNewCategory.SuspendLayout();
			this.tabNewCategory.SuspendLayout();
			this.tabListCategories.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
			this.SuspendLayout();
			// 
			// tbNewCategory
			// 
			this.tbNewCategory.Controls.Add(this.tabNewCategory);
			this.tbNewCategory.Controls.Add(this.tabListCategories);
			this.tbNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNewCategory.Location = new System.Drawing.Point(12, 12);
			this.tbNewCategory.Name = "tbNewCategory";
			this.tbNewCategory.SelectedIndex = 0;
			this.tbNewCategory.Size = new System.Drawing.Size(707, 426);
			this.tbNewCategory.TabIndex = 0;
			this.tbNewCategory.SelectedIndexChanged += new System.EventHandler(this.tbNewCategory_SelectedIndexChanged);
			// 
			// tabNewCategory
			// 
			this.tabNewCategory.Controls.Add(this.label4);
			this.tabNewCategory.Controls.Add(this.label3);
			this.tabNewCategory.Controls.Add(this.btnClearFields);
			this.tabNewCategory.Controls.Add(this.btnSave);
			this.tabNewCategory.Controls.Add(this.txbDescription);
			this.tabNewCategory.Controls.Add(this.label2);
			this.tabNewCategory.Controls.Add(this.txbCategoryName);
			this.tabNewCategory.Controls.Add(this.label1);
			this.tabNewCategory.Location = new System.Drawing.Point(4, 24);
			this.tabNewCategory.Name = "tabNewCategory";
			this.tabNewCategory.Padding = new System.Windows.Forms.Padding(3);
			this.tabNewCategory.Size = new System.Drawing.Size(699, 398);
			this.tabNewCategory.TabIndex = 0;
			this.tabNewCategory.Text = "Nova Categoria";
			this.tabNewCategory.UseVisualStyleBackColor = true;
			// 
			// btnClearFields
			// 
			this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFields.Location = new System.Drawing.Point(386, 289);
			this.btnClearFields.Name = "btnClearFields";
			this.btnClearFields.Size = new System.Drawing.Size(90, 35);
			this.btnClearFields.TabIndex = 5;
			this.btnClearFields.Text = "Limpar";
			this.btnClearFields.UseVisualStyleBackColor = true;
			this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(175, 267);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(138, 57);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Salvar Cadastro";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txbDescription
			// 
			this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbDescription.Location = new System.Drawing.Point(175, 128);
			this.txbDescription.MaxLength = 2048;
			this.txbDescription.Multiline = true;
			this.txbDescription.Name = "txbDescription";
			this.txbDescription.Size = new System.Drawing.Size(301, 110);
			this.txbDescription.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 18);
			this.label2.TabIndex = 2;
			// 
			// txbCategoryName
			// 
			this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbCategoryName.Location = new System.Drawing.Point(175, 62);
			this.txbCategoryName.Name = "txbCategoryName";
			this.txbCategoryName.Size = new System.Drawing.Size(301, 24);
			this.txbCategoryName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 18);
			this.label1.TabIndex = 0;
			// 
			// tabListCategories
			// 
			this.tabListCategories.Controls.Add(this.btnRemoveCategory);
			this.tabListCategories.Controls.Add(this.btnSalvarAlteracao);
			this.tabListCategories.Controls.Add(this.grdCategories);
			this.tabListCategories.Location = new System.Drawing.Point(4, 24);
			this.tabListCategories.Name = "tabListCategories";
			this.tabListCategories.Padding = new System.Windows.Forms.Padding(3);
			this.tabListCategories.Size = new System.Drawing.Size(699, 398);
			this.tabListCategories.TabIndex = 1;
			this.tabListCategories.Text = "Listar Categorias";
			this.tabListCategories.UseVisualStyleBackColor = true;
			// 
			// btnRemoveCategory
			// 
			this.btnRemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveCategory.Location = new System.Drawing.Point(540, 121);
			this.btnRemoveCategory.Name = "btnRemoveCategory";
			this.btnRemoveCategory.Size = new System.Drawing.Size(153, 52);
			this.btnRemoveCategory.TabIndex = 2;
			this.btnRemoveCategory.Text = "Apagar Selecionado";
			this.btnRemoveCategory.UseVisualStyleBackColor = true;
			this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
			// 
			// btnSalvarAlteracao
			// 
			this.btnSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvarAlteracao.Location = new System.Drawing.Point(540, 63);
			this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
			this.btnSalvarAlteracao.Size = new System.Drawing.Size(153, 52);
			this.btnSalvarAlteracao.TabIndex = 1;
			this.btnSalvarAlteracao.Text = "Salvar Alteração";
			this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
			this.btnSalvarAlteracao.Click += new System.EventHandler(this.btnSalvarAlteracao_Click);
			// 
			// grdCategories
			// 
			this.grdCategories.AllowUserToAddRows = false;
			this.grdCategories.AllowUserToDeleteRows = false;
			this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Description});
			this.grdCategories.Location = new System.Drawing.Point(6, 6);
			this.grdCategories.Name = "grdCategories";
			this.grdCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdCategories.Size = new System.Drawing.Size(528, 386);
			this.grdCategories.TabIndex = 0;
			this.grdCategories.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellValueChanged);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.MaxInputLength = 12;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Id.Width = 30;
			// 
			// Nome
			// 
			this.Nome.DataPropertyName = "Name";
			this.Nome.HeaderText = "Nome";
			this.Nome.MaxInputLength = 128;
			this.Nome.Name = "Nome";
			this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Nome.Width = 130;
			// 
			// Description
			// 
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "Descrição";
			this.Description.Name = "Description";
			this.Description.Width = 330;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nome Categoria:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Descrição Categoria:";
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(727, 450);
			this.Controls.Add(this.tbNewCategory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(15, 15);
			this.Name = "FrmCategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.tbNewCategory.ResumeLayout(false);
			this.tabNewCategory.ResumeLayout(false);
			this.tabNewCategory.PerformLayout();
			this.tabListCategories.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.TabPage tabListCategories;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridView grdCategories;
		private System.Windows.Forms.Button btnSalvarAlteracao;
		private System.Windows.Forms.Button btnRemoveCategory;

		#endregion

		private System.Windows.Forms.TabControl tbNewCategory;
		private System.Windows.Forms.TabPage tabNewCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txbDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbCategoryName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}