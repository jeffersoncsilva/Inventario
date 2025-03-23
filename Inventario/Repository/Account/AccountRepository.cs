using Inventario.Models.Account;
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
				return qtd > 0;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public async Task<int> AddNewUser(NewUserViewModel vm)
		{
			try
			{
				using (var cmd = new SqlCommand("INSERT INTO USERS (Login, Password, Name, Phone, Email) VALUES (@login, @password, @name, @phone, @email)"))
				{
					cmd.Parameters.AddWithValue("login", vm.Login);
					cmd.Parameters.AddWithValue("password", vm.Password);
					cmd.Parameters.AddWithValue("name", vm.Name);
					cmd.Parameters.AddWithValue("phone", vm.Phone);
					cmd.Parameters.AddWithValue("email", vm.Email);
					return await ExecuteCommandWithTransactionAsync(cmd);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return 0;
			}
		}

		public async Task<bool> CheckIfLoginIsInUse(string login)
		{
			try
			{
				using (var cmd = new SqlCommand("SELECT COUNT(*) AS Qtd FROM Users WHERE Login = @login"))
				{
					cmd.Parameters.AddWithValue("login", login);
					var dt = await ExecuteCommandToDataTableWithoutTransactionAsync(cmd);
					return dt != null && int.TryParse(dt.Rows[0]["Qtd"].ToString(), out int qtd) && qtd > 0;
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
