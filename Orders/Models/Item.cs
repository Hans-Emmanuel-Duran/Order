namespace Orders.Models
{
	public class Item
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public string Name { get; set; } = string.Empty;
		public float Price { get; set; }
	}
}
