using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Logic.Models
{
    public class AverageModel
    {
        public string RestaurantName { get; set; }
        public double Average { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as AverageModel;

            if (other == null)
                return false;

            return other.RestaurantName == RestaurantName && other.Average == Average;
        }

        public override string ToString()
        {
            return $"{RestaurantName} - {Average}";
        }
    }
}
