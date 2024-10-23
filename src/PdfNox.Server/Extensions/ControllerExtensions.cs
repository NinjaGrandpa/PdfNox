using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PdfNox.API.Results;

namespace PdfNox.API.Extensions;

public static class ControllerExtensions
{
    [NonAction]
    public static UnsupportedMediaTypeResult UnsupportedMediaType(this ControllerBase controller)
        => new UnsupportedMediaTypeResult();

    [NonAction]
    public static UnsupportedMediaTypeObjectResult UnsupportedMediaType(this ControllerBase controller, [ActionResultObjectValue] object? error)
        => new UnsupportedMediaTypeObjectResult(error);

    [NonAction]
    public static UnsupportedMediaTypeObjectResult UnsupportedMediaType(this ControllerBase controller, [ActionResultObjectValue] ModelStateDictionary modelState)
        => new UnsupportedMediaTypeObjectResult(modelState);
}
