using D2P0JX_HFT_2021221.Logic.Interfaces;
using D2P0JX_HFT_2021221.Logic.Models;
using D2P0JX_HFT_2021221.Models.Entities;
using D2P0JX_HFT_2021221.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D2P0JX_HFT_2021221.Endpoint.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        readonly IPizzaLogic pizzaLogic;


        public PizzaController(IPizzaLogic pizzaLogic)
        {
            this.pizzaLogic = pizzaLogic;

        }


        // GET: api/Pizza/GetAll
        [HttpGet]
        [ActionName("GetAll")]
        public IEnumerable<Pizza> Get()
        {
            return pizzaLogic.ReadAll();
        }

        // GET api/Pizza/5
        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return pizzaLogic.Read(id);
        }

        // POST api/Pizza/Create
        [HttpPost]
        [ActionName("Create")]
        public ApiResult Post(Pizza pizza)
        {
            var result = new ApiResult(true);

            try
            {
                pizzaLogic.Create(pizza);
            }
            catch (Exception)
            {

                result.IsSuccess = false;
            }

            return result;
        }

        // PUT api/Pizza/Update
        [HttpPut]
        [ActionName("Update")]
        public ApiResult Put(Pizza pizza)
        {
            var result = new ApiResult(true);

            try
            {
                pizzaLogic.Update(pizza);
            }
            catch (Exception)
            {

                result.IsSuccess = false;
            }

            return result;
        }

        // DELETE api/Pizza/5
        [HttpDelete("{id}")]
        public ApiResult Delete(int id)
        {
            var result = new ApiResult(true);

            try
            {
                pizzaLogic.Delete(id);
            }
            catch (Exception)
            {

                result.IsSuccess = false;
            }

            return result;
        }

        [HttpGet]
        public IEnumerable<BestOfferModel> GetBestOffers()
        {
            return pizzaLogic.GetBestOffers();
        }


        // GET: api/Pizza/GetMostPopularPizzas
        [HttpGet]
        public IEnumerable<MostPopularPizzaModel> GetMostPopularPizzas()
        {
            return pizzaLogic.GetMostPopularPizzas();
        }

    }
}
