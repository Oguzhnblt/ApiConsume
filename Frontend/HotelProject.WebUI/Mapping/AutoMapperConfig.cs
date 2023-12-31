﻿using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AboutDTO;
using HotelProject.WebUI.DTOs.AppUserDTO;
using HotelProject.WebUI.DTOs.BookingDTO;
using HotelProject.WebUI.DTOs.ContactDTO;
using HotelProject.WebUI.DTOs.GuestDTO;
using HotelProject.WebUI.DTOs.LoginDTO;
using HotelProject.WebUI.DTOs.RegisterDTO;
using HotelProject.WebUI.DTOs.RoomDTO;
using HotelProject.WebUI.DTOs.SendMessageDTO;
using HotelProject.WebUI.DTOs.ServiceDTO;
using HotelProject.WebUI.DTOs.StaffDTO;
using HotelProject.WebUI.DTOs.SubscribeDTO;
using HotelProject.WebUI.DTOs.TestimonialDTO;

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

            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();

            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDTO, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDTO, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<ApprovedBookingDTO, Booking>().ReverseMap();
            CreateMap<ResultLast6BookingDTO, Booking>().ReverseMap();

            CreateMap<CreateContactDTO, Contact>().ReverseMap();
            CreateMap<ResultContactDTO, Contact>().ReverseMap();


            CreateMap<ResultRoomDTO, Room>().ReverseMap();
            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
            CreateMap<CreateRoomDTO, Room>().ReverseMap();

            CreateMap<ResultGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Room>().ReverseMap();
            CreateMap<CreateGuestDTO, Room>().ReverseMap();


            CreateMap<CreateSendMessage, SendMessage>().ReverseMap();
            CreateMap<ResultSendBoxDTO, SendMessage>().ReverseMap();
            CreateMap<GetMessageByIdDTO, SendMessage>().ReverseMap();

            CreateMap<ResultAppUserDTO, AppUser>().ReverseMap();
            CreateMap<ResultAppUserListDTO, AppUser>().ReverseMap();





















        }
    }
}
