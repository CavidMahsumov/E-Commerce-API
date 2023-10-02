using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Services
{
    public interface IFileService
    {
        Task<(List<string> filename,string path)> UploadAsync(string path, IFormFileCollection
            files);
        Task<string>FileRenameAsync(string filename);
        Task<bool> CopyFileAsync(string path,IFormFile file);


    }
}
