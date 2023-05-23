using Microsoft.EntityFrameworkCore;
using Orders.Contexts;
using Orders.Models;

namespace Orders.Repositories
{
	public class OrderRepository : IRepository<Order>
	{
		private readonly DataContext _context;

		public OrderRepository(DataContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Adds an entry.
		/// </summary>
		/// <param name="order">The object to be added.</param>
		public void Add(Order order)
		{
			_context.Orders.Add(order);
			_context.SaveChanges();
		}

		/// <summary>
		/// Removes an entry.
		/// </summary>
		/// <param name="order">The object to be removed.</param>
		public void Remove(Order order)
		{
			_context.Orders.Remove(order);
			_context.SaveChanges();
		}

		/// <summary>
		/// Gets all entries.
		/// </summary>
		/// <returns>Returns all orders.</returns>
		public IEnumerable<Order> GetAll()
		{
			return _context.Orders
				.Include(o => o.Items)
				.ToList();
		}

		/// <summary>
		/// Gets an entry.
		/// </summary>
		/// <param name="id">Entry id to get.</param>
		/// <returns>Returns an order</returns>
		public Order GetById(int id)
		{
			return _context.Orders
				.Where(o => o.Id == id)
				.Include(o => o.Items)
				.FirstOrDefault();
		}

		/// <summary>
		/// Updates an entry.
		/// </summary>
		/// <param name="order">Order to be updated.</param>
		/// <param name="updatedOrder">Updated order value to update the order to be updated.</param>
		public void Update(Order order, Order updatedOrder)
		{
			order.OrderDate = updatedOrder.OrderDate;
			order.IsProcessed = updatedOrder.IsProcessed;
			order.Items = updatedOrder.Items;
			_context.SaveChanges();
		}
	}
}
