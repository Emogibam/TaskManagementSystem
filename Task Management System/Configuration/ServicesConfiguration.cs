using TaskManagementSystem.Infrastruture.Repository.Implementation;
using TaskManagementSystem.Infrastruture.Repository.Interfaces;

namespace Task_Management_System.Configuration
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
        }
    }
}
