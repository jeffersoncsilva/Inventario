using Inventario.Extensions;
using Inventario.Models.Products;
using Inventario.Services.Products;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventario.Forms.Products
{
	public partial class FrmProduct : Form
	{
		private readonly ProductService _productService = new ProductService();

		public FrmProduct()
		{
			InitializeComponent();
		}

		private async void FrmProduct_Load(object sender, EventArgs e)
		{
			var (companies, categories) = await _productService.GetCompaniesAndCategoriesAsync();
			cmbCategories.Items.Clear();
			cmbCategories.DataSource = categories;
			cmbCategories.DisplayMember = "Name";
			cmbCategories.ValueMember = "Id";

			cmbCompanies.Items.Clear();
			cmbCompanies.DataSource = companies;
			cmbCompanies.DisplayMember = "Name";
			cmbCompanies.ValueMember = "Id";
		}

		private async void btnSalvar_Click(object sender, EventArgs e)
		{
			if (!DataIsValid())
				return;

			var product = CreateNewProduct();
			var result = await _productService.SaveNewProductAsync(product);
			if(result > 0)
			{
				ShowMessageProductAddedSuccess();
			}
			else
			{
				ShowMessageProductNotAdded();
			}
			ClearForm();
		}

		private void ShowMessageProductAddedSuccess()
		{
			MessageBox.Show("Produto salvo com sucesso.", "Produto Salvo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void ShowMessageProductNotAdded()
		{
			MessageBox.Show("Ocorreu um erro ao salvar seu produto. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private bool DataIsValid()
		{
			bool isProductNameValid = IsProductNameValid();
			bool isCategoryValid = IsCategoryValid();
			bool isCompanyValid = IsCompanyValid();
			bool isFeaturesValid = IsFeaturesValid();
			bool isPriceValid = IsPriceValid();
			bool isQuantityValid = IsQuantityValid();
			return isProductNameValid && isCategoryValid && isCompanyValid && isFeaturesValid && isPriceValid && isQuantityValid;
		}

		private bool IsProductNameValid()
		{
			if (string.IsNullOrWhiteSpace(txbProductName.Text))
			{
				txbProductName.BorderStyle = BorderStyle.FixedSingle;
				txbProductName.BackColor = Color.Red;
				txbProductName.ForeColor = Color.White;
				return false;
			}

			txbProductName.BorderStyle = BorderStyle.FixedSingle;
			txbProductName.BackColor = Color.White;
			txbProductName.ForeColor = Color.Black;
			return true;
		}

		private bool IsCategoryValid()
		{
			if (cmbCategories.SelectedIndex == -1)
			{
				cmbCategories.BackColor = Color.Red;
				cmbCategories.ForeColor = Color.White;
				return false;
			}
			cmbCategories.BackColor = Color.White;
			cmbCategories.ForeColor = Color.Black;
			return true;
		}

		private bool IsCompanyValid()
		{
			if (cmbCompanies.SelectedIndex == -1)
			{
				cmbCompanies.BackColor = Color.Red;
				cmbCompanies.ForeColor = Color.White;
				return false;
			}
			cmbCompanies.BackColor = Color.White;
			cmbCompanies.ForeColor = Color.Black;
			return true;
		}

		private bool IsFeaturesValid()
		{
			if (string.IsNullOrWhiteSpace(txbFeatures.Text))
			{
				txbFeatures.BackColor = Color.Red;
				txbFeatures.ForeColor = Color.White;
				return false;
			}
			txbFeatures.BackColor = Color.White;
			txbFeatures.ForeColor = Color.Black;
			return true;
		}

		private bool IsPriceValid()
		{
			if (string.IsNullOrWhiteSpace(txbPrice.Text) || (decimal.TryParse(txbPrice.Text.RemoveMoneyFormat(), out decimal price) && price <= 0))
			{
				txbPrice.BackColor = Color.Red;
				txbPrice.ForeColor = Color.White;
				return false;
			}
			txbPrice.BackColor = Color.White;
			txbPrice.ForeColor = Color.Black;
			return true;
		}

		private bool IsQuantityValid()
		{
			if (string.IsNullOrWhiteSpace(txbQuantidade.Text) || (int.TryParse(txbQuantidade.Text, out int qtd) && qtd <= 0))
			{
				txbQuantidade.BackColor = Color.Red;
				txbQuantidade.ForeColor = Color.White;
				return false;
			}
			txbQuantidade.BackColor = Color.White;
			txbQuantidade.ForeColor = Color.Black;
			return true;
		}

		private ProductViewModel CreateNewProduct()
		{
			int.TryParse(txbQuantidade.Text, out int qtd);
			int.TryParse(cmbCategories.SelectedValue.ToString(), out int categoryId);
			int.TryParse(cmbCompanies.SelectedValue.ToString(), out int companyId);
			decimal.TryParse(txbPrice.Text.RemoveMoneyFormat(), out decimal price);
			price = price / 100;
			return new ProductViewModel()
			{
				Name = txbProductName.Text,
				Features = txbFeatures.Text,
				Price = price,
				Quantity = qtd,
				CategoryId = categoryId,
				CompanyId = companyId
			};
		}

		private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txbPrice_KeyUp(object sender, KeyEventArgs e)
		{
			if (decimal.TryParse(txbPrice.Text.RemoveMoneyFormat(), out decimal price))
			{
				txbPrice.Text = (price / 100).AddMoneyFormating();
				txbPrice.SelectionStart = txbPrice.Text.Length;
			}
		}

		private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void ClearForm()
		{
			txbProductName.Text = string.Empty;
			txbPrice.Text = string.Empty;
			txbFeatures.Text = string.Empty;
			txbQuantidade.Text = string.Empty;
			cmbCategories.SelectedIndex = 0;
			cmbCompanies.SelectedIndex = 0;
		}

		private void FrmProduct_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Owner != null)
			{
				Owner.Show();
			}
		}
	}
}
