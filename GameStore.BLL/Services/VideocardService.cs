using GameStore.BLL.DTO;
using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services;
public class VideocardService : IRepositoryAsync<VideocardDto>
{
    private readonly DataContext _dataContext;
    public VideocardService()
    {
        _dataContext = new DataContext();
    }

    public async Task<VideocardDto?> GetItemByIdAsync(int id)
    {
        var videocard = await _dataContext.Videocards.AsNoTracking().FirstAsync(x => x.Id == id);
        var result = new VideocardDto()
        {
            Info = videocard.Info,
            Id = videocard.Id
        };

        return result;
    }

    public async Task<IEnumerable<VideocardDto>> GetAllItemsAsync()
    {
        var videocards = await _dataContext.Videocards.AsNoTracking().ToListAsync();
        var result = new List<VideocardDto>();

        foreach (var videocard in videocards)
        {
            result.Add(new VideocardDto()
            {
                Info = videocard.Info,
                Id = videocard.Id
            });
        }

        return result;
    }

    public async Task AddItemAsync(VideocardDto videocard)
    {
        var videocardToAdd = new Videocard()
        {
            Info = videocard.Info,
            Id = videocard.Id
        };

        await _dataContext.Videocards.AddAsync(videocardToAdd);
        await _dataContext.SaveChangesAsync();
    }

    public async Task DeleteItemByIdAsync(int id)
    {
        var videocard = await _dataContext.Videocards.FindAsync(id) ?? throw new ArgumentNullException();
        _dataContext.Videocards.Remove(videocard);
        await _dataContext.SaveChangesAsync();
    }

    public async Task UpdateItemAsync(VideocardDto videocard)
    {
        var videocardToUpdate = new Videocard()
        {
            Id = videocard.Id,
            Info = videocard.Info
        };

        _dataContext.Videocards.Update(videocardToUpdate);
        await _dataContext.SaveChangesAsync();
    }
}
