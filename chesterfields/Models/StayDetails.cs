using chesterfieldsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chesterfields.Models
{
    public class StayDetails
    {
        public HotelInfo hotellist { get; set; }
        public RoomDetail roomdetaillist { get; set; }
        public CustomerInfo customerinfolist { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public int noofrooms { get; set; }
        public int noofguests { get; set; }
    }
}