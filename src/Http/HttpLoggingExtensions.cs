using Microsoft.Extensions.Logging;
using System.Net;
using System.Runtime.CompilerServices;

namespace Redplcs.GtfoOfMyServer.Http;

public static partial class HttpLoggingExtensions
{
	public const int RequestReceivedId = 1000;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void LogHttpRequestReceived(this ILogger logger, IHttpRequest request) => logger.LogHttpRequestReceived(request.Method, request.RemoteEndPoint);

	[LoggerMessage(RequestReceivedId, LogLevel.Information, "Received HTTP {method} request from {endpoint}")]
	public static partial void LogHttpRequestReceived(this ILogger logger, HttpMethod method, IPEndPoint endpoint);
}
