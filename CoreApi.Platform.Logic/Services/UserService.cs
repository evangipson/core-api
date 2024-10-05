using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using AutoMapper;

using CoreApi.Platform.Domain.ApplicationSettings;
using CoreApi.Platform.Domain.Constants;
using CoreApi.Platform.Domain.DTOs;
using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Services
{
    public class UserService(IHttpClientFactory httpClientFactory, IOptions<DataProviders> options, IMapper mapper) : IUserService
    {
        private readonly HttpClient _httpClient = httpClientFactory.CreateClient(DataProvidersConstants.UserSystemClientName);
        private readonly DataProvider? _userSystemSettings = options.Value.Providers?.FirstOrDefault(provider => provider.Name == DataProvidersConstants.UserSystemClientName);

        public async Task<IEnumerable<User>?> GetUsersAsync()
        {
            var userResponse = await GetUsersFromUserSystemAsync();
            return mapper.Map<User[]>(userResponse);
        }

        public async Task<User?> GetUserAsync()
        {
            var userResponse = await GetUsersFromUserSystemAsync();
            var firstUser = userResponse.First();
            return mapper.Map<User>(firstUser);
        }

        private async Task<List<UserSystemUserData>?> GetUsersFromUserSystemAsync()
        {
            var results = await _httpClient.GetAsync(_userSystemSettings?.Endpoint);
            return await results.Content.ReadFromJsonAsync<List<UserSystemUserData>>();
        }
    }
}
