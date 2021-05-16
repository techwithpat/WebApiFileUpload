using Microsoft.AspNetCore.Http;

namespace WebApiFileUpload.Services
{
    public interface IStorageService
    {
        void Upload(IFormFile formFile);
    }
}
