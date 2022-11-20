using System.Text;
using Microsoft.AspNetCore.Http;
using UAParser;

namespace Business.Utilities.Extensions;

public static class HttpContextExtensions
{
    public static ConnectionInfo GetConnectionInfo(this IHttpContextAccessor httpContextAccessor) => httpContextAccessor.HttpContext.GetConnectionInfo();
    public static ConnectionInfo GetConnectionInfo(this HttpContext? httpContext)
    {
        if (httpContext is null) throw new ArgumentNullException(nameof(HttpContext));

        var ipAdress = httpContext.Connection.RemoteIpAddress.ToString();

        return new ConnectionInfo
        {
            IpAddress = ipAdress == "::1" ? "127.0.0.1" : ipAdress,
            Port = httpContext.Connection.RemotePort.ToString()
        };
    }

    public static BrowserInfo GetBrowserInfo(this IHttpContextAccessor httpContextAccessor) => httpContextAccessor.HttpContext.GetBrowserInfo();
    public static BrowserInfo GetBrowserInfo(this HttpContext? httpContext)
    {
        if (httpContext is null) throw new ArgumentNullException(nameof(HttpContext));

        var userAgent = httpContext.Request.Headers["User-Agent"];
        var parser = Parser.GetDefault(new ParserOptions { UseCompiledRegex = true });
        var info = parser.Parse(userAgent);

        return new BrowserInfo
        {
            Name = info.UA.Family,
            Version = info.UA.GetBrowserVersion()
        };
    }

    #region Helper Methods
    private static string GetBrowserVersion(this UserAgent userAgent)
    {
        var sb = new StringBuilder(userAgent.Major);

        if (!string.IsNullOrEmpty(userAgent.Minor)) sb.Append($".{userAgent.Minor}");
        if (!string.IsNullOrEmpty(userAgent.Patch)) sb.Append($".{userAgent.Patch}");

        return sb.ToString();
    }
    #endregion
}
