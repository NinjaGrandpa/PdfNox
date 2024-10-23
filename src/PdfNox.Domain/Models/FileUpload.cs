using Microsoft.AspNetCore.Http;

namespace PdfNox.Domain.Models;

public class FileUpload
{
    public required IFormFile File { get; set; }
}
