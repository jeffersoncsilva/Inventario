namespace Inventario.Extensions
{
	public static class StringExtensions
	{
		public static string RemoveMoneyFormat(this string str)
		{
			if (string.IsNullOrWhiteSpace(str))
				return str;

			return str.Replace(",", "").Replace(".", "").Replace("R$", "").Trim();
		}
	}
}
