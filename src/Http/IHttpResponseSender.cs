namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpResponseSender
{
	Task SendAsync(IHttpConnection connection, string body, CancellationToken cancellationToken);
}
