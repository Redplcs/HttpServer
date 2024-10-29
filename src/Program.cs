using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Redplcs.GtfoOfMyServer.Http;
using System.Net;

var host = Host.CreateApplicationBuilder(args);

host.Services.AddSingleton(_ =>
{
	var listener = new HttpListener();
	listener.Prefixes.Add("http://localhost:8888/");
	listener.Start();
	return listener;
});
host.Services.AddSingleton<IHttpRequestProvider, HttpListenerRequestProvider>();
host.Services.AddHostedService<HttpRequestProcessorWorker>();

await host.Build().RunAsync();
