using Inventario.Forms.Account;
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
			Process.Start("calc.exe");
		}

		private void wordpadToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			try
			{
				Process.Start("write.exe");
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
				Process.Start("winword.exe");
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
				Process.Start("taskmgr.exe");
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
				Process.Start("Notepad.exe");
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

		private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmProduct = new FrmProduct();
			this.Hide();
			frmProduct.Owner = this;
			frmProduct.ShowDialog();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void registroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var newUser = new FrmNewUser();
			newUser.Owner = this;
			newUser.ShowDialog();
			Hide();
		}
	}
}
