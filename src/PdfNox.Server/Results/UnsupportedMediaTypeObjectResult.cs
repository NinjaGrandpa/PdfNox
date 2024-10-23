using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PdfNox.API.Results;

[DefaultStatusCode(DefaultStatusCode)]
public class UnsupportedMediaTypeObjectResult : ObjectResult
{
    private const int DefaultStatusCode = StatusCodes.Status415UnsupportedMediaType;

    public UnsupportedMediaTypeObjectResult([ActionResultObjectValue] object? error)
        : base(error)
    {
        StatusCode = DefaultStatusCode;
    }

    public UnsupportedMediaTypeObjectResult([ActionResultObjectValue] ModelStateDictionary modelState)
        : base(new SerializableError(modelState))
    {
        ArgumentNullException.ThrowIfNull(modelState);

        StatusCode = DefaultStatusCode;
    }

}
