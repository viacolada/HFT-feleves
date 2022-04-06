using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Models.Models
{
    public class IncomeModel
    {
        public string RestaurantName { get; set; }
        public int Income { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as IncomeModel;

            if (other == null)
                return false;

            return other.RestaurantName == RestaurantName && other.Income == Income;
        }

        public override string ToString()
        {
            return $"{RestaurantName} - {Income}";
        }
    }
}
