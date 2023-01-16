using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services;

public class RamService : IServiceAsync<Ram>
{
	private readonly DataContext _dataContext;
	public RamService()
	{
		_dataContext = new DataContext();
	}

	public async Task<Ram?> GetItemByIdAsync(int id)
	{
		return await _dataContext.Rams.FindAsync(id);
	}

	public async Task<IEnumerable<Ram>> GetAllItemsAsync()
	{
		return await _dataContext.Rams.ToListAsync();
	}

	public async Task AddItemAsync(Ram ram)
	{
		await _dataContext.Rams.AddAsync(ram);
		await _dataContext.SaveChangesAsync();
	}

	public async Task DeleteItemByIdAsync(int id)
	{
		Ram? item = await _dataContext.Rams.FindAsync(id) ?? throw new ArgumentNullException();
		_dataContext.Rams.Remove(item);
		await _dataContext.SaveChangesAsync();
	}

	public async Task UpdateItemAsync(Ram ram)
	{
		_dataContext.Rams.Update(ram);
		await _dataContext.SaveChangesAsync();
	}
}
