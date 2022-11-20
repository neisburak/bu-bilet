using Business.Journey.Dto.Param;
using Business.Journey.Dto.Result;
using Core.Dto.Param;

namespace Business.Journey;

public interface IJourneyService
{
    Task<IList<JourneyForBus>> GetAsync(Param<LocationForJourney> param, CancellationToken cancellationToken = default);
}
