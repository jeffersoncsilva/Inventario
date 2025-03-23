using Inventario.Features.Home;
using Inventario.Models.Account;
using Inventario.Services.Account;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
	public partial class frmLogin : Form
	{
		private readonly AccountService _accountService = new AccountService();

		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
			Application.Exit();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			txtUser.Focus();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void btnOk_Click(object sender, EventArgs e)
		{
			if (!IsLoginAndPasswordWithValidValues())
				return;

			var loginViewModel = CreateUserLoginViewModel();

			var authorized = await _accountService.LoginWithUserAndPassword(loginViewModel);
			if (authorized)
			{
				ShowOkMessage();
			}
			else
			{
				ShowLoginFailureMessage();
			}
		}

		private void ShowLoginFailureMessage()
		{
			MessageBox.Show("Login or password is not valid.", "Login Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void ShowOkMessage()
		{
			var result = MessageBox.Show("Login is correct, you are authorized.", "Login Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if(result == DialogResult.OK)
			{
				RedirectToFrmHome();
			}
		}

		private void RedirectToFrmHome()
		{
			var frmHome = new FrmHome();
			this.Hide();
			frmHome.StartPosition = FormStartPosition.CenterScreen;
			frmHome.ShowDialog();
		}

		private LoginViewModel CreateUserLoginViewModel()
		{
			return new LoginViewModel()
			{
				Login = txtUser.Text,
				Password = txtPwd.Text
			};
		}

		private bool IsLoginAndPasswordWithValidValues()
		{
			var isLoginValid = IsLoginValid();
			var isPasswordValid = IsPasswordValid();
			return isLoginValid && isPasswordValid;
		}

		private bool IsLoginValid()
		{
			if (string.IsNullOrWhiteSpace(txtUser.Text))
			{
				txtUser.BorderStyle = BorderStyle.FixedSingle;
				txtUser.BackColor = Color.Red;
				txtUser.ForeColor = Color.White;
				return false;
			}
			txtUser.BorderStyle = BorderStyle.FixedSingle;
			txtUser.BackColor = Color.White;
			txtUser.ForeColor = Color.Black;
			return true;
		}

		private bool IsPasswordValid()
		{
			if (string.IsNullOrWhiteSpace(txtPwd.Text))
			{
				txtPwd.BorderStyle = BorderStyle.FixedSingle;
				txtPwd.BackColor = Color.Red;
				txtPwd.ForeColor = Color.White;
				return false;
			}

			txtPwd.BorderStyle = BorderStyle.FixedSingle;
			txtPwd.BackColor = Color.White;
			txtPwd.ForeColor = Color.Black;
			return true;
		}
	}
}
