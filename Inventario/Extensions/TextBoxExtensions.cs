using System.Drawing;
using System.Windows.Forms;

namespace Inventario.Extensions
{
	public static class TextBoxExtensions
	{
		public static void MakeTextBoxInvalid(this TextBox tx)
		{
			tx.BackColor = Color.Red;
			tx.ForeColor = Color.Red;
		}

		public static void MakeTextBoxValid(this TextBox tx)
		{
			tx.BackColor = Color.White;
			tx.ForeColor = Color.Green;
		}
	}
}
