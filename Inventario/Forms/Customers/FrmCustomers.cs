using Inventario.Models;
using Inventario.Services.Customers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Forms.Customers
{
	public partial class FrmCustomers : Form
	{
		private readonly ClientService _clientService = new ClientService();

		public FrmCustomers()
		{
			InitializeComponent();
		}

		private void btnClean_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			if (!FormValid())
			{
				MessageBox.Show("Verifique os dados e tente novamente.", "Novo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var newClient = MakeNewClient();

			if (await _clientService.AddNewClientAsync(newClient))
				ShowMessageClientAdded();
			else
				ShowMessageErroOnAddClient();

			ClearFields();
		}

		private void ShowMessageErroOnAddClient()
		{
			MessageBox.Show("Não foi possível cadastrar o cliente. Tente novamente", "Novo Cliente",MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void ShowMessageClientAdded()
		{
			MessageBox.Show("Cliente cadastrado com sucesso!", "Novo Cliente", MessageBoxButtons.OK, MessageBoxIcon.None);
		}

		private NewClientViewModel MakeNewClient()
		{
			return new NewClientViewModel()
			{
				Name = txbName.Text,
				Address = txbEnd.Text,
				Referency = txbReferency.Text,
				City = txbCity.Text,
				Country = txbEstado.Text,
				PostalCode = txbCep.Text,
				Phone = mktbPhone.Text,
				MobilePhone = mktbMobilePhone.Text,
				Email = txbEmail.Text,
				Observations = txbObs.Text
			};
		}

		private void ClearFields()
		{
			txbName.Text = string.Empty;
			txbEnd.Text = string.Empty;
			txbReferency.Text = string.Empty;
			txbCity.Text = string.Empty;
			txbEstado.Text = string.Empty;
			txbCep.Text = string.Empty;
			mktbPhone.Text = string.Empty;
			mktbMobilePhone.Text = string.Empty;
			txbEmail.Text = string.Empty;
			txbObs.Text = string.Empty;
		}

		private bool FormValid()
		{
			bool isNameValid = IsNameValid();
			bool isEnderecoValid = IsEnderecoValid();
			bool isReferencyValid = IsReferencyValid();
			bool isCityValid = IsCityValid();
			bool isEstadoValid = IsEstadoValid();
			bool isPhoneValid = IsPhoneValid();
			bool isMobilePhoneValid = IsMobilePhoneValid();
			bool isEmailValid = IsEmailValid();
			return isNameValid && isEnderecoValid && isReferencyValid && isCityValid && isEstadoValid &&
				isPhoneValid && isMobilePhoneValid && isEmailValid;
		}

		private bool IsNameValid()
		{
			if (string.IsNullOrWhiteSpace(txbName.Text))
			{
				MakeInvalid(txbName);
				return false;
			}
			MakeValid(txbName);
			return true;
		}

		private bool IsEnderecoValid()
		{
			if (string.IsNullOrWhiteSpace(txbEnd.Text))
			{
				MakeInvalid(txbEnd);
				return false;
			}
			MakeValid(txbEnd);
			return true;
		}

		private bool IsReferencyValid()
		{
			if (string.IsNullOrWhiteSpace(txbReferency.Text))
			{
				MakeValid(txbReferency);
				return false;
			}
			MakeValid(txbReferency);
			return true;
		}
		
		private bool IsCityValid()
		{
			if (string.IsNullOrWhiteSpace(txbCity.Text))
			{
				MakeInvalid(txbCity); 
				return false;
			}
			MakeValid(txbCity);
			return true;
		}

		private bool IsEstadoValid()
		{
			if (string.IsNullOrWhiteSpace(txbEstado.Text))
			{
				MakeInvalid(txbEstado);
				return false;
			}
			MakeValid(txbEstado);
			return true;
		}

		private bool IsPhoneValid()
		{
			if (string.IsNullOrWhiteSpace(mktbMobilePhone.Text))
			{
				mktbMobilePhone.BackColor = Color.Red;
				mktbMobilePhone.ForeColor = Color.White;
				return false;
			}
			mktbMobilePhone.BackColor = Color.White;
			mktbMobilePhone.ForeColor = Color.Black;
			return true;
		}

		private bool IsMobilePhoneValid()
		{
			if (string.IsNullOrWhiteSpace(mktbMobilePhone.Text))
			{
				mktbMobilePhone.BackColor = Color.Red;
				mktbMobilePhone.ForeColor = Color.White;
				return false;
			}
			mktbMobilePhone.BackColor = Color.White;
			mktbMobilePhone.ForeColor = Color.Black;
			return true;
		}

		private bool IsEmailValid()
		{
			if (string.IsNullOrWhiteSpace(txbEmail.Text))
			{
				MakeInvalid(txbEmail);
				return false;
			}
			MakeValid(txbEmail);
			return true;
		}

		private void MakeInvalid(TextBox txb)
		{
			txb.BackColor = Color.Red;
			txb.ForeColor = Color.White;
		}

		private void MakeValid(TextBox txb)
		{
			txb.BackColor = Color.White;
			txb.ForeColor = Color.Black;
		}

		private void FrmCustomers_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Owner != null)
			{
				Owner.Show();
			}
		}
	}
}
