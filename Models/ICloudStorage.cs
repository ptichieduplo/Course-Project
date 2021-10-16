using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface ICloudStorage
    {
        public interface ICloudStorage
        {
            Task<string> UploadFileAsync(IFormFile imageFile, string fileNameForStorage);
            System.Threading.Tasks.Task DeleteFileAsync(string fileNameForStorage);
        }
    }
}
