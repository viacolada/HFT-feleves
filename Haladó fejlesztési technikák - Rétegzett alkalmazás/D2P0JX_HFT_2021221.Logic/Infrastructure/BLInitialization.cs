using D2P0JX_HFT_2021221.Logic.Interfaces;
using D2P0JX_HFT_2021221.Logic.Services;
using D2P0JX_HFT_2021221.Repository.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Logic.Infrastructure
{
    public static class BLInitialization
    {
        public static void InitBlServices(IServiceCollection services)
        {
            RepoInitialization.InitRepoServices(services);

            services.AddScoped<IPizzaLogic, PizzaLogic>();
            services.AddScoped<ICustomerLogic, CustomerLogic>();
            services.AddScoped<IRestaurantLogic, RestaurantLogic>();
        }
    }
}
