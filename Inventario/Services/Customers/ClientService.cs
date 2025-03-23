using Inventario.Models;
using Inventario.Repository;
using System.Threading.Tasks;

namespace Inventario.Services.Customers
{
	public class ClientService
	{
		private readonly ClientRepository _clientRepository = new ClientRepository();
		public async Task<bool> AddNewClientAsync(NewClientViewModel vm)
		{
			return await _clientRepository.SaveNewClientAsync(vm);
		}
	}
}
