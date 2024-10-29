using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpListenerRequestProvider(HttpListener listener) : IHttpRequestProvider
{
	public async Task<IHttpRequest> GetRequestAsync(CancellationToken cancellationToken = default)
	{
		var context = await listener.GetContextAsync();

		cancellationToken.ThrowIfCancellationRequested();

		var connection = new HttpListenerConnection(context);
		var request = new HttpListenerRequest(connection);
		return request;
	}
}
