using System.Text;
using System.Text.Json;
using Core.Dependencies;

namespace Business.ApiClient;

public class ApiClientManager : IApiClientService, ISingletonDependency
{
    private readonly HttpClient _httpClient;

    public ApiClientManager(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient(ApiClientConstants.Name);
    }

    public async Task<TResult> PostAsync<TResult, TParam>(string url, TParam param, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(param, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(url, content, cancellationToken);
        if (response.IsSuccessStatusCode)
        {
            var stream = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<TResult>(stream, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }, cancellationToken);

            if (result is null) throw new Exception($"Response was null from {url}.");

            return result;
        }
        throw new Exception($"An error occurred while getting response from {url}.");
    }
}
