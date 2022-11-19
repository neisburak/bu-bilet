using Business.Session.Dto.Param;
using Business.Session.Dto.Result;
using Core.Dto.Result;

namespace Business.Session;

public interface ISessionService
{
    Result<ResponseForSession> GetSession(SessionForSend sessionForSend);
    Task<Result<ResponseForSession>> GetSessionAsync(SessionForSend sessionForSend, CancellationToken cancellationToken = default);
}
