using D2P0JX_HFT_2021221.Data.DbContexts;
using D2P0JX_HFT_2021221.Models.Entities;
using D2P0JX_HFT_2021221.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Repository.Repositories
{
    public class PizzaRepository : RepositoryBase<Pizza, int>, IPizzaRepository
    {
        public PizzaRepository(PizzaDbContext context) : base(context)
        {
        }

        public override Pizza Read(int id)
        {
            return ReadAll().SingleOrDefault(x => x.Id == id);
        }
    }
}
