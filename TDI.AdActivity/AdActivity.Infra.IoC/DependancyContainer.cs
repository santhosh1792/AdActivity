using AdActivity.Application.Interfaces;
using AdActivity.Application.Services;
using AdActivity.Domain.Interfaces;
using AdActivity.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdActivity.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICampaignService, CampaignService>();

            //Infra.Data Layer
            services.AddScoped<ICampaignRepository, CampaignRepository>();
        }
    }
}
