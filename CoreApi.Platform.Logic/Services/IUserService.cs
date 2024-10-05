using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>?> GetUsersAsync();

        Task<User?> GetUserAsync();
    }
}
