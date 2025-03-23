namespace Inventario.Models.Products
{
	public class ProductViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Features { get; set; }
		public decimal Price { get; set; }
		public decimal PriceTotal { get; set; }
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public CategoryViewModel Category {get;set;}
		public int CompanyId { get; set; }
		public CompanyViewModel Company { get; set; }
	}
}
