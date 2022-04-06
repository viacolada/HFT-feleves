using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Models.Models
{
    public class MostPopularRestaurantModel
    {
        public string RestaurantName { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as BestOfferModel;

            if (other == null)
                return false;

            return other.RestaurantName == RestaurantName;
        }

        public override string ToString()
        {
            return $"{RestaurantName} is the most popular Restaurant.";
        }
    }
}
