using GameStore.DAL.Interfaces;

namespace GameStore.DAL.Data;

internal class Repository<T> : IRepository<T> where T : class
{
    private readonly DataContext _context;
    public Repository(DataContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void DeleteById(int id)
    {
        var item = _context.Set<T>().Find(id);
        _context.Set<T>().Remove(item);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}