using Business.Location.Dto.Result;
using Core.Dto.Param;
using Core.Dto.Result;

namespace Business.Location;

public interface ILocationService
{
    Result<IList<LocationForBus>> Get(Param<string> param);
    Task<Result<IList<LocationForBus>>> GetAsync(Param<string> param, CancellationToken cancellationToken = default);
}
