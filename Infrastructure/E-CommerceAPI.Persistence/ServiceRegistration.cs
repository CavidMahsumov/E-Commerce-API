using Microsoft.EntityFrameworkCore;
using E_CommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace E_CommerceAPI.Persistence
{
    public static class ServiceRegistration
    { 
        public static void AddPersistenceServices(this IServiceCollection services)
        {
           
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
