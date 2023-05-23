namespace Orders.Repositories
{
	public interface IRepository<T>
	{
		public void Add(T entity);
		void Remove(int id);
		public IEnumerable<T> GetAll();
		public T GetById(int id);
		public void Update(T entity, T updatedEntity);
	}
}
