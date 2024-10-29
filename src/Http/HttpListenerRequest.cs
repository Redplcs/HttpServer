namespace Redplcs.GtfoOfMyServer.Http;

public class HttpListenerRequest(HttpListenerConnection connection) : IHttpRequest
{
	public IHttpConnection Connection => connection;
}
