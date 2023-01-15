using GameStore.DAL.Data;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace GameStore.DAL.Services;

public class RamService
{
    private readonly DataContext _dataContext;
	public RamService()
	{
        _dataContext= new DataContext();
	}


	public Ram GetRamById(int id)
	{
        return _dataContext.Rams.Find(id);

    }

    public IEnumerable<Ram> GetAllRam()
    {
        return _dataContext.Rams.ToList();
    }

    public void AddRam(Ram ram)
    {
        _dataContext.Rams.Add(ram);
    }

    public void DeleteRamById(int id)
    {
        var item = _dataContext.Rams.Find(id);
        _dataContext.Rams.Remove(item);
    }

    public void Update(Ram ram)
    {
        _dataContext.Rams.Update(ram);
    }
}
