using Inventario.Models;
using Inventario.Models.Products;
using Inventario.Repository;
using Inventario.Repository.Home;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.Services.Products
{
	public class ProductService
	{
		private readonly ProductRepository _repository = new ProductRepository();
		private readonly CategoriesRepository _categoreisRepositoy = new CategoriesRepository();
		private readonly CompaniesRepository _companiesRepositoy = new CompaniesRepository();

		public async Task<IEnumerable<ProductViewModel>> GetProductsByNameAsync(string name)
		{
			var dt =  await _repository.GetProductsByNameAsync(name);
			if(dt != null)
			{
				var prods = new List<ProductViewModel>();
				foreach(DataRow row in dt.Rows)
				{
					var product = new ProductViewModel()
					{
						Id = row.Field<int>("Id"),
						Name = row.Field<string>("Name"),
						Features = row.Field<string>("Features"),
						Price = row.Field<decimal>("Price"),
						PriceTotal = row.Field<decimal>("PriceTotal"),
						Quantity = row.Field<int>("Quantity")
					};
					prods.Add(product);
				}
				return prods;
			}
			return Enumerable.Empty<ProductViewModel>();
		}

		public async Task<(IEnumerable<CompanyViewModel>, IEnumerable<CategoryViewModel>)> GetCompaniesAndCategoriesAsync()
		{
			var categoriesDt = await _categoreisRepositoy.GetCategoiresAsync();
			var companiesDt = await _companiesRepositoy.GetCompaniesAsync();

			var categories = new List<CategoryViewModel>();
			var companies = new List<CompanyViewModel>();

			if(categoriesDt != null && categoriesDt.Rows.Count > 0)
			{
				foreach(DataRow row in categoriesDt.Rows)
				{
					var category = new CategoryViewModel()
					{
						Id = row.Field<int>("Id"),
						Name = row.Field<string>("Name"),
						Description = row.Field<string>("Description")
					};
					categories.Add(category);
				}
			}

			if(companiesDt != null && companiesDt.Rows.Count > 0)
			{
				foreach(DataRow row in companiesDt.Rows)
				{
					var company = new CompanyViewModel()
					{
						Id = row.Field<int>("Id"),
						Name = row.Field<string>("Name"),
						Description = row.Field<string>("Description")
					};
					companies.Add(company);
				}
			}

			return (companies, categories);
		}

		public async Task<int> SaveNewProductAsync(ProductViewModel product)
		{
			return await _repository.SaveNewProductAsync(product);
		}
	}
}
