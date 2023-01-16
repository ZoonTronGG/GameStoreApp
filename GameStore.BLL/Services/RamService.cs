using GameStore.BLL.Interfaces;
using GameStore.DAL.Data;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace GameStore.DAL.Services;

public class RamService : IService<Ram>
{
    private readonly DataContext _dataContext;
    public RamService()
    {
        _dataContext = new DataContext();
    }
    public Ram? GetItemById(int id)
    {
        return _dataContext.Rams.Find(id);
    }

    public IEnumerable<Ram> GetAllItems()
    {
        return _dataContext.Rams.ToList();
    }

    public void AddItem(Ram ram)
    {
        _dataContext.Rams.Add(ram);
    }

    public void DeleteItemById(int id)
    {
        Ram? item = _dataContext.Rams.Find(id);
        if (item == null)
        {
            throw new ArgumentNullException();
        }
        else
        {
            _dataContext.Rams.Remove(item);
        }
    }

    public void UpdateItem(Ram ram)
    {
        _dataContext.Rams.Update(ram);
    }
}
