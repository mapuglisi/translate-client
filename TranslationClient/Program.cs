using BlazorStrap;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TranslationClient.Services;

namespace TranslationClient
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient<ITranslationService, TranslationService>(x => x.BaseAddress = new Uri("http://localhost:8090"));
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBootstrapCss();

            await builder.Build().RunAsync();
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
