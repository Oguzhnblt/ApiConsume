﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocation
    {
        public EFWorkLocationDal(Context context) : base(context)
        {
        }
    }
}
