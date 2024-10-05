using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

using CoreApi.Platform.Domain.Models;
using CoreApi.Platform.Logic.Services;

namespace CoreApi.View.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(IUserService userService) : ControllerBase
    {
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IEnumerable<User>?> Get() => userService.GetUsersAsync();

        [HttpGet("[action]")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<User?> First() => userService.GetUserAsync();
    }
}
