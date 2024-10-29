using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpListenerConnection : IHttpConnection
{
	public HttpListenerConnection(HttpListenerContext context)
	{
		Request = new HttpListenerRequest(this);
		Response = new HttpListenerResponse(this);
	}

	public IHttpRequest Request { get; }
	public IHttpResponse Response { get; }
}