using System.Net;

namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpResponseSender
{
	Task SendAsync(IPEndPoint remoteEndPoint, string body, CancellationToken cancellationToken);
}
