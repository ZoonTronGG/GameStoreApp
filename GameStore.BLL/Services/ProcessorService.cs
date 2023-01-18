using GameStore.BLL.DTO;
using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services;

public class ProcessorService : IRepositoryAsync<ProcessorDto>
{
    private readonly DataContext _dataContext;
    public ProcessorService()
    {
        _dataContext = new DataContext();
    }
    public async Task AddItemAsync(ProcessorDto item)
    {
        var itemToAdd = new Processor()
        {
            Info = item.Info,
            Id = item.Id
        };

        await _dataContext.Processors.AddAsync(itemToAdd);
        await _dataContext.SaveChangesAsync();
    }

    public async Task DeleteItemByIdAsync(int id)
    {
        var item = await _dataContext.Processors.FindAsync(id) ?? throw new ArgumentNullException();
        _dataContext.Processors.Remove(item);
        await _dataContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<ProcessorDto>> GetAllItemsAsync()
    {
        var items = await _dataContext.Processors.AsNoTracking().ToListAsync();
        var result = new List<ProcessorDto>();

        foreach (var item in items)
        {
            result.Add(new ProcessorDto()
            {
                Info = item.Info,
                Id = item.Id
            });
        }

        return result;
    }

    public async Task<ProcessorDto?> GetItemByIdAsync(int id)
    {
        var item = await _dataContext.Processors.AsNoTracking().FirstAsync(x => x.Id == id);
        var result = new ProcessorDto()
        {
            Info = item.Info,
            Id = item.Id
        };

        return result;
    }

    public async Task UpdateItemAsync(ProcessorDto item)
    {
        var itemToUpdate = new Processor()
        {
            Id = item.Id,
            Info = item.Info
        };

        _dataContext.Processors.Update(itemToUpdate);
        await _dataContext.SaveChangesAsync();
    }
}
