namespace ULApi.Services;

/// <summary>
/// Concrete implementation of Graph strategy business layer fetcher service.
/// </summary>
/// <typeparam name="TItem"></typeparam>
public class GraphBusinessFetcherService<TItem>
    : IBusinessFetcherService<TItem>
{
    public TItem? Fetch()
    {
        throw new NotImplementedException();
    }

    public Task<TItem?> FetchAsync()
    {
        throw new NotImplementedException();
    }
}
