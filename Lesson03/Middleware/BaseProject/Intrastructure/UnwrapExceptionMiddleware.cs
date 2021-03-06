﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Intrastructure
{
    public class UnwrapExceptionMiddleware
    {
        private readonly RequestDelegate next;
        public UnwrapExceptionMiddleware(RequestDelegate next) => this.next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex.GetBaseException()).Throw();
            }
        }
    }
}
