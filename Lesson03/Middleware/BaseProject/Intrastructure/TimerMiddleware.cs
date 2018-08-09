using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using BaseProject.Intrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Intrastructure
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate next;
        public TimerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var start = new Stopwatch();
            start.Start();
            await next(context);
            start.Stop();
            Console.WriteLine(start.ElapsedTicks);
        }
    }
}
