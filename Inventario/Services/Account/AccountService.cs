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

		public async Task<bool> CheckIfLoginIsUsed(string login)
		{
			return await _accountRepository.CheckIfLoginIsInUse(login);
		}

		public async Task<bool> SaveNewUserAsync(NewUserViewModel user)
		{
			user.Password = EncriptePassword(user.Password);
			var result = await _accountRepository.AddNewUser(user);
			return result > 0;
		}

		private string EncriptePassword(string pwd)
		{
			return pwd;
		}
	}
}
