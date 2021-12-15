using Microsoft.Extensions.Configuration;
using RestSharp;
using ULApi.BusinessLayer.Mappings;

namespace ULApi.BusinessLayer;

/// <summary>
/// Concrete implementation of Graph strategy business layer fetcher service.
/// </summary>
/// <typeparam name="TItem">Resulted type after data fetching.</typeparam>
public class GraphBusinessFetcherService<TItem>
    : IBusinessFetcherService<TItem>
{
    private readonly IConfiguration _configuration;

    public GraphBusinessFetcherService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<TItem> FetchAsync(string query)
    {
        var apiUrl = _configuration["Api:Endpoint_Base"];
        ArgumentNullException.ThrowIfNull(apiUrl);

        var client = new RestClient();
        var request = new RestRequest {
            Method = Method.GET,
            Resource = apiUrl
        };

        request.AddHeader("Content-Type", "application/json");
        request.AddJsonBody(new {
            query
        });
        var response = await client.PostAsync<TItem>(request);
        return response;
    }
}