using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Inventario.Repository
{
	public class CompaniesRepository : BaseRepository
	{

		public async Task<DataTable> GetCompaniesAsync(int take = 20, int skipt = 0)
		{
			try
			{
				using (var cmd = new SqlCommand("SELECT Id, Name, Description FROM Companies ORDER BY Name OFFSET @skip ROWS FETCH NEXT @take ROWS ONLY"))
				{
					cmd.Parameters.AddWithValue("skip", (take * skipt));
					cmd.Parameters.AddWithValue("take", take);
					var result = await ExecuteCommandToDataTableWithoutTransactionAsync(cmd);
					return result;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return null;
		}
	}
}

