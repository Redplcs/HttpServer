using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpListenerRequest(HttpListenerConnection connection) : IHttpRequest
{
	public HttpMethod Method => HttpMethod.Parse(connection.Context.Request.HttpMethod);
	public IPEndPoint RemoteEndPoint => connection.Context.Request.RemoteEndPoint;

	public IHttpConnection Connection => connection;
}
