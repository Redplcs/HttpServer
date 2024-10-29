using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpRequestProcessorWorker(IHttpRequestProvider requests, IHttpResponseSender sender, ILogger<HttpRequestProcessorWorker> logger) : BackgroundService
{
	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (stoppingToken.IsCancellationRequested == false)
		{
			var request = await requests.GetRequestAsync(stoppingToken);
			logger.LogHttpRequestReceived(request);

			await SendMessage(request, stoppingToken);
		}
	}

	private async Task SendMessage(IHttpRequest request, CancellationToken cancellationToken)
	{
		var message = "Get the fuck out!";
		var connection = request.Connection;

		await sender.SendAsync(connection, message, cancellationToken);
	}
}
