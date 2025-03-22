using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Inventario.Repository
{
	public abstract class BaseRepository
	{
		private const string connectionString = "Data Source=127.0.0.1,1433;Initial Catalog=Inventario;User ID=sa;Password=1q2w3e4r@#$;Connect Timeout=30;Encrypt=False;";
		private readonly SqlConnection _connection;

		protected BaseRepository()
		{
			try
			{
				_connection = new SqlConnection(connectionString);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private async Task OpenConnectionAsync()
		{
			try
			{
				if (_connection.State != System.Data.ConnectionState.Open)
					await _connection.OpenAsync();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void CloseConnectionAsync()
		{
			try
			{
				if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
					_connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		protected async Task<DataTable> ExecuteCommandToDataTableWithTransactionAsync(SqlCommand cmd, IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted)
		{
			DataTable dt = null;
			try
			{
				await OpenConnectionAsync();
				cmd.Connection = _connection;
				cmd.Transaction = _connection.BeginTransaction(isolationLevel);
				var reader = await cmd.ExecuteReaderAsync();
				dt = new DataTable();
				dt.Load(reader);
				cmd.Transaction.Commit();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				if (cmd.Transaction != null)
					cmd.Transaction.Rollback();
			}
			finally
			{
				CloseConnectionAsync();
			}
			return dt;
		}

		protected async Task<DataTable> ExecuteCommandToDataTableWithoutTransactionAsync(SqlCommand cmd)
		{
			DataTable dt = null;
			try
			{
				await OpenConnectionAsync();
				cmd.Connection = _connection;
				var reader = await cmd.ExecuteReaderAsync();
				dt = new DataTable();
				dt.Load(reader);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				CloseConnectionAsync();
			}
			return dt;
		}

		protected async Task<int> ExecuteCommandWithTransactionAsync(SqlCommand cmd, IsolationLevel isolationLevel = IsolationLevel.Serializable)
		{
			try
			{
				await OpenConnectionAsync();
				cmd.Connection = _connection;
				cmd.Transaction = _connection.BeginTransaction(isolationLevel);
				var linesAffected = await cmd.ExecuteNonQueryAsync();
				cmd.Transaction.Commit();
				return linesAffected;
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				if (cmd.Transaction != null)
					cmd.Transaction.Rollback();
			}
			finally
			{
				CloseConnectionAsync();
			}
			return -1;
		}

		protected async Task<int> ExecuteCommandWithoutTransactionAsync(SqlCommand cmd)
		{
			try
			{
				await OpenConnectionAsync();
				cmd.Connection = _connection;
				return await cmd.ExecuteNonQueryAsync();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				CloseConnectionAsync();
			}
			return -1;
		}
	}
}
