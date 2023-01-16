using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services;
public class VideocardService : IServiceAsync<Videocard>
{
	private readonly DataContext _dataContext;
	public VideocardService()
	{
		_dataContext = new DataContext();
	}

	public async Task AddItemAsync(Videocard item)
	{
		await _dataContext.Videocards.AddAsync(item);
		await _dataContext.SaveChangesAsync();
	}

	public async Task DeleteItemByIdAsync(int id)
	{
		Videocard? item = await _dataContext.Videocards.FindAsync(id) ?? throw new ArgumentNullException();
		_dataContext.Videocards.Remove(item);
		await _dataContext.SaveChangesAsync();
	}

	public async Task<IEnumerable<Videocard>> GetAllItemsAsync()
	{
		return await _dataContext.Videocards.ToListAsync();
	}

	public async Task<Videocard?> GetItemByIdAsync(int id)
	{
		return await _dataContext.Videocards.FindAsync(id);
	}

	public async Task UpdateItemAsync(Videocard item)
	{
		_dataContext.Videocards.Update(item);
		await _dataContext.SaveChangesAsync();
	}
}
