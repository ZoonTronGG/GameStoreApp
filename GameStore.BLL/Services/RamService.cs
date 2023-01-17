using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using GameStore.BLL.DTO;

namespace GameStore.BLL.Services;

public class RamService : IServiceAsync<RamDto>
{
	private readonly DataContext _dataContext;
	public RamService()
	{
		_dataContext = new DataContext();
	}

	public async Task<RamDto?> GetItemByIdAsync(int id)
	{
        var ram = await _dataContext.Rams.FirstAsync(x => x.Id == id);
		var result = new RamDto() 
		{
            Info = ram.Info
        };
		return result;
	}

	public async Task<IEnumerable<RamDto>> GetAllItemsAsync()
	{
		return null;
		//return await _dataContext.Rams.ToListAsync();
	}

	public async Task AddItemAsync(RamDto ram)
	{
		//await _dataContext.Rams.AddAsync(ram);
		//await _dataContext.SaveChangesAsync();
	}

	public async Task DeleteItemByIdAsync(int id)
	{
		//Ram? item = await _dataContext.Rams.FindAsync(id) ?? throw new ArgumentNullException();
		//_dataContext.Rams.Remove(item);
		//await _dataContext.SaveChangesAsync();
	}

	public async Task UpdateItemAsync(RamDto ram)
	{
		//_dataContext.Rams.Update(ram);
		//await _dataContext.SaveChangesAsync();
	}
}
