﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFContactDal : GenericRepository<Contact>, IContact
    {
        public EFContactDal(Context context) : base(context)
        {
        }
    }
}
