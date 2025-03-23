namespace Inventario.Forms.Account
{
	partial class FrmNewUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewUser));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mktbPhone = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblIsLoginOk = new System.Windows.Forms.Label();
			this.txbLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.BtnClearFields = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txbEmail);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.mktbPhone);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txbUserName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txbPassword);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblIsLoginOk);
			this.groupBox1.Controls.Add(this.txbLogin);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(560, 225);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detalhes do Usuário";
			// 
			// txbEmail
			// 
			this.txbEmail.Location = new System.Drawing.Point(96, 186);
			this.txbEmail.MaxLength = 128;
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(276, 23);
			this.txbEmail.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Email";
			// 
			// mktbPhone
			// 
			this.mktbPhone.Location = new System.Drawing.Point(96, 152);
			this.mktbPhone.Mask = "(00) 0 0000-0000";
			this.mktbPhone.Name = "mktbPhone";
			this.mktbPhone.Size = new System.Drawing.Size(276, 23);
			this.mktbPhone.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefone";
			// 
			// txbUserName
			// 
			this.txbUserName.Location = new System.Drawing.Point(96, 110);
			this.txbUserName.MaxLength = 128;
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(276, 23);
			this.txbUserName.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nome";
			// 
			// txbPassword
			// 
			this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbPassword.Location = new System.Drawing.Point(96, 74);
			this.txbPassword.MaxLength = 24;
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(276, 23);
			this.txbPassword.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha";
			// 
			// lblIsLoginOk
			// 
			this.lblIsLoginOk.AutoSize = true;
			this.lblIsLoginOk.ForeColor = System.Drawing.Color.Red;
			this.lblIsLoginOk.Location = new System.Drawing.Point(384, 37);
			this.lblIsLoginOk.Name = "lblIsLoginOk";
			this.lblIsLoginOk.Size = new System.Drawing.Size(163, 17);
			this.lblIsLoginOk.TabIndex = 2;
			this.lblIsLoginOk.Text = "Login já esta em uso!";
			this.lblIsLoginOk.Visible = false;
			// 
			// txbLogin
			// 
			this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbLogin.Location = new System.Drawing.Point(96, 34);
			this.txbLogin.MaxLength = 48;
			this.txbLogin.Name = "txbLogin";
			this.txbLogin.Size = new System.Drawing.Size(276, 23);
			this.txbLogin.TabIndex = 1;
			this.txbLogin.TextChanged += new System.EventHandler(this.txbLogin_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSalvar);
			this.groupBox2.Controls.Add(this.BtnClearFields);
			this.groupBox2.Location = new System.Drawing.Point(393, 248);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(183, 66);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(10, 22);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(80, 30);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// BtnClearFields
			// 
			this.BtnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnClearFields.Location = new System.Drawing.Point(96, 22);
			this.BtnClearFields.Name = "BtnClearFields";
			this.BtnClearFields.Size = new System.Drawing.Size(80, 30);
			this.BtnClearFields.TabIndex = 0;
			this.BtnClearFields.Text = "Limpar";
			this.BtnClearFields.UseVisualStyleBackColor = true;
			this.BtnClearFields.Click += new System.EventHandler(this.BtnClearFields_Click);
			// 
			// FrmNewUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(584, 322);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FrmNewUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Novo Usuário";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewUser_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblIsLoginOk;
		private System.Windows.Forms.TextBox txbLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox mktbPhone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbPassword;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnClearFields;
		private System.Windows.Forms.Button btnSalvar;
	}
}