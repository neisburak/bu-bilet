using Business.ApiClient;
using Business.Location.Dto.Result;
using Business.Session;
using Core.Dependencies;
using Core.Dto.Param;
using Core.Dto.Result;

namespace Business.Location;

public class LocationManager : ILocationService, IScopedDependency
{
    private readonly ISessionService _sessionService;
    private readonly IApiClientService _apiClientService;

    public LocationManager(ISessionService sessionService, IApiClientService apiClientService)
    {
        _sessionService = sessionService;
        _apiClientService = apiClientService;
    }

    public async Task<Result<IList<LocationForBus>>> GetAsync(string query, CancellationToken cancellationToken = default)
    {
        var param = new Param<string> { Data = query, DeviceSession = _sessionService.Get() };
        
        return await _apiClientService.PostAsync<Result<IList<LocationForBus>>, Param<string>>(ApiClientConstants.LocationUrl, param);
    }
}
