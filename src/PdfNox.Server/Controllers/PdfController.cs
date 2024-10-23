using Microsoft.AspNetCore.Mvc;
using PdfNox.API.Results;
using PdfNox.Domain.Models;

namespace PdfNox.Server;

[ApiController]
[Route("[controller]")]
public class PdfController(IWebHostEnvironment _env) : Controller
{

    [HttpPost]
    public async Task<IActionResult> PostFormData([FromForm] FileUpload model)
    {
        if (!Request.HasFormContentType)
            return new UnsupportedMediaTypeObjectResult("Unsupported Media Type");

        if (model?.File == null || model.File.Length <= 0)
            return BadRequest("No file was uploaded");

        var root = Path.Combine(_env.ContentRootPath, "App_Data");
        var provider = new MultipartFormDataStreamProvider(root);

    }
}
