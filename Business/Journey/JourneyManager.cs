using Business.Journey.Dto.Param;
using Business.Journey.Dto.Result;
using Core.Dependencies;
using Core.Dto.Param;

namespace Business.Journey;

public class JourneyManager : IJourneyService, IScopedDependency
{
    public IList<JourneyForBus> Get(Param<LocationForJourney> param)
    {
        throw new NotImplementedException();
    }

    public Task<IList<JourneyForBus>> GetAsync(Param<LocationForJourney> param, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
