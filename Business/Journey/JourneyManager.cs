using Business.ApiClient;
using Business.Journey.Dto.Param;
using Business.Journey.Dto.Result;
using Business.Session;
using Core.Dependencies;
using Core.Dto.Param;
using Core.Dto.Result;

namespace Business.Journey;

public class JourneyManager : IJourneyService, IScopedDependency
{
    private readonly ISessionService _sessionService;
    private readonly IApiClientService _apiClientService;

    public JourneyManager(ISessionService sessionService, IApiClientService apiClientService)
    {
        _sessionService = sessionService;
        _apiClientService = apiClientService;
    }

    public async Task<Result<IList<JourneyForBus>>> GetAsync(LocationForJourney journey, CancellationToken cancellationToken = default)
    {
        var param = new Param<LocationForJourney> { Data = journey, DeviceSession = _sessionService.Get() };

        var result = await _apiClientService.PostAsync<Result<IList<JourneyForBus>>, Param<LocationForJourney>>(ApiClientConstants.JourneyUrl, param);

        if (result.IsSuccess) result.Data = result.Data.OrderBy(o => o.Journey.Departure).ToList();

        return result;
    }
}
