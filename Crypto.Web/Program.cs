using Crypto.Web.Clients.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Crypto.Web.Services;
using Crypto.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Crypto.Web.Extensions;
using Blazored.LocalStorage;
using Crypto.Web.Clients;

namespace Crypto.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddLocalization();


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });



            builder.Services.AddHttpClient<ICryptoClient, CryptoClient>(client => client.BaseAddress = new Uri("https://localhost:50001/api/"));
            builder.Services.AddSingleton<ICryptoService, CryptoService>();

            builder.Services.AddBlazoredLocalStorage();


            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped(sp =>
                new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });



            var host = builder.Build();
            await host.SetDefaultCulture();

            await host.RunAsync();
        }
    }
}
