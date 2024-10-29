namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpConnection
{
	IHttpRequest Request { get; }
	IHttpResponse Response { get; }
}
