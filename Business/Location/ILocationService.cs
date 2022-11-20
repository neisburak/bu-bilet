using Business.Location.Dto.Result;
using Core.Dto.Result;

namespace Business.Location;

public interface ILocationService
{
    Task<Result<IList<LocationForBus>>> GetAsync(string query, CancellationToken cancellationToken = default);
}
