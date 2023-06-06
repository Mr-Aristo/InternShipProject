using InternShipProject.Concrete;
using InternShipProject.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipProject.Container
{
    public static class DependencyInjections
    {
        public static void Dependencies(this IServiceCollection services)
        {
            services.AddScoped<ICircleService,CircleManager>();
            services.AddScoped<ITriangelService,TriangelManager>();

            

        }
    }
}

