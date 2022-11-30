using System.Text;
using System.Text.Json;
using Business.ApiClient;
using Business.Session.Dto.Param;
using Business.Session.Dto.Result;
using Business.Utilities.Middlewares;
using Core.Dependencies;
using Core.Dto.Param;
using Core.Dto.Result;
using Microsoft.AspNetCore.Http;

namespace Business.Session;

public class SessionManager : ISessionService, IScopedDependency
{
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly IApiClientService _apiClientService;

    public SessionManager(IHttpContextAccessor contextAccessor, IApiClientService apiClientService)
    {
        _contextAccessor = contextAccessor;
        _apiClientService = apiClientService;
    }

    public async Task<Result<ResponseForSession>> GetAsync(SessionForSend sessionForSend, CancellationToken cancellationToken = default)
    {
        return await _apiClientService.PostAsync<Result<ResponseForSession>, SessionForSend>(ApiClientConstants.SessionUrl, sessionForSend);
    }

    public SessionForDevice Get()
    {
        if (_contextAccessor.HttpContext.Session.TryGetValue(MiddlewareConstants.SessionName, out byte[] session))
        {
            var data = Encoding.UTF8.GetString(session);
            var result = JsonSerializer.Deserialize<SessionForDevice>(data);

            if (result is null) throw new Exception("Session info was null.");
            return result;
        }

        throw new Exception("Session info was null.");
    }
}
