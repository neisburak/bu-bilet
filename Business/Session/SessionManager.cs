using Business.Session.Dto.Param;
using Business.Session.Dto.Result;
using Core.Dependencies;
using Core.Dto.Result;
using Microsoft.AspNetCore.Http;

namespace Business.Session;

public class SessionManager : ISessionService, IScopedDependency
{
    private readonly IHttpContextAccessor _contextAccessor;

    public SessionManager(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public Result<ResponseForSession> GetSession(SessionForSend sessionForSend)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ResponseForSession>> GetSessionAsync(SessionForSend sessionForSend, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
