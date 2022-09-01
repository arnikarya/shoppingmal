using AutoMapper;
using Database_Connection.Entities;
using Final_Assignment_DotNetWebApi.Model;

namespace Final_Assignment_DotNetWebApi.AutoMapper
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<ShoppingMallDetails, ShoppingMallModel>().ReverseMap();
            
        }
    }
}
