using System.Buffers;
using System.Text;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpListenerResponseSender : IHttpResponseSender
{
	public async Task SendAsync(IHttpConnection connection, string body, CancellationToken cancellationToken)
	{
		var context = (connection as HttpListenerConnection)!.Context;
		var response = context.Response;

		var buffer = ArrayPool<byte>.Shared.Rent(body.Length);

		try
		{
			int byteCount = Encoding.UTF8.GetBytes(body, 0, body.Length, buffer, 0);

			response.ContentLength64 = byteCount;

			using var outputStream = response.OutputStream;
			await outputStream.WriteAsync(buffer, cancellationToken);
			await outputStream.FlushAsync(cancellationToken);
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buffer);
		}
	}
}
