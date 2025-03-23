namespace Inventario
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.gpbxLogin = new System.Windows.Forms.GroupBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
			this.lnkPasswordRecovery = new System.Windows.Forms.LinkLabel();
			this.gpbxLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbxLogin
			// 
			this.gpbxLogin.BackColor = System.Drawing.Color.Transparent;
			this.gpbxLogin.Controls.Add(this.txtPwd);
			this.gpbxLogin.Controls.Add(this.txtUser);
			this.gpbxLogin.Controls.Add(this.btnCancel);
			this.gpbxLogin.Controls.Add(this.btnOk);
			this.gpbxLogin.Controls.Add(this.label3);
			this.gpbxLogin.Controls.Add(this.label2);
			this.gpbxLogin.Location = new System.Drawing.Point(50, 132);
			this.gpbxLogin.Name = "gpbxLogin";
			this.gpbxLogin.Size = new System.Drawing.Size(395, 219);
			this.gpbxLogin.TabIndex = 0;
			this.gpbxLogin.TabStop = false;
			// 
			// txtPwd
			// 
			this.txtPwd.BackColor = System.Drawing.SystemColors.Window;
			this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPwd.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F);
			this.txtPwd.Location = new System.Drawing.Point(166, 89);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(186, 23);
			this.txtPwd.TabIndex = 7;
			// 
			// txtUser
			// 
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUser.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F);
			this.txtUser.Location = new System.Drawing.Point(166, 45);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(186, 23);
			this.txtUser.TabIndex = 6;
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Cascadia Code Light", 8.75F);
			this.btnCancel.Location = new System.Drawing.Point(282, 140);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(70, 31);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancela";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Cascadia Code Light", 11.25F);
			this.btnOk.Location = new System.Drawing.Point(166, 140);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(84, 31);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(29, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "Senha";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(29, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuário";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cascadia Code Light", 20.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(43, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			// 
			// lnkChangePassword
			// 
			this.lnkChangePassword.AutoSize = true;
			this.lnkChangePassword.BackColor = System.Drawing.Color.Transparent;
			this.lnkChangePassword.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
			this.lnkChangePassword.Font = new System.Drawing.Font("Cascadia Code Light", 10.25F, System.Drawing.FontStyle.Bold);
			this.lnkChangePassword.LinkColor = System.Drawing.Color.White;
			this.lnkChangePassword.Location = new System.Drawing.Point(46, 374);
			this.lnkChangePassword.Name = "lnkChangePassword";
			this.lnkChangePassword.Size = new System.Drawing.Size(125, 18);
			this.lnkChangePassword.TabIndex = 2;
			this.lnkChangePassword.TabStop = true;
			this.lnkChangePassword.Text = "Alterar Senha";
			// 
			// lnkPasswordRecovery
			// 
			this.lnkPasswordRecovery.AutoSize = true;
			this.lnkPasswordRecovery.BackColor = System.Drawing.Color.Transparent;
			this.lnkPasswordRecovery.Font = new System.Drawing.Font("Cascadia Code Light", 10.25F);
			this.lnkPasswordRecovery.LinkColor = System.Drawing.Color.White;
			this.lnkPasswordRecovery.Location = new System.Drawing.Point(212, 374);
			this.lnkPasswordRecovery.Name = "lnkPasswordRecovery";
			this.lnkPasswordRecovery.Size = new System.Drawing.Size(128, 18);
			this.lnkPasswordRecovery.TabIndex = 3;
			this.lnkPasswordRecovery.TabStop = true;
			this.lnkPasswordRecovery.Text = "Recuperar Senha";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(484, 441);
			this.Controls.Add(this.lnkPasswordRecovery);
			this.Controls.Add(this.lnkChangePassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gpbxLogin);
			this.Font = new System.Drawing.Font("Cascadia Code Light", 12.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.gpbxLogin.ResumeLayout(false);
			this.gpbxLogin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gpbxLogin;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.LinkLabel lnkChangePassword;
		private System.Windows.Forms.LinkLabel lnkPasswordRecovery;
	}
}

