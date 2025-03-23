using Inventario.Models.Account;
using Inventario.Services.Account;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventario.Forms.Account
{
	public partial class FrmNewUser : Form
	{
		private readonly AccountService _accountService = new AccountService();

		public FrmNewUser()
		{
			InitializeComponent();
		}

		private async void txbLogin_TextChanged(object sender, EventArgs e)
		{
			if (await _accountService.CheckIfLoginIsUsed(txbLogin.Text))
			{
				txbLogin.Focus();
				txbLogin.ForeColor = Color.White;
				txbLogin.BackColor = Color.Red;
				lblIsLoginOk.Visible = true;
			}
			else
			{
				txbLogin.ForeColor = Color.Black;
				txbLogin.BackColor = Color.White;
				lblIsLoginOk.Visible = false;
			}
		}

		private async void btnSalvar_Click(object sender, EventArgs e)
		{
			if (!FormIsValid())
			{
				MessageBox.Show("Verifique os dados do formulário e tente novamente.", "Dados Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var newUser = CreateNewUser();
			if (await _accountService.SaveNewUserAsync(newUser))
			{
				ShowNewUserAddedWithSuccess();
			}
			else
			{
				ShowNewUserNotAdded();
			}
			ClearFields();
		}

		private void BtnClearFields_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private bool FormIsValid()
		{
			bool isLoginVaid = IsLoginValid();
			bool isPasswordVaid = IsPasswordValid();
			bool isNameValid = IsNameValid();
			bool isPhoneValid = IsPhoneValid();
			bool isEmailValid = IsEmailValid();
			return isLoginVaid && isPasswordVaid && isNameValid && isPhoneValid && isEmailValid;
		}

		private bool IsLoginValid()
		{
			if (string.IsNullOrWhiteSpace(txbLogin.Text))
			{
				txbLogin.BackColor = Color.Red;
				txbLogin.ForeColor = Color.White;
				return false;
			}
			txbLogin.BackColor = Color.White;
			txbLogin.ForeColor = Color.Black;
			return true;
		}

		private bool IsPasswordValid()
		{
			if (string.IsNullOrWhiteSpace(txbPassword.Text))
			{
				txbPassword.BackColor = Color.Red;
				txbPassword.ForeColor = Color.White;
				return false;
			}
			txbPassword.BackColor = Color.White;
			txbPassword.ForeColor = Color.Black;
			return true;
		}

		private bool IsNameValid()
		{
			if (string.IsNullOrWhiteSpace(txbUserName.Text))
			{
				txbUserName.BackColor = Color.Red;
				txbUserName.ForeColor = Color.White;
				return false;
			}
			txbUserName.BackColor = Color.White;
			txbUserName.ForeColor = Color.Black;
			return true;
		}

		private bool IsPhoneValid()
		{
			if(string.IsNullOrWhiteSpace(mktbPhone.Text) && mktbPhone.Text.Length < 17)
			{
				mktbPhone.ForeColor = Color.White;
				mktbPhone.BackColor = Color.Red;
				return false;
			}
			mktbPhone.ForeColor = Color.Black;
			mktbPhone.BackColor = Color.White;
			return true;
		}

		private bool IsEmailValid() 
		{
			string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
			if (string.IsNullOrWhiteSpace(txbEmail.Text) || !Regex.IsMatch(txbEmail.Text, regexEmail))
			{
				txbEmail.BackColor = Color.Red;
				txbEmail.ForeColor = Color.White;
				return false;
			}
			txbEmail.ForeColor = Color.Black;
			txbEmail.BackColor = Color.White;
			return true;
		}

		private void ShowNewUserAddedWithSuccess()
		{
			MessageBox.Show("Novo usuário adicinado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ShowNewUserNotAdded()
		{
			MessageBox.Show("Não foi possivel finalizar o cadastro. Tente novamente.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private NewUserViewModel CreateNewUser()
		{
			return new NewUserViewModel()
			{
				Login = txbLogin.Text,
				Password = txbPassword.Text,
				Name = txbUserName.Text,
				Phone = mktbPhone.Text,
				Email = txbEmail.Text,
			};
		}

		private void ClearFields()
		{
			txbLogin.Text = string.Empty;
			txbPassword.Text = string.Empty;
			txbUserName.Text = string.Empty;
			mktbPhone.Text = string.Empty;
			txbEmail.Text = string.Empty;
		}

		private void FrmNewUser_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(Owner != null)
			{
				Owner.Show();
			}
		}
	}
}
