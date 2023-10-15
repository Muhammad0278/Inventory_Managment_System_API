using AutoMapper;
using Inventroy_System_API.Data;
using Inventroy_System_API.Models;

namespace Inventroy_System_API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
        }


    }
}
