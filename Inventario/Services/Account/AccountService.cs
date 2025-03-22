using Inventario.Models.Account;
using Inventario.Repository.Account;
using System.Threading.Tasks;

namespace Inventario.Services.Account
{
	public class AccountService
	{
		private readonly AccountRepository _accountRepository = new AccountRepository();

		public async Task<bool> LoginWithUserAndPassword(LoginViewModel login)
		{
			var password = EncriptePassword(login.Password);
			return await _accountRepository.CheckIfUserAndPasswordIsCorrect(login.Login, password);
		}

		private string EncriptePassword(string pwd)
		{
			return pwd;
		}
	}
}
