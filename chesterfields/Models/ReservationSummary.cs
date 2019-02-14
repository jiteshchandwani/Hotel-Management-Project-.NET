using chesterfieldsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chesterfields.Models
{
    public class ReservationSummary
    {
        public HotelInfo hotellist { get; set; }
        public RoomDetail roomlist { get; set; }
        public RoomBooking roombookinglist { get; set; }
    }
}