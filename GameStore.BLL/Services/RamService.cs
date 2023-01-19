using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using GameStore.BLL.DTO;

namespace GameStore.BLL.Services;

public class RamService : IRepositoryAsync<RamDto>
{
	private readonly DataContext _dataContext;
	public RamService()
	{
		_dataContext = new DataContext();
	}

	public async Task<RamDto?> GetItemByIdAsync(int id)
	{
        var ram = await _dataContext.Rams.AsNoTracking().FirstAsync(x => x.Id == id);
		var result = new RamDto() 
		{
            Info = ram.Info,
            Id = ram.Id
        };

		return result;
	}

	public async Task<IEnumerable<RamDto>> GetAllItemsAsync()
	{
        var rams = await _dataContext.Rams.AsNoTracking().ToListAsync();
        var result = new List<RamDto>();

        foreach (var ram in rams)
        {
            result.Add(new RamDto()
            {
                Info = ram.Info,
                Id = ram.Id
            });
        }

        return result;
    }

	public async Task AddItemAsync(RamDto ram)
	{
        var ramToAdd = new Ram()
        {
            Info = ram.Info,
            Id = ram.Id
        };

        await _dataContext.Rams.AddAsync(ramToAdd);
        await _dataContext.SaveChangesAsync();
    }

	public async Task DeleteItemByIdAsync(int id)
	{
        var ram = await _dataContext.Rams.FindAsync(id) ?? throw new ArgumentNullException();
        _dataContext.Rams.Remove(ram);
        await _dataContext.SaveChangesAsync();
    }

	public async Task UpdateItemAsync(RamDto ram)
	{
        var ramToUpdate = new Ram()
        {
            Id = ram.Id,
            Info = ram.Info
        };

        _dataContext.Rams.Update(ramToUpdate);
        await _dataContext.SaveChangesAsync();
    }
}
