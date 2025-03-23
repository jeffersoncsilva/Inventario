using Inventario.Extensions;
using Inventario.Models;
using Inventario.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventario.Forms.Categories
{
	public partial class FrmCategory : Form
	{
		private readonly CategoryService _categoryService = new CategoryService();
		private readonly List<(int, int)> rowsChanged = new List<(int, int)>();

		public FrmCategory()
		{
			InitializeComponent();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (!FormDataIsValid())
				{
					MessageBox.Show("Verifique os dados e tente novamente.", "Nova Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var category = CreateNewCategoryFromForm();
				var result = await _categoryService.AddNewCategoryAsync(category);
				if (result)
				{
					MessageBox.Show("Nova categoria adicionada com sucesso.", "Nova Categoria", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ClearFields();
				}
				else
				{
					MessageBox.Show("Não foi possível salvar a categoria.", "Nova categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private bool FormDataIsValid() 
		{
			bool isNameValid = IsNameValid();
			bool isDescriptionValid = IsDescriptionValid();
			return isNameValid && isDescriptionValid;
		}

		private bool IsNameValid()
		{
			if (string.IsNullOrWhiteSpace(txbCategoryName.Text))
			{
				txbCategoryName.MakeTextBoxInvalid();
				return false;
			}
			txbCategoryName.MakeTextBoxValid();
			return true;
		}

		private bool IsDescriptionValid()
		{
			if (string.IsNullOrWhiteSpace(txbDescription.Text))
			{
				txbDescription.MakeTextBoxInvalid();
				return false;
			}
			txbDescription.MakeTextBoxValid();
			return true;
		}

		private CategoryViewModel CreateNewCategoryFromForm()
		{
			return new CategoryViewModel()
			{
				Name = txbDescription.Text,
				Description = txbDescription.Text
			};
		}

		private void ClearFields()
		{
			txbDescription.Text = string.Empty;
			txbCategoryName.Text = string.Empty;
		}

		private void btnClearFields_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private async void tbNewCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var categories = await _categoryService.GetAllCategories();
				grdCategories.DataSource = categories;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private async void btnSalvarAlteracao_Click(object sender, EventArgs e)
		{
			try
			{
				if (!rowsChanged.Any())
				{
					MessageBox.Show("Nenhum dado foi alterado!", "Alteraçãod e Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}

				var rowsToUpdatea = GetRowsChanged();
				var result = await _categoryService.UpdateCategories(rowsToUpdatea);
				if (result)
				{
					MessageBox.Show("Categorias atualizadas.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.None);
					rowsChanged.Clear();
				}
				else
					MessageBox.Show("Categorias não foi atualizada.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private IEnumerable<CategoryViewModel> GetRowsChanged()
		{
			var categories = new List<CategoryViewModel>();
			foreach (var (line, categoryId) in rowsChanged)
			{
				var row = grdCategories.Rows[line];
				var category = new CategoryViewModel()
				{
					Id = int.Parse(row.Cells["Id"].Value.ToString()),
					Name = row.Cells["Nome"].Value.ToString(),
					Description = row.Cells["Description"].Value.ToString()
				};
				categories.Add(category);
			}
			return categories;
		}

		private void grdCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int idxRow = e.RowIndex;
				var row = grdCategories.Rows[idxRow];
				int id = int.Parse(row.Cells["Id"].Value.ToString());
				rowsChanged.Add((idxRow, id));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private async void btnRemoveCategory_Click(object sender, EventArgs e)
		{
			if (!LinesSeletectedInGridCategories())
			{
				MessageBox.Show("Selecione uma linha para poder apaga-la.", "Apagar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				var categories = GetRowsSelected();
				await _categoryService.DeleteCategoriesAsync(categories);
				rowsChanged.Clear();
				MessageBox.Show("Categorias apagadas.", "Apagar Categoria", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			catch(Exception ex)
			{
				Console.WriteLine($"{ex.Message}");
			}
		}

		private bool LinesSeletectedInGridCategories()
		{
			return grdCategories.SelectedRows.Count > 0;
		}

		private IEnumerable<CategoryViewModel> GetRowsSelected()
		{
			var categories = new List<CategoryViewModel>();
			foreach (DataGridViewRow row in grdCategories.SelectedRows)
			{
				var category = new CategoryViewModel()
				{
					Id = int.Parse(row.Cells["Id"].Value.ToString()),
					Name = row.Cells["Nome"].Value.ToString(),
					Description = row.Cells["Description"].Value.ToString()
				};
				categories.Add(category);
			}
			return categories;
		}
	}
}
