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

    [Table("RoomImage")]
    public partial class RoomImage
    {
        [Key]
        public int Room_Img_Id { get; set; }
        public Nullable<int> RoomTypeId { get; set; }
        public string Img_Path1 { get; set; }
    
        public virtual RoomDetail RoomDetail { get; set; }
    }
}
