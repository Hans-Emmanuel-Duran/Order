namespace Orders.Models
{
	// Dependent entity
	public class Item
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public string Name { get; set; } = string.Empty;
		public float Price { get; set; }

		// One-To-Many

		/// <summary>
		/// Foreign key
		/// </summary>
		public int OrderId { get; set; }
		/// <summary>
		/// Reference to the principal entity
		/// </summary>
		public Order Order { get; set; }
	}
}
