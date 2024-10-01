using Microsoft.AspNetCore.Mvc;

using CoreApi.Platform.Domain.Models;
using CoreApi.Platform.Logic.Managers;

namespace CoreApi.View.Api.Controllers
{
    [Route("/response")]
    public class ResponseController(IResponseManager responseManager) : Controller
    {
        [HttpGet]
        [Produces("application/json")]
        public BasicResponse GetBasicResponse(string? query) => responseManager.GetBasicResponse(query);

        [HttpGet("complex")]
        [Produces("application/json")]
        public ComplexResponse GetComplexResponse(string? vehicle) => responseManager.GetComplexResponse(vehicle);
    }
}
