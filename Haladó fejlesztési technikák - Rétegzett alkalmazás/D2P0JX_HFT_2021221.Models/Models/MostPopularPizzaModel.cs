using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Models.Models
{
    public class MostPopularPizzaModel
    {
        public string RestaurantName { get; set; }
        public string MostPopularPizza { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as MostPopularPizzaModel;

            if (other == null)
                return false;

            return other.RestaurantName == RestaurantName && other.MostPopularPizza == MostPopularPizza;
        }

        public override string ToString()
        {
            return $"At {RestaurantName}, {MostPopularPizza} is the most popular pizza.";
        }
    }
}

