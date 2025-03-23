namespace Inventario.Forms.Customers
{
	partial class FrmCustomers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
			this.grbClientsDetails = new System.Windows.Forms.GroupBox();
			this.grbBtnsActions = new System.Windows.Forms.GroupBox();
			this.btnClean = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txbObs = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.mktbMobilePhone = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.mktbPhone = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txbCep = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txbEstado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txbCity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txbReferency = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbEnd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbClientId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grbClientsDetails.SuspendLayout();
			this.grbBtnsActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbClientsDetails
			// 
			this.grbClientsDetails.Controls.Add(this.grbBtnsActions);
			this.grbClientsDetails.Controls.Add(this.txbObs);
			this.grbClientsDetails.Controls.Add(this.label11);
			this.grbClientsDetails.Controls.Add(this.mktbMobilePhone);
			this.grbClientsDetails.Controls.Add(this.label10);
			this.grbClientsDetails.Controls.Add(this.txbEmail);
			this.grbClientsDetails.Controls.Add(this.label9);
			this.grbClientsDetails.Controls.Add(this.mktbPhone);
			this.grbClientsDetails.Controls.Add(this.label8);
			this.grbClientsDetails.Controls.Add(this.txbCep);
			this.grbClientsDetails.Controls.Add(this.label7);
			this.grbClientsDetails.Controls.Add(this.txbEstado);
			this.grbClientsDetails.Controls.Add(this.label6);
			this.grbClientsDetails.Controls.Add(this.txbCity);
			this.grbClientsDetails.Controls.Add(this.label5);
			this.grbClientsDetails.Controls.Add(this.txbReferency);
			this.grbClientsDetails.Controls.Add(this.label4);
			this.grbClientsDetails.Controls.Add(this.txbEnd);
			this.grbClientsDetails.Controls.Add(this.label3);
			this.grbClientsDetails.Controls.Add(this.txbName);
			this.grbClientsDetails.Controls.Add(this.label2);
			this.grbClientsDetails.Controls.Add(this.txbClientId);
			this.grbClientsDetails.Controls.Add(this.label1);
			this.grbClientsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbClientsDetails.Location = new System.Drawing.Point(12, 12);
			this.grbClientsDetails.Name = "grbClientsDetails";
			this.grbClientsDetails.Size = new System.Drawing.Size(404, 493);
			this.grbClientsDetails.TabIndex = 0;
			this.grbClientsDetails.TabStop = false;
			this.grbClientsDetails.Text = "Detalhes do Cliente";
			// 
			// grbBtnsActions
			// 
			this.grbBtnsActions.Controls.Add(this.btnClean);
			this.grbBtnsActions.Controls.Add(this.btnSave);
			this.grbBtnsActions.Location = new System.Drawing.Point(191, 412);
			this.grbBtnsActions.Name = "grbBtnsActions";
			this.grbBtnsActions.Size = new System.Drawing.Size(201, 66);
			this.grbBtnsActions.TabIndex = 21;
			this.grbBtnsActions.TabStop = false;
			// 
			// btnClean
			// 
			this.btnClean.Location = new System.Drawing.Point(102, 22);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new System.Drawing.Size(90, 30);
			this.btnClean.TabIndex = 1;
			this.btnClean.Text = "Limpar";
			this.btnClean.UseVisualStyleBackColor = true;
			this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(6, 22);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(90, 30);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Salvar";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txbObs
			// 
			this.txbObs.Location = new System.Drawing.Point(99, 339);
			this.txbObs.MaxLength = 2048;
			this.txbObs.Multiline = true;
			this.txbObs.Name = "txbObs";
			this.txbObs.Size = new System.Drawing.Size(293, 67);
			this.txbObs.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(9, 338);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 17);
			this.label11.TabIndex = 20;
			this.label11.Text = "Obs.:";
			// 
			// mktbMobilePhone
			// 
			this.mktbMobilePhone.Location = new System.Drawing.Point(99, 281);
			this.mktbMobilePhone.Mask = "(99) 0 0000-0000";
			this.mktbMobilePhone.Name = "mktbMobilePhone";
			this.mktbMobilePhone.Size = new System.Drawing.Size(293, 23);
			this.mktbMobilePhone.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 281);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 17);
			this.label10.TabIndex = 18;
			this.label10.Text = "*Celular";
			// 
			// txbEmail
			// 
			this.txbEmail.Location = new System.Drawing.Point(99, 310);
			this.txbEmail.MaxLength = 128;
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(293, 23);
			this.txbEmail.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 310);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 17);
			this.label9.TabIndex = 16;
			this.label9.Text = "Email";
			// 
			// mktbPhone
			// 
			this.mktbPhone.Location = new System.Drawing.Point(99, 252);
			this.mktbPhone.Mask = "(99) 0000-0000";
			this.mktbPhone.Name = "mktbPhone";
			this.mktbPhone.Size = new System.Drawing.Size(293, 23);
			this.mktbPhone.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 252);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Telefone";
			// 
			// txbCep
			// 
			this.txbCep.Location = new System.Drawing.Point(99, 223);
			this.txbCep.MaxLength = 9;
			this.txbCep.Name = "txbCep";
			this.txbCep.Size = new System.Drawing.Size(293, 23);
			this.txbCep.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 223);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Cep";
			// 
			// txbEstado
			// 
			this.txbEstado.Location = new System.Drawing.Point(99, 194);
			this.txbEstado.MaxLength = 32;
			this.txbEstado.Name = "txbEstado";
			this.txbEstado.Size = new System.Drawing.Size(293, 23);
			this.txbEstado.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "*Estado";
			// 
			// txbCity
			// 
			this.txbCity.Location = new System.Drawing.Point(99, 165);
			this.txbCity.MaxLength = 64;
			this.txbCity.Name = "txbCity";
			this.txbCity.Size = new System.Drawing.Size(293, 23);
			this.txbCity.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "*Cidade";
			// 
			// txbReferency
			// 
			this.txbReferency.Location = new System.Drawing.Point(99, 136);
			this.txbReferency.MaxLength = 512;
			this.txbReferency.Name = "txbReferency";
			this.txbReferency.Size = new System.Drawing.Size(293, 23);
			this.txbReferency.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Referência";
			// 
			// txbEnd
			// 
			this.txbEnd.Location = new System.Drawing.Point(99, 107);
			this.txbEnd.MaxLength = 512;
			this.txbEnd.Name = "txbEnd";
			this.txbEnd.Size = new System.Drawing.Size(293, 23);
			this.txbEnd.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "*Endereço";
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(99, 75);
			this.txbName.MaxLength = 128;
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(293, 23);
			this.txbName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "*Nome";
			// 
			// txbClientId
			// 
			this.txbClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbClientId.Enabled = false;
			this.txbClientId.Location = new System.Drawing.Point(99, 43);
			this.txbClientId.Name = "txbClientId";
			this.txbClientId.Size = new System.Drawing.Size(293, 23);
			this.txbClientId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Client ID";
			// 
			// FrmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(429, 513);
			this.Controls.Add(this.grbClientsDetails);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmCustomers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Novo Cliente";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomers_FormClosing);
			this.grbClientsDetails.ResumeLayout(false);
			this.grbClientsDetails.PerformLayout();
			this.grbBtnsActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbClientsDetails;
		private System.Windows.Forms.MaskedTextBox mktbPhone;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txbCep;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txbEstado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txbCity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txbReferency;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbEnd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbClientId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grbBtnsActions;
		private System.Windows.Forms.Button btnClean;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txbObs;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.MaskedTextBox mktbMobilePhone;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.Label label9;
	}
}