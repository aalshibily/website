using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace BlazorStaticWebsite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //Add Blazored LocalStorage support
            //Also pass in option to prettify the JSON
            builder.Services.AddBlazoredLocalStorage(config => 
                config.JsonSerializerOptions.WriteIndented = true);

            await builder.Build().RunAsync();
        }
    }
}
