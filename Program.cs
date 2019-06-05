using System;
using System.IO;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace KestrelService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
