﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace chesterfieldsDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChesterfieldsEntities : DbContext
    {
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<HotelImage> HotelImages { get; set; }
        public virtual DbSet<HotelInfo> HotelInfoes { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<RoomBooking> RoomBookings { get; set; }
        public virtual DbSet<RoomDetail> RoomDetails { get; set; }
        public virtual DbSet<RoomImage> RoomImages { get; set; }
        public virtual DbSet<StayDetail> StayDetails { get; set; }
    }
}