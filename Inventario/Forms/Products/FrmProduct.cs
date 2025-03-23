using Inventario.Extensions;
using Inventario.Models.Products;
using Inventario.Services.Products;
using System;
using System.Drawing;
using System.Threading.Tasks;
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
			await _productService.SaveNewProductAsync(product);
		}

		private bool DataIsValid()
		{
			bool isProductNameValid = IsProductNameValid();
			bool isCategoryValid = IsCategoryValid();
			bool isCompanyValid = IsCompanyValid();

			return isProductNameValid && isCategoryValid && isCompanyValid;
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
			if(cmbCompanies.SelectedIndex == -1)
			{
				cmbCompanies.BackColor = Color.Red;
				cmbCompanies.ForeColor = Color.White;
				return false;
			}
			cmbCompanies.BackColor = Color.White;
			cmbCompanies.ForeColor = Color.Black;
			return true;
		}

		private ProductViewModel CreateNewProduct()
		{
			return new ProductViewModel()
			{
				Name = txbProductName.Text
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
			if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}
