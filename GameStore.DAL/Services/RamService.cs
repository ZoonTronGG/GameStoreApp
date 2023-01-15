using GameStore.DAL.Data;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace GameStore.DAL.Services;

public class RamService
{
    private readonly IRepository<Ram> _repository;
	public RamService(IRepository<Ram> repository)
	{
		_repository= repository;
	}

	public Ram GetRamById(int id)
	{
		return _repository.GetById(id);
	}

    public IEnumerable<Ram> GetAllRam(int id)
    {
        return _repository.GetAll();
    }

    public void AddRam(Ram ram)
    {
        _repository.Add(ram);
    }

    public void DeleteRamById(int id)
    {
        _repository.DeleteById(id);
    }

    public void Update(Ram ram)
    {
        _repository.Update(ram);
    }
}
