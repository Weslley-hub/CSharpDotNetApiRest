using AutoMapper;
using Dws.Note_one.Api.Domain.Models;
using Dws.Note_one.Api.Resource;

namespace Supermarket.Api.Mapping
{

    public class ModelToResourceProfile : Profile
    {
         public ModelToResourceProfile()
            {
             CreateMap<Category, CategoryResource>();
            }
    }
}