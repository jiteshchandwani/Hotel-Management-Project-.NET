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

    [Table("StayDetail")]
    public partial class StayDetail
    {
        
        public string Hotel_Name { get; set; }
        public string Hotel_Address { get; set; }
        public string Hotel_Email { get; set; }
        public string Hotel_Contact { get; set; }
        public string RoomType { get; set; }
        public Nullable<double> Price { get; set; }
        public string CustomerName { get; set; }
        public string Customer_Address { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }

        [Key]
        public int StayDetailsId { get; set; }
    }
}