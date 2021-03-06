//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PaymentDetail")]
    public partial class PaymentDetail
    {
        [Key]
        public int Payment_Id { get; set; }
        public string Payment_Mode { get; set; }
        public Nullable<double> Price { get; set; }
        public string Customer_Card_Number { get; set; }
        public Nullable<int> Customer_Cvv { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> Hotel_Id { get; set; }
        public Nullable<int> RoomTypeId { get; set; }
        public Nullable<int> RoomBookingId { get; set; }
        public string ExpiryDate { get; set; }
        public string NameonCard { get; set; }
    
        public virtual CustomerInfo CustomerInfo { get; set; }
        public virtual HotelInfo HotelInfo { get; set; }
        public virtual RoomBooking RoomBooking { get; set; }
        public virtual RoomDetail RoomDetail { get; set; }
    }
}
