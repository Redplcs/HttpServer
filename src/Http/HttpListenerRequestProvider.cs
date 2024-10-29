using Microsoft.Extensions.Logging;
using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpListenerRequestProvider(HttpListener listener, ILogger<HttpListenerRequestProvider> logger) : IHttpRequestProvider
{
	public async Task<IHttpRequest> GetRequestAsync(CancellationToken cancellationToken = default)
	{
		var context = await listener.GetContextAsync().WaitAsync(cancellationToken);

		var connection = new HttpListenerConnection(context);
		var request = new HttpListenerRequest(connection);
		return request;
	}
}
