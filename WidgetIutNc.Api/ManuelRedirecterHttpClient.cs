using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WidgetIutNc.Api;

public class ManuelRedirecterHttpClient
    : HttpClient
{
    public override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);

        if (response.Headers.Location is not null)
        {
            return await base.SendAsync(new HttpRequestMessage(HttpMethod.Get, response.Headers.Location), cancellationToken);
        }
        else
        {
            return response;
        }
    }
}

