namespace Business.ApiClient;

public interface IApiClientService
{
    Task<TResult> PostAsync<TResult, TParam>(string url, TParam param, CancellationToken cancellationToken = default);
}
