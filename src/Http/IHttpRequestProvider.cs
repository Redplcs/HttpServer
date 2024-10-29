namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpRequestProvider
{
	Task<IHttpRequest> GetRequestAsync(CancellationToken cancellationToken = default);
}