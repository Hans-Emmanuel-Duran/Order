using Microsoft.EntityFrameworkCore;
using Orders.Contexts;
using Orders.Models;

namespace Orders.Repositories
{
	/// <inheritdoc />
	public class OrderRepository : IRepository<Order>
	{
		private readonly DataContext _context;

		public OrderRepository(DataContext context)
		{
			_context = context;
		}
		
		public void Add(Order order)
		{
			_context.Orders.Add(order);
			_context.SaveChanges();
		}

		public void Remove(Order order)
		{
			_context.Orders.Remove(order);
			_context.SaveChanges();
		}

		public IEnumerable<Order> GetAll()
		{
			return _context.Orders
				.Include(o => o.Items)
				.ToList();
		}

		public Order GetById(int id)
		{
			return _context.Orders
				.Where(o => o.Id == id)
				.Include(o => o.Items)
				.FirstOrDefault();
		}

		public void Update(Order order, Order updatedOrder)
		{
			order.OrderDate = updatedOrder.OrderDate;
			order.IsProcessed = updatedOrder.IsProcessed;
			order.Items = updatedOrder.Items;
			_context.SaveChanges();
		}
	}
}
