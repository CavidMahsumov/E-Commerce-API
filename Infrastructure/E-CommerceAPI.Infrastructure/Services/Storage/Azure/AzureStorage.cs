using Azure.Storage.Blobs;
using E_CommerceAPI.Application.Abstarctions.Storage.Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Infrastructure.Services.Storage.Azure
{
    public class AzureStorage : IAzureStorage
    {
        readonly BlobServiceClient _blobServiceClient;
        BlobContainerClient _blobContainer;
        public AzureStorage(IConfiguration configuration)
        {
            _blobServiceClient = new(configuration["Storage:Azure"]);
        }
        public Task DeleteAsync(string ContainerName, string fileName)
        {
            throw new NotImplementedException();
        }

        public List<string> GetFiles(string ContainerName)
        {
            throw new NotImplementedException();
        }

        public bool HasFile(string ContainerName, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<List<(string filaName, string pathOrContainerName)>> UploadAsync(string ContainerName, IFormFileCollection files)
        {
            throw new NotImplementedException();
        }
    }
}
