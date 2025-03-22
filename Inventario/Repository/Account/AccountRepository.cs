
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Inventario.Repository.Account
{
	public class AccountRepository : BaseRepository
	{
		public async Task<bool> CheckIfUserAndPasswordIsCorrect(string login, string password)
		{
			try
			{
				var cmd = new SqlCommand("SELECT COUNT(*) AS Qtd FROM Users WHERE Login = @login AND Password = @password AND IsActive = 1");
				cmd.Parameters.AddWithValue("@login", login);
				cmd.Parameters.AddWithValue("@password", password);
				var result = await ExecuteCommandToDataTableWithoutTransactionAsync(cmd);
				if (result == null || result.Rows.Count <= 0)
					return false;

				int.TryParse(result.Rows[0]["Qtd"].ToString(), out int qtd);
				return qtd >= 0;
			}
			catch(Exception ex)
			{
				return false;
			}
		}
	}
}
