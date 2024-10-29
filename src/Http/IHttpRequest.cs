namespace Redplcs.GtfoOfMyServer.Http;

public interface IHttpRequest
{
	IHttpConnection Connection { get; }
}