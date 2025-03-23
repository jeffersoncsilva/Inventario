using Inventario.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Inventario.Repository
{
	public class CategoriesRepository : BaseRepository
	{

		public async Task<DataTable> GetCategoiresAsync(int take = 20, int skip = 0)
		{
			try
			{
				using (var cmd = new SqlCommand("SELECT Id, Name, Description FROM Categories ORDER BY Name OFFSET @skip ROWS FETCH NEXT @take ROWS ONLY"))
				{
					cmd.Parameters.AddWithValue("skip", (take * skip));
					cmd.Parameters.AddWithValue("take", take);
					return await ExecuteCommandToDataTableWithoutTransactionAsync(cmd);
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
			return null;
		}

		public async Task<int> AddNewCategoryAsync(CategoryViewModel vm)
		{
			try
			{
				using(var cmd = new SqlCommand("INSERT INTO Categories (Name, Description) VALUES (@name, @description)"))
				{
					cmd.Parameters.AddWithValue("name", vm.Name);
					cmd.Parameters.AddWithValue("description", vm.Description);
					return await ExecuteCommandWithTransactionAsync(cmd);
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
				return -1;
			}
		}

		public async Task<int> UpdateCategory(CategoryViewModel vm)
		{
			try
			{
				using (var cmd = new SqlCommand("UPDATE Categories SET Name = @name, Description = @description WHERE Id = @id"))
				{
					cmd.Parameters.AddWithValue("name", vm.Name);
					cmd.Parameters.AddWithValue("description", vm.Description);
					cmd.Parameters.AddWithValue("id", vm.Id);

					return await ExecuteCommandWithTransactionAsync(cmd);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return -1;
		}

		public async Task DeleteCategoryByIdAsync(int id)
		{
			try
			{
				using(var cmd = new SqlCommand("DELETE FROM Categories WHERE Id = @id"))
				{
					cmd.Parameters.AddWithValue("id", id);
					await ExecuteCommandWithTransactionAsync(cmd);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
