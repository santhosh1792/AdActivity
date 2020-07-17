using AdActivity.Application.Interfaces;
using AdActivity.Application.Services;
using AdActivity.Domain.CommandHandlers;
using AdActivity.Domain.Commands;
using AdActivity.Domain.Core.Bus;
using AdActivity.Domain.Interfaces;
using AdActivity.Infra.Bus;
using AdActivity.Infra.Data.Context;
using AdActivity.Infra.Data.Repository;
using MediatR;
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
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCampaignCommand, bool>, CampaignCommandHandler>();

            //Application Layer
            services.AddScoped<ICampaignService, CampaignService>();

            //Infra.Data Layer
            services.AddScoped<ICampaignRepository, CampaignRepository>();
            services.AddScoped<AdActivityDBContext>();
        }
    }
}
