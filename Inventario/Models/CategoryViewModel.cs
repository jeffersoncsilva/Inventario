namespace Inventario.Models
{
	public class CategoryViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public override string ToString() => $"Name: {Name} - Description: {Description.Substring(0, 32)}";
	}
}
