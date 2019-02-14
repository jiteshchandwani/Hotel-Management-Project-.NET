using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chesterfieldsDAL
{
    public class classDAL
    {
        ChesterfieldsEntities db = new ChesterfieldsEntities();

        public void MakeChanges()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void MakeUpdate(RoomDetail result)
        {
            try
            { 
                db.Entry(result).State = EntityState.Modified;
                db.SaveChanges();
            } 
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        //Methods to View Table Details
        public List<CustomerInfo> SelectCustomerInfo()
        {
            try
            {
                List<CustomerInfo> list = db.CustomerInfoes.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<HotelImage> SelectHotelImage()
        {
            try
            {
                List<HotelImage> list = db.HotelImages.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<HotelInfo> SelectHotelInfo()
        {
            try
            {
                List<HotelInfo> list = db.HotelInfoes.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<PaymentDetail> SelectPaymentDetail()
        {
            try
            {
                List<PaymentDetail> list = db.PaymentDetails.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public List<RoomBooking> SelectRoomBooking()
        {
            try
            {
                List<RoomBooking> list = db.RoomBookings.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<RoomDetail> SelectRoomDetail()
        {
            try
            {
                List<RoomDetail> list = db.RoomDetails.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<RoomImage> SelectRoomImage()
        {
            try
            {
                List<RoomImage> list = db.RoomImages.ToList();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Methods to Insert data into Tables

        public void InsertCustomerInfo(CustomerInfo customerInfo)
        {
            try
            {
                db.CustomerInfoes.Add(customerInfo);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertHotelImage(HotelImage hotelImage)
        {
            try
            {
                db.HotelImages.Add(hotelImage);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertHotelInfo(HotelInfo hotelInfo)
        {
            try
            {
                db.HotelInfoes.Add(hotelInfo);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertPaymentDetail(PaymentDetail paymentDetail)
        {
            try
            {
                db.PaymentDetails.Add(paymentDetail);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertRoomBooking(RoomBooking roomBooking)
        {
            try
            {
                db.RoomBookings.Add(roomBooking);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertRoomDetail(RoomDetail roomDetail)
        {
            try
            {
                db.RoomDetails.Add(roomDetail);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertRoomImage(RoomImage roomImage)
        {
            try
            {
                db.RoomImages.Add(roomImage);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        //Edit/update Methods

        public void EditCustomerInfo(CustomerInfo customerInfo)
        {
            try
            {
                db.Entry(customerInfo).State = EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditHotelImage(HotelImage hotelImage)
        {
            try
            {
                db.Entry(hotelImage).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditHotelInfo(HotelInfo hotelInfo)
        {
            try
            {
                db.Entry(hotelInfo).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditPaymentDetail(PaymentDetail paymentDetail)
        {
            try
            {
                db.Entry(paymentDetail).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditRoomBooking(RoomBooking roomBooking)
        {
            try
            {
                db.Entry(roomBooking).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditRoomDetail(RoomDetail roomDetail)
        {
            try
            {
                db.Entry(roomDetail).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditRoomImage(RoomImage roomImage)
        {
            try
            {
                db.Entry(roomImage).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Methods to delete data from Tables

        public void DeleteCustomerInfo(int customerId)
        {
            try
            {
                CustomerInfo result = db.CustomerInfoes.Find(customerId);
                db.CustomerInfoes.Remove(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteHotelImage(int Hotel_Img_Id)
        {
            try
            {
                HotelImage result = db.HotelImages.Find(Hotel_Img_Id);
                db.HotelImages.Remove(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteHotelInfo(int Hotel_Id)
        {
            try
            {
                HotelInfo result = db.HotelInfoes.Find(Hotel_Id);
                db.HotelInfoes.Remove(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeletePaymentDetail(int Payment_Id)
        {
            try
            {
                PaymentDetail result = db.PaymentDetails.Find(Payment_Id);
                db.PaymentDetails.Remove(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteRoomBooking(int RoomBookingId)
        {
            try
            {
                RoomBooking result = db.RoomBookings.Find(RoomBookingId);
                db.RoomBookings.Remove(result);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteRoomDetail(int RoomTypeId)
        {
            try
            {
                RoomDetail result = db.RoomDetails.Find(RoomTypeId);
                db.RoomDetails.Remove(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteRoomImage(int Room_Img_Id)
        {
            try
            {
                RoomImage result = db.RoomImages.Find(Room_Img_Id);
                db.RoomImages.Remove(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //methods to find a record from the table

        public CustomerInfo GetCustomerInfoById(int CustomerId)
        {
            try
            {
                return db.CustomerInfoes.Find(CustomerId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public HotelImage GetHotelImage(int Hotel_Img_Id)
        {
            try
            {
                return db.HotelImages.Find(Hotel_Img_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public HotelInfo GetHotelInfoById(int Hotel_Id)
        {
            try
            {
                return db.HotelInfoes.Find(Hotel_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public PaymentDetail GetPaymentDetailById(int Payment_Id)
        {
            try
            {
                return db.PaymentDetails.Find(Payment_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public RoomBooking GetRoomBookingById(int RoomBookingId)
        {
            try
            {
                return db.RoomBookings.Find(RoomBookingId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public RoomDetail GetRoomDetailById(int RoomTypeId)
        {
            try
            {
                return db.RoomDetails.Find(RoomTypeId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public RoomImage GetRoomImageById(int Room_Img_Id)
        {
            try
            {
                return db.RoomImages.Find(Room_Img_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string GetRoomType(int roomTypeId)
        {
            try
            {
                List<RoomDetail> roomDetail = SelectRoomDetail();
                string roomType = (from s in roomDetail where s.RoomTypeId == roomTypeId select s.RoomType).First();
                return roomType;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

            //View Hotel Details
            //public List<HotelInfo> selectHotelInfo()
            //{
            //    List<HotelInfo> list = db.HotelInfoes.ToList();
            //    return list;
            //}
            //public List<RoomDetail> selectRoomInfo()
            //{
            //    List<RoomDetail> list = db.RoomDetails.ToList();
            //    return list;
            //}
            //public List<CustomerInfo> selectCustomerInfo()
            //{
            //    List<CustomerInfo> list = db.CustomerInfoes.ToList();
            //    return list;
            //}
            //public List<HotelImage> selectHotelImageInfo()
            //{
            //    List<HotelImage> list = db.HotelImages.ToList();
            //    return list;
            //}


        }
}
