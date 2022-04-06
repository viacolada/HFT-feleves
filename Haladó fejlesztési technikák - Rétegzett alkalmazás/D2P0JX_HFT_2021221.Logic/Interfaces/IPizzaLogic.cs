using D2P0JX_HFT_2021221.Logic.Models;
using D2P0JX_HFT_2021221.Models.Entities;
using D2P0JX_HFT_2021221.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Logic.Interfaces
{
    public interface IPizzaLogic
    {
        IList<Pizza> ReadAll();
        Pizza Read(int id);
        Pizza Create(Pizza entity);
        Pizza Update(Pizza entity);
        void Delete(int id);
        List<Pizza> ReadAllByRestaurantId(int pizzaId);
        IEnumerable<BestOfferModel> GetBestOffers();
        IEnumerable<MostPopularPizzaModel> GetMostPopularPizzas();
    }
}
