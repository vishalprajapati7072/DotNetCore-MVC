using Service.Contract;
using Service.Implementation;

namespace DotNetCore_MVC.Extensions
{
    public static class ServiceDependency
    {
        public static void ConfigureDependency(this IServiceCollection services)
        {
            services.AddTransient<IEmployee, EmployeeService>();

            services.AddScoped<IEmployee, EmployeeService>();

            services.AddSingleton<IEmployee, EmployeeService>();

            // Method intentionally left empty.
        }

    }
}
