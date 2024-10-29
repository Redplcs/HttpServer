using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpRequest
{
	IPEndPoint RemoteEndPoint { get; }
}