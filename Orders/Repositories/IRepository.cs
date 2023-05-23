namespace Orders.Repositories
{
	public interface IRepository<T>
	{
		public IEnumerable<T> GetAll();
		public T GetById(int id);
		public void Add(T entity);
		public void Update(T entity, T updatedEntity);
		void Delete(int id);
		
	}
}
