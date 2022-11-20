using System.Text;
using System.Text.Json;
using Business.Session;
using Business.Session.Dto.Param;
using Business.Utilities.Extensions;
using Core.Dto.Param;
using Microsoft.AspNetCore.Http;

namespace Business.Utilities.Middlewares;

public class SessionMiddleware : IMiddleware
{
    private readonly ISessionService _sessionService;

    public SessionMiddleware(ISessionService sessionService)
    {
        _sessionService = sessionService;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Session.LoadAsync();

        if (!context.Session.Keys.Contains(MiddlewareConstants.SessionName))
        {
            var model = GetSessionForSend(context);
            var result = await _sessionService.GetAsync(model);

            if (!result.IsSuccess) throw new Exception(result.Message);

            var data = new SessionForDevice { DeviceId = result.Data.DeviceId, SessionId = result.Data.SessionId };
            var json = JsonSerializer.Serialize(data);
            context.Session.Set(MiddlewareConstants.SessionName, Encoding.UTF8.GetBytes(json));

            await context.Session.CommitAsync();
        }

        await next(context);
    }

    private SessionForSend GetSessionForSend(HttpContext context)
    {
        var browserInfo = context.GetBrowserInfo();
        var connectionInfo = context.GetConnectionInfo();
        return new SessionForSend
        {
            Type = 1,
            Browser = new BrowserForSession { Name = browserInfo.Name, Version = browserInfo.Version },
            Connection = new ConnectionForSession { IpAddress = connectionInfo.IpAddress, Port = connectionInfo.Port }
        };
    }
}
