using GameStore.DAL.Data;
using GameStore.DAL.Models;

namespace GameStore.BLL.Interfaces;

public interface IService<T>
{
    public T? GetItemById(int id);

    public IEnumerable<T> GetAllItems();

    public void AddItem(T item);

    public void DeleteItemById(int id);

    public void UpdateItem(T item);
}
