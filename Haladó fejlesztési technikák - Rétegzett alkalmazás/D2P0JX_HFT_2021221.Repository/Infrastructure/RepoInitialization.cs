using D2P0JX_HFT_2021221.Data.DbContexts;
using D2P0JX_HFT_2021221.Repository.Interfaces;
using D2P0JX_HFT_2021221.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Repository.Infrastructure
{
    public static class RepoInitialization
    {
        public static void InitRepoServices(IServiceCollection services)
        {
            services.AddScoped<PizzaDbContext>((sp)=>new PizzaDbContext());
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
