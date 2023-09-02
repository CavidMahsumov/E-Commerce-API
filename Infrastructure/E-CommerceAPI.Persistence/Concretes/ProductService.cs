using E_CommerceAPI.Application.Abstraction;
using E_CommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() 
        {
            new(){Id=Guid.NewGuid(),Name="Produc 1",Price=100,Stock=10}, 
            new(){Id=Guid.NewGuid(),Name="Produc 2",Price=200,Stock=10}, 
            new(){Id=Guid.NewGuid(),Name="Produc 3",Price=300,Stock=10}, 
            new(){Id=Guid.NewGuid(),Name="Produc 4",Price=400,Stock=10}, 
        };
    }
}
