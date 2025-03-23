using Inventario.Models;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Inventario.Repository
{
	public class ClientRepository : BaseRepository
	{
		public async Task<bool> SaveNewClientAsync(NewClientViewModel vm)
		{
			try
			{
				using (var cmd = new SqlCommand("INSERT INTO Clients (Name, Address, Referency, City, Country, PostalCode, Phone, MobilePhone, Email, Observations) VALUES (@name, @address, @referency, @city, @country, @postalCode, @phone, @mobilePhone, @email, @observations);"))
				{
					cmd.Parameters.AddWithValue("name", vm.Name);
					cmd.Parameters.AddWithValue("address", vm.Address);
					cmd.Parameters.AddWithValue("referency", vm.Referency);
					cmd.Parameters.AddWithValue("city", vm.City);
					cmd.Parameters.AddWithValue("country", vm.Country);
					cmd.Parameters.AddWithValue("postalCode", vm.PostalCode);
					cmd.Parameters.AddWithValue("phone", vm.Phone);
					cmd.Parameters.AddWithValue("mobilePhone", vm.MobilePhone);
					cmd.Parameters.AddWithValue("email", vm.Email);
					cmd.Parameters.AddWithValue("observations", vm.Observations);
					var result = await ExecuteCommandWithTransactionAsync(cmd);
					return result > 0;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}
