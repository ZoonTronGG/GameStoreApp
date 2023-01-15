using GameStore.DAL.Data;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Models;
using GameStore.DAL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.BLL;

public class Startup
{
    public void ConfigureServices(IServiceCollection serviceDescriptors)
    {
        serviceDescriptors.AddDbContext<DataContext>();
        serviceDescriptors.AddScoped<IRepository<Ram>, Repository<Ram>>();
        serviceDescriptors.AddScoped<RamService>();
    }
}
