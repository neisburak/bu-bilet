namespace Business.ApiClient;

public static class ApiClientExtensions
{
    public static HttpClient AddBasicAuthenticationHeader(this HttpClient httpClient, string token)
    {
        var headers = httpClient.DefaultRequestHeaders;
        headers.Add("Authorization", $"Basic {token}");
        return httpClient;
    }
}
