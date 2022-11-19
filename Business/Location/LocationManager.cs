using Business.Location.Dto.Result;
using Core.Dependencies;
using Core.Dto.Param;
using Core.Dto.Result;

namespace Business.Location;

public class LocationManager : ILocationService, IScopedDependency
{
    public Result<IList<LocationForBus>> Get(Param<string> param)
    {
        throw new NotImplementedException();
    }

    public Task<Result<IList<LocationForBus>>> GetAsync(Param<string> param, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
