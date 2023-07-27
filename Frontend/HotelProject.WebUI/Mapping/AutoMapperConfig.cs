using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.LoginDTO;
using HotelProject.WebUI.DTOs.RegisterDTO;
using HotelProject.WebUI.DTOs.ServiceDTO;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();

            CreateMap<CreateRegisterDTO, AppUser>().ReverseMap();

            CreateMap<LoginUserDTO, AppUser>().ReverseMap();





        }
    }
}
