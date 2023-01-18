using GameStore.BLL.DTO;
using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services;

public class SystemRequirementService : IRepositoryAsync<SystemRequirementDto>
{
    private readonly DataContext _dataContext;
    public SystemRequirementService()
    {
        _dataContext = new DataContext();
    }
    public async Task AddItemAsync(SystemRequirementDto item)
    {
        var itemToAdd = new SystemRequirement()
            {
                Id = item.Id,
                FreeSpace= item.FreeSpace,
                Processor = new Processor()
                {
                    Id = item.Processor!.Id,
                    Info = item.Processor.Info
                },
                Ram = new Ram()
                {
                    Id = item.Ram!.Id,
                    Info = item.Ram.Info
                },
                Videocard = new Videocard()
                {
                    Id = item.Videocard!.Id,
                    Info = item.Videocard.Info
                },
            };

        await _dataContext.SystemRequirements.AddAsync(itemToAdd);
        await _dataContext.SaveChangesAsync();
    }

    public async Task DeleteItemByIdAsync(int id)
    {
        var item = await _dataContext.SystemRequirements.FindAsync(id) ?? throw new ArgumentNullException();
        _dataContext.SystemRequirements.Remove(item);
        await _dataContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<SystemRequirementDto>> GetAllItemsAsync()
    {
        var items = await _dataContext.SystemRequirements.AsNoTracking().ToListAsync();
        var result = new List<SystemRequirementDto>();

        foreach (var item in items)
        {
            result.Add(new SystemRequirementDto()
            {
                Id = item.Id,
                FreeSpace = item.FreeSpace,
                Processor = new ProcessorDto()
                {
                    Id = item.Processor!.Id,
                    Info = item.Processor.Info
                },
                Ram = new RamDto()
                {
                    Id = item.Ram!.Id,
                    Info = item.Ram.Info
                },
                Videocard = new VideocardDto()
                {
                    Id = item.Videocard!.Id,
                    Info = item.Videocard.Info
                },
            });
        }

        return result;
    }

    public async Task<SystemRequirementDto?> GetItemByIdAsync(int id)
    {
        var item = await _dataContext.SystemRequirements.AsNoTracking().FirstAsync(x => x.Id == id);
        var result = new SystemRequirementDto()
        {
            Id = item.Id,
            FreeSpace = item.FreeSpace,
            Processor = new ProcessorDto()
            {
                Id = item.Processor!.Id,
                Info = item.Processor.Info
            },
            Ram = new RamDto()
            {
                Id = item.Ram!.Id,
                Info = item.Ram.Info
            },
            Videocard = new VideocardDto()
            {
                Id = item.Videocard!.Id,
                Info = item.Videocard.Info
            },
        };

        return result;
    }

    public async Task UpdateItemAsync(SystemRequirementDto item)
    {
        var itemToUpdate = new SystemRequirement()
        {
            Id = item.Id,
            FreeSpace = item.FreeSpace,
            Processor = new Processor()
            {
                Id = item.Processor!.Id,
                Info = item.Processor.Info
            },
            Ram = new Ram()
            {
                Id = item.Ram!.Id,
                Info = item.Ram.Info
            },
            Videocard = new Videocard()
            {
                Id = item.Videocard!.Id,
                Info = item.Videocard.Info
            },
        };

        _dataContext.SystemRequirements.Update(itemToUpdate);
        await _dataContext.SaveChangesAsync();
    }
}
