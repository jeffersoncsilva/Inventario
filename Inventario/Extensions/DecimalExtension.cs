using System.Globalization;

namespace Inventario.Extensions
{
	public static class DecimalExtension
	{
		public static string AddMoneyFormating(this decimal value, CultureInfo info = null)
		{
			if (info == null)
				info = new CultureInfo("pt-BR");

			return value.ToString("C2", info);
		}
	}
}
