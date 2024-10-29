using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpRequest
{
	HttpMethod Method { get; }
	IPEndPoint RemoteEndPoint { get; }

	IHttpConnection Connection { get; }
}