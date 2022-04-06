﻿using D2P0JX_HFT_2021221.Logic.Models;
using D2P0JX_HFT_2021221.Models.Entities;
using D2P0JX_HFT_2021221.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Logic.Interfaces
{
    public interface IRestaurantLogic
    {
        IList<Restaurant> ReadAll();
        Restaurant Read(int id);
        Restaurant Create(Restaurant entity);
        Restaurant Update(Restaurant entity);
        void Delete(int id);
        IEnumerable<AverageModel> GetRestaurantAverages();
        IEnumerable<MostPopularRestaurantModel> GetMostPopularRestaurant();
        IEnumerable<IncomeModel> GetIncomes();
    }
}
