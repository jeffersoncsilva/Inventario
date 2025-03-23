using Inventario.Forms.Account;
using Inventario.Forms.Categories;
using Inventario.Forms.Customers;
using Inventario.Forms.Products;
using Inventario.Models.Products;
using Inventario.Services.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Features.Home
{
	public partial class FrmHome : Form
	{
		private readonly ProductService productsServices = new ProductService();
		private BindingSource grdHomeSource = new BindingSource();

		public FrmHome()
		{
			InitializeComponent();
		}

		private void calculadoraToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			try
			{
				StartApplication("calc.exe");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void wordpadToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			try
			{
				StartApplication("write.exe");
			}
			catch(Exception ex)
			{
				MessageBox.Show("Não foi possivel iniciar o WordPad.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				StartApplication("winword.exe");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possivel iniciar o WordPad.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gerenciadorDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				StartApplication("taskmgr.exe");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possivel iniciar o WordPad.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				StartApplication("Notepad.exe");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possivel iniciar o WordPad.", "Aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void FrmHome_Load(object sender, EventArgs e)
		{
			var products = await productsServices.GetProductsByNameAsync("");
			grdHomeSource.DataSource = products;
			grdHome.DataSource = grdHomeSource;
		}

		private void grdHome_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((grdHome.Columns[e.ColumnIndex].Name == "Preco" || grdHome.Columns[e.ColumnIndex].Name == "PrecoTotal") && e.Value != null)
			{
				if(e.Value is decimal price)
				{
					e.Value = price.ToString("C2", new CultureInfo("pt-BR"));
					e.FormattingApplied = true;
				}
			}
		}

		private async void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			IEnumerable<ProductViewModel> prods = await productsServices.GetProductsByNameAsync(txtSearchField.Text);
			if(grdHomeSource.DataSource is List<ProductViewModel> products)
			{
				products.Clear();
				products.AddRange(prods);
				grdHomeSource.ResetBindings(false);
			}
			else
			{
				grdHomeSource.DataSource = prods;
			}
		}

		private void StartApplication(string appName)
		{
			Process.Start(appName);
		}

		private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void registroToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var newCliwent = new FrmCustomers();
			newCliwent.Owner = this;
			newCliwent.ShowDialog();
		}

		private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var frmProduct = new FrmProduct();
			frmProduct.Owner = this;
			frmProduct.ShowDialog();
		}

		private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			var newUser = new FrmNewUser();
			newUser.Owner = this;
			newUser.ShowDialog();
		}

		private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var frmCategory = new FrmCategory();
			frmCategory.Owner = this;
			frmCategory.ShowDialog();
		}
	}
}
