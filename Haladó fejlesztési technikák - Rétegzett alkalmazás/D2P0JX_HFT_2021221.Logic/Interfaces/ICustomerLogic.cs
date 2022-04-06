using D2P0JX_HFT_2021221.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Logic.Interfaces
{
    public interface ICustomerLogic
    {
        IList<Customer> ReadAll();
        Customer Read(int id);
        Customer Create(Customer entity);
        Customer Update(Customer entity);
        void Delete(int id);
        List<Customer> ReadAllByPizzaId(int customerId);
    }
}
