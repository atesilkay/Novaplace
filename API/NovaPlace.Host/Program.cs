using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace NovaPlace.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            string environment = config.GetValue<string>("Environment").ToString();

            var commandHost = new WebHostBuilder()
                                           .UseConfiguration(config)
                                           .UseStartup<Startup>()
                                           .UseKestrel(options =>
                                           {
                                               options.AllowSynchronousIO = true;
                                               options.AddServerHeader = true;
                                           })
                                           .UseUrls("http://localhost:5001")
                                           .UseContentRoot(Directory.GetCurrentDirectory())
                                           .UseEnvironment(environment)
                                           .UseShutdownTimeout(TimeSpan.FromSeconds(2))
                                           .Build();

            commandHost.Run();
        }
    }
}
