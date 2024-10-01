using CoreApi.Platform.Domain.Models;

namespace CoreApi.Platform.Logic.Managers
{
    public interface IResponseManager
    {
        BasicResponse GetBasicResponse(string? queryValue = null);

        ComplexResponse GetComplexResponse(string? vehicleType = null);
    }
}
