using D2P0JX_HFT_2021221.Models.Entities;

namespace D2P0JX_HFT_2021221.Repository.Interfaces
{
    public interface IRestaurantRepository : IRepositoryBase<Restaurant, int>
    {
        void Delete(Restaurant entity);
    }
}
