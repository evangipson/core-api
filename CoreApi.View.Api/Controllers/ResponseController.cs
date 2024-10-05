using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

using CoreApi.Platform.Domain.Models;
using CoreApi.Platform.Logic.Managers;

namespace CoreApi.View.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResponseController(IResponseManager responseManager) : ControllerBase
    {
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public BasicResponse Get(string? query) => responseManager.GetBasicResponse(query);

        [HttpGet("[action]")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ComplexResponse Complex(string? vehicle) => responseManager.GetComplexResponse(vehicle);
    }
}
