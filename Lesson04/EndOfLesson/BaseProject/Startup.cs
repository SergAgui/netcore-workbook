<<<<<<< HEAD
<<<<<<< HEAD:Lesson04/BaseProject/Startup.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseProject.Data;
using BaseProject.Intrastructure;
using Microsoft.AspNetCore.Builder;
=======
﻿using Microsoft.AspNetCore.Builder;
>>>>>>> dc83028c9ba9fb4541b377d0007dfbc250b429b5:Lesson04/EndOfLesson/BaseProject/Startup.cs
=======
﻿using BaseProject.Data;
using Microsoft.AspNetCore.Builder;
>>>>>>> 0640ce231b976294e4703e043b158336ce894771
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BaseProject")));
=======
            // Comment out if you do not have a local Sql Server installed
            services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BaseProject")));
            // Uncomment if you do not have a local Sql Server installed
            //services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BaseProjectHosted")));
>>>>>>> 0640ce231b976294e4703e043b158336ce894771
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
