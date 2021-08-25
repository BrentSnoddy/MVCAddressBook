using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVCAddressBook.Services.interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
