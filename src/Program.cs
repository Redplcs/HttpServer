using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Redplcs.GtfoOfMyServer.Http;

var host = Host.CreateApplicationBuilder(args);

host.Services.AddHostedService<HttpRequestProcessorWorker>();

await host.Build().RunAsync();
