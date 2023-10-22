using E_CommerceAPI.Application.Abstarctions.Storage;
using E_CommerceAPI.Infrastructure.Enums;
using E_CommerceAPI.Infrastructure.Services;
using E_CommerceAPI.Infrastructure.Services.Storage;
using E_CommerceAPI.Infrastructure.Services.Storage.Azure;
using E_CommerceAPI.Infrastructure.Services.Storage.Local;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.LocalStorage:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.AzureStorage:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
