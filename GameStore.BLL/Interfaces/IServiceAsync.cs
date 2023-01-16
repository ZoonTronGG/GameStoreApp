namespace GameStore.BLL.Interfaces;

public interface IServiceAsync<T>
{
	public Task<T?> GetItemByIdAsync(int id);

	public Task<IEnumerable<T>> GetAllItemsAsync();

	public Task AddItemAsync(T item);

	public Task DeleteItemByIdAsync(int id);

	public Task UpdateItemAsync(T item);
}
