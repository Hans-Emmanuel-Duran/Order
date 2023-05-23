namespace Orders.Models
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public bool IsProcessed { get; set; }
		
		/// One-To-Many
		/// <summary>
		/// Reference to items ordered
		/// </summary>
		public ICollection<Item> Items { get; set; }
	}
}
