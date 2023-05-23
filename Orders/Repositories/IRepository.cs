namespace Orders.Repositories
{
	public interface IRepository<T>
	{
		/// <summary>
		/// Adds an entry.
		/// </summary>
		/// <param name="entry">The object to be added.</param>
		public void Add(T entry);
		/// <summary>
		/// Removes an entry.
		/// </summary>
		/// <param name="entry">The object to be removed.</param>
		void Remove(T entry);
		/// <summary>
		/// Gets all entries.
		/// </summary>
		/// <returns>Returns all entries.</returns>
		public IEnumerable<T> GetAll();
		/// <summary>
		/// Gets an entry.
		/// </summary>
		/// <param name="id">Entry id to get.</param>
		/// <returns>Returns an entry.</returns>
		public T GetById(int id);
		/// <summary>
		/// Updates an entry.
		/// </summary>
		/// <param name="entry">Entry to be updated.</param>
		/// <param name="updatedEntry">Updated entry value to update the entry to be updated.</param>
		public void Update(T entry, T updatedEntry);
	}
}
