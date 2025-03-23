using Inventario.Models;
using Inventario.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.Services
{
	public class CategoryService
	{
		private readonly CategoriesRepository _categoryRepository = new CategoriesRepository();

		public async Task<bool> AddNewCategoryAsync(CategoryViewModel category)
		{
			try
			{
				var result = await _categoryRepository.AddNewCategoryAsync(category);
				return result > 0;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}

		public async Task<IEnumerable<CategoryViewModel>> GetAllCategories()
		{
			try
			{
				var dtCategoires = await _categoryRepository.GetCategoiresAsync();
				if(dtCategoires != null && dtCategoires.Rows.Count > 0)
				{
					var categories = new List<CategoryViewModel>();
					foreach (DataRow row in dtCategoires.Rows)
					{
						var category = new CategoryViewModel()
						{
							Id = row.Field<int>("id"),
							Name = row.Field<string>("Name"),
							Description = row.Field<string>("Description"),
						};
						categories.Add(category);
					}
					return categories;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return Enumerable.Empty<CategoryViewModel>();
		}

		public async Task<bool> UpdateCategories(IEnumerable<CategoryViewModel> categories)
		{
			try
			{
				foreach (var vm in categories)
				{
					await _categoryRepository.UpdateCategory(vm);
				}

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public async Task DeleteCategoriesAsync(IEnumerable<CategoryViewModel> categories)
		{
			try
			{
				foreach (var vm in categories)
					await _categoryRepository.DeleteCategoryByIdAsync(vm.Id);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{ex.Message}");
			}
		}
	}
}
