using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace SwaggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>().UseUrls("http://localhost:5000")
                .Build()
                .Run();
        }
    }
}
