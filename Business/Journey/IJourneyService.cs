using Business.Journey.Dto.Param;
using Business.Journey.Dto.Result;
using Core.Dto.Result;

namespace Business.Journey;

public interface IJourneyService
{
    Task<Result<IList<JourneyForBus>>> GetAsync(LocationForJourney journey, CancellationToken cancellationToken = default);
}
