using Inventario.Models.Products;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Inventario.Repository.Home
{
	public class ProductRepository : BaseRepository
	{

		public async Task<DataTable> GetProductsByNameAsync(string name)
		{
			try
			{
				using (var cmd = new SqlCommand("SELECT Id, Name, Features, Price, sum(Quantity) AS Quantity, sum(Price * Quantity) AS PriceTotal FROM Products WHERE Name LIKE @name GROUP BY Id, Name, Features, Quantity, Price HAVING(quantity > 0) ORDER BY Name"))
				{
					cmd.Parameters.AddWithValue("name", $"%{name}%");
					return await ExecuteCommandToDataTableWithoutTransactionAsync(cmd);
				}
			}catch(Exception ex)
			{
				Console.WriteLine($"{ex.Message}");
			}
			return null;
		}

		public async Task<int> SaveNewProductAsync(ProductViewModel productViewModel)
		{
			try
			{
				using (var cmd = new SqlCommand("INSERT INTO Products (Name, Features, Quantity, Price, CategoryId, CompanyId) VALUES (@name, @features, @quantity, @price, @categoryId, @companyId)"))
				{
					cmd.Parameters.AddWithValue("name", productViewModel.Name);
					cmd.Parameters.AddWithValue("features", productViewModel.Features);
					cmd.Parameters.AddWithValue("quantity", productViewModel.Quantity);
					cmd.Parameters.AddWithValue("price", productViewModel.Price);
					cmd.Parameters.AddWithValue("categoryId", productViewModel.CategoryId);
					cmd.Parameters.AddWithValue("companyId", productViewModel.CompanyId);
					return await ExecuteCommandWithTransactionAsync(cmd);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return -1;
		}

		public async Task<bool> VerifyIfProductExistAsync(string productName)
		{
			try
			{
				using(var cmd = new SqlCommand("SELECT COUNT(*) AS Qtd FROM Product WHERE Name = @name"))
				{
					cmd.Parameters.AddWithValue("name", productName);
					var data = await ExecuteCommandToDataTableWithoutTransactionAsync(cmd);
					return data != null && data.Rows.Count > 0;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}
	}
}
