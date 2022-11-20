using Business.Session.Dto.Param;
using Business.Session.Dto.Result;
using Core.Dto.Param;
using Core.Dto.Result;

namespace Business.Session;

public interface ISessionService
{
    Task<Result<ResponseForSession>> GetAsync(SessionForSend sessionForSend, CancellationToken cancellationToken = default);
    SessionForDevice Get();
}
