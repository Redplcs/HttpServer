using Microsoft.Extensions.Hosting;

namespace Redplcs.GtfoOfMyServer.Http;

public class HttpRequestProcessorWorker(IHttpRequestProvider requests, IHttpResponseSender sender) : BackgroundService
{
	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (stoppingToken.IsCancellationRequested == false)
		{
			var request = await requests.GetRequestAsync(stoppingToken);

			await SendMessage(request, stoppingToken);
		}
	}

	private async Task SendMessage(IHttpRequest request, CancellationToken cancellationToken)
	{
		await sender.SendAsync(request.RemoteEndPoint, "Get the fuck out!", cancellationToken);
	}
}
