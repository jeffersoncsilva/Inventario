using System;
using System.Data;
using System.Data.SqlClient;
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
	}
}
