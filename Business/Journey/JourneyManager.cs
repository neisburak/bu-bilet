using Business.Journey.Dto.Param;
using Business.Journey.Dto.Result;
using Business.Session;
using Core.Dependencies;
using Core.Dto.Param;

namespace Business.Journey;

public class JourneyManager : IJourneyService, IScopedDependency
{
    private readonly ISessionService _sessionService;

    public JourneyManager(ISessionService sessionService)
    {
        _sessionService = sessionService;
    }

    public Task<IList<JourneyForBus>> GetAsync(Param<LocationForJourney> param, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
