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

    [Table("CustomerInfo")]
    public partial class CustomerInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerInfo()
        {
            this.HotelInfoes = new HashSet<HotelInfo>();
            this.PaymentDetails = new HashSet<PaymentDetail>();
            this.RoomBookings = new HashSet<RoomBooking>();
            this.RoomDetails = new HashSet<RoomDetail>();
        }
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public string Gender { get; set; }
        public string Customer_Address { get; set; }
        public string City { get; set; }
        public string Pin_Code { get; set; }
        public string Country { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Passwordd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelInfo> HotelInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBooking> RoomBookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomDetail> RoomDetails { get; set; }
    }
}
