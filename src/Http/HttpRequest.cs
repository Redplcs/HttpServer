using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpRequest(HttpListenerRequest request) : IHttpRequest
{
	public IPEndPoint RemoteEndPoint { get; } = request.RemoteEndPoint;
}
