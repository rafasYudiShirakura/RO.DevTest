namespace RO.DevTest.Application.Contracts.Persistence
{
	public interface IProductRepository
	{
		Task<Product> AddAsync(Product product);
		Task<Product?> GetByIdAsync(Guid id);
		Task UpdateAsync(Product product);
		Task DeleteAsync(Product product);
	}
}
