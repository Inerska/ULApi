using System;
using System.Net;

namespace WidgetIutNc.Api;

public class AutoRedirecterWebClient
    : WebClient
{
    protected override WebRequest GetWebRequest(Uri address)
    {
        var request = base.GetWebRequest(address) as HttpWebRequest;
        request.AllowAutoRedirect = false;
        try
        {
            var response = request.GetResponse();
        }
        catch (WebException e)
        {
            var redirectLocation = e.Response.Headers["Location"];
            using var client = new AutoRedirecterWebClient();
            var response = client.DownloadString(redirectLocation);
        }

        return request;
    }
}

