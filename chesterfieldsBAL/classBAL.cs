using chesterfieldsDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace chesterfieldsBAL
{
    public class classBAL
    {
        classDAL objDAL = new classDAL();
        List<CustomerInfo> list;
        public static Boolean loginstatus = false;
        classDAL obj = new classDAL();
        ChesterfieldsEntities db = new ChesterfieldsEntities();

        //Methods for Selecting Data from DAL

        public List<CustomerInfo> SelectCustomerInfo()
        {
            try
            {
                List<CustomerInfo> list = objDAL.SelectCustomerInfo();
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
                List<HotelImage> list = objDAL.SelectHotelImage();
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
                List<HotelInfo> list = objDAL.SelectHotelInfo();
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
                List<PaymentDetail> list = objDAL.SelectPaymentDetail();
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
                List<RoomBooking> list = objDAL.SelectRoomBooking();
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
                List<RoomDetail> list = objDAL.SelectRoomDetail();
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
                List<RoomImage> list = objDAL.SelectRoomImage();
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Methods to call Insert functions from DAL 

        public void InsertCustomerInfo(CustomerInfo customerInfo)
        {
            try
            {
                customerInfo.Passwordd = Encrypt(customerInfo.Passwordd);
                objDAL.InsertCustomerInfo(customerInfo);
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
                objDAL.InsertHotelImage(hotelImage);
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
                objDAL.InsertHotelInfo(hotelInfo);
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
                objDAL.InsertPaymentDetail(paymentDetail);
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
                objDAL.InsertRoomBooking(roomBooking);
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
                objDAL.InsertRoomDetail(roomDetail);
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
                objDAL.InsertRoomImage(roomImage);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Methods for Calling DAL Edit Functions

        public void EditCustomerInfo(CustomerInfo customerInfo)
        {
            try
            {
                objDAL.EditCustomerInfo(customerInfo);

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
                objDAL.EditHotelImage(hotelImage);

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
                objDAL.EditHotelInfo(hotelInfo);

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
                objDAL.EditPaymentDetail(paymentDetail);
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
                objDAL.EditRoomBooking(roomBooking);
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
                objDAL.EditRoomDetail(roomDetail);
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
                objDAL.EditRoomImage(roomImage);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        //Methods for Calling DAL delete Functions

        public void DeleteCustomerInfo(int customerId)
        {
            try
            {
                objDAL.DeleteCustomerInfo(customerId);
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
                objDAL.DeleteHotelImage(Hotel_Img_Id);
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
                objDAL.DeleteHotelInfo(Hotel_Id);
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
                objDAL.DeletePaymentDetail(Payment_Id);
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
                objDAL.DeleteRoomBooking(RoomBookingId);
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
                objDAL.DeleteRoomDetail(RoomTypeId);
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
                objDAL.DeleteHotelImage(Room_Img_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //method to call find functions in DAL

        public CustomerInfo GetCustomerInfoById(int CustomerId)
        {
            try
            {
                return objDAL.GetCustomerInfoById(CustomerId);
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
                return objDAL.GetHotelImage(Hotel_Img_Id);
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
                return objDAL.GetHotelInfoById(Hotel_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
            public PaymentDetail GetPaymentDetailByID(int Payment_Id)
        {
            try
            { 
            return objDAL.GetPaymentDetailById(Payment_Id);
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
            return objDAL.GetRoomBookingById(RoomBookingId);
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public RoomDetail GetRoomDetailsbyId(int RoomTypeId)
        {
            try { 
            return objDAL.GetRoomDetailById(RoomTypeId);
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
            return objDAL.GetRoomImageById(Room_Img_Id);
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Method to check if Username exists in the database


        public bool DoesUserExist(string username)
        {
            list = new List<CustomerInfo>();
            list = SelectCustomerInfo();
            try
            { 
            var result = (from s in list where s.UserName == username select s);
            if (result.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Error Message Property to be displayed
        public string ErrorMessage { get; set; }

        public CustomerInfo checklogincredentials(string username,string password)
        {
            try
            { 
            list = new List<CustomerInfo>();
            list = SelectCustomerInfo();
            password=Encrypt(password);
            CustomerInfo userDetails = list.Where(result => result.UserName == username && result.Passwordd == password).FirstOrDefault();
            return userDetails;
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool verifyemail(string UserName, string emailId)
        {
            list= SelectCustomerInfo();
            try
            { 
            CustomerInfo result = (from s in list where s.Email == emailId select s).FirstOrDefault();
            if(result.Email==emailId && result.UserName == UserName)
            {
                
                    return true;
            }
            else
            {
                return false;
            }
             
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string getNewPassword(string emailId)
        {
            list = SelectCustomerInfo();
            try
            { 
            var result = (from s in list where s.Email == emailId select s).First();
            string name = result.CustomerName;
            string phno = result.Phone_Number;

            //COPIED CODE

            string str1 = (name[1].ToString() + name[0].ToString());

            string ph = phno.ToString().Substring(0, 3);

            DateTime dt = DateTime.Now;

            int sec = dt.Second;

            int min = dt.Minute;

            int date = dt.Day;

            string getNewPassword= (ph[0].ToString() + str1[1].ToString() + ph[1].ToString()
                + min.ToString() + date.ToString() + sec.ToString() + str1[0].ToString() 
                + ph[2].ToString()).ToString();

             return getNewPassword;
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void MakeChanges()
        {
            try
            { 
            objDAL.MakeChanges();
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public string getPhoneNumber(string emailId)
        {
            list = SelectCustomerInfo();
            try
            { 
            string phone_number= (from s in list where s.Email == emailId select s.Phone_Number).First();
            return phone_number;
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //method which makes changes to the register
        public void AddToRegister(string phoneNumber, string newPassword)
        {
            try
            { 
            list = SelectCustomerInfo();
            newPassword = Encrypt(newPassword);
            (from p in list
             where p.Phone_Number == phoneNumber
             select p).ToList()
            .ForEach(x => x.Passwordd= newPassword);
             MakeChanges();
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool SendMail(string Email, string sub, string Body)
        {
            try
            {
                string senderEmail = System.Configuration.ConfigurationManager.AppSettings["senderEmail"].ToString();
                string senderPassWord = System.Configuration.ConfigurationManager.AppSettings["senderPassWord"].ToString();

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential(senderEmail, senderPassWord);

                MailMessage mailmessage = new MailMessage(senderEmail, Email, sub, Body);
                //mailmessage.IsBodyHtml = true;
                mailmessage.BodyEncoding = UTF8Encoding.UTF8;
                client.Send(mailmessage);

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }





        //public void semail(string emailId,string newPassword)
        //{
        //    bool result = SendMail(emailId, "NewPassWord", newPassword);
        //    if (result == true)
        //    {
        //        Response.Write("Mail Sent");
        //        // RedirectToAction("OTP_Generation");
        //    }
        //    else
        //        Response.Write("Mail not Sent");
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}   
        //DAL Logic Methods

        //        public void RegisterValid(CustomerInfo c_info)
        //            {
        //            try
        //            {
        //                if (ModelState.IsValid)
        //                {
        //                    string CustomerName = c_info.CustomerName.ToString();
        //                    if (IsExist(CustomerName) == true)
        //                    {
        //                        db.CustomerInfoes.Add(c_info);
        //                        db.SaveChanges();
        //                        return RedirectToAction("afterRegisterLogin");

        //}
        //            }
        //            catch
        //            {

        //            }
        //            return View();

        //                    }

        public Boolean checkloginstatus()
        {
            try
            { 
            if (!loginstatus)
            {
                return loginstatus;
            }
            else {

                return loginstatus;
            }

        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public RoomBooking abc()
        //{
        //   // var result = from r in RoomDetail
        //     //            where 
        //}

        //Methods to Display Hotel Details


        //public List<RoomDetail> displayRoomType(int hotelid)
        //{
        //    List<RoomDetail> list = obj.SelectRoomDetail();
        //    var result = (from r in list where r.Hotel_Id == hotelid select r).ToList();
        //    return result;
        //}
        //public List<HotelInfo> getHotelInfo()
        //{
        //    List<HotelInfo> list = obj.selectHotelInfo();
        //    return list;
        //}
        //public List<RoomDetail> getRoomDetailInfo()
        //{
        //    List<RoomDetail> list = obj.selectRoomInfo();
        //    return list;
        //}
        //public List<CustomerInfo> customerinfo()
        //{
        //    List<CustomerInfo> list = obj.selectCustomerInfo();
        //    return list;
        //}
        //public List<HotelImage> getHotelImageInfo()
        //{
        //    List<HotelImage> list = obj.selectHotelImageInfo();
        //    return list;
        //}
        public Boolean checkroomAvailability(DateTime checkinDate, DateTime checkoutDate,int number_of_rooms,int number_of_Guests, int roomid)
        {
         try
            { 
            //List<RoomBooking> RoomBookingList = new List<RoomBooking>();
            //List<RoomDetail> RoomDetailList = new List<RoomDetail>();

            List<RoomBooking> RoomBookingList = SelectRoomBooking();
            List<RoomDetail> RoomDetailList = SelectRoomDetail();
            //var roomdetailresult = RoomDetailList.Where(result => result.Available_Rooms >= number_of_rooms && result.RoomTypeId == RoomtypeId);
            var RoomDetailResult = (from r in RoomDetailList where number_of_rooms <= r.Available_Rooms && roomid== r.RoomTypeId select r);
            if (RoomDetailResult.Count() == 0)
            {

                return false;
                
            } else

            {

                return true;
            }
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        //Payment functions 
        public string NormalizeCardNumber(string Customer_Card_Number)
        {
            try
            { 
            if (Customer_Card_Number == null)
                Customer_Card_Number = String.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (char c in Customer_Card_Number)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool isCardValid(string Customer_Card_Number)
        {

            int i, checkSum = 0;

            try
            { 
            // Compute checksum of every other digit starting from right-most digit
            for (i = Customer_Card_Number.Length - 1; i >= 0; i -= 2)
                checkSum += (Customer_Card_Number[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = Customer_Card_Number.Length - 2; i >= 0; i -= 2)
            {
                int val = ((Customer_Card_Number[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);


        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool isExpiryValid(string ExpiryDate)
        {
            try
            { 
            DateTime now = DateTime.Now;
            DateTime expiryDate = Convert.ToDateTime(ExpiryDate);
            if (expiryDate.Month < 0 && expiryDate.Month > 12 && now.Month > expiryDate.Month && now.Year > expiryDate.Year)
            {
                return false;
            }
            else
            {
                return true;
            }
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
            return objDAL.GetRoomType(roomTypeId);
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void StoreBookingDetails(RoomBooking roomBooking)
        {
            try
            { 
            InsertRoomBooking(roomBooking);
                int noOfRooms = Convert.ToInt32(roomBooking.No_of_Rooms);
                List<RoomDetail> roomDetailList = SelectRoomDetail();
                (from p in roomDetailList
                 where p.RoomTypeId == roomBooking.RoomTypeId
                 select p).ToList()
            .ForEach(x => x.Available_Rooms -= noOfRooms);
                MakeChanges();

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
            objDAL.MakeUpdate(result);
        }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public void CancelBooking(int CustomerId,int roomBookingId)
        {
            try
            { 
            List<RoomBooking> RoomBookingList = SelectRoomBooking();
            List<RoomDetail> RoomDetailList = SelectRoomDetail();
            //int HotelId = Convert.ToInt32((from r in RoomBookingList where CustomerId == r.CustomerId select r.Hotel_Id));
            //int RoomTypeId = Convert.ToInt32((from r in RoomBookingList where CustomerId == r.CustomerId select r.RoomTypeId));
            //int NoOfRooms = Convert.ToInt32((from r in RoomBookingList where CustomerId == r.CustomerId select r.No_of_Rooms));
            //var resulttoreturn = (from r in RoomBookingList where CustomerId == r.CustomerId select r);
            //var result = (from r in RoomDetailList where RoomTypeId == r.RoomTypeId && HotelId == r.Hotel_Id select r).FirstOrDefault();
            //result.Available_Rooms += NoOfRooms;
            //MakeUpdate(result.Available_Rooms);
            RoomBooking roombooking = (from r in RoomBookingList where r.CustomerId==CustomerId && r.RoomBookingId== roomBookingId select r).FirstOrDefault();
                //int noofrooms = Convert.ToInt32(roombooking.No_of_Rooms);
                //int hotelid = Convert.ToInt32(roombooking.Hotel_Id);
                //int roomtypeid = Convert.ToInt32(roombooking.RoomTypeId);

                //This function call deletes that reservation
               

            RoomDetail result =(from r in RoomDetailList where r.Hotel_Id == roombooking.Hotel_Id && r.RoomTypeId == roombooking.RoomTypeId select r).FirstOrDefault();
            //availableRooms += noofrooms;
            
            result.Available_Rooms = roombooking.No_of_Rooms + result.Available_Rooms;

            MakeUpdate(result);
                DeleteRoomBooking(roomBookingId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string Encrypt(string str)
        {
            string EncrptKey = "2013;[pnuLIT)WebCodeExpert";
            byte[] byKey = { };
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
            byKey = Encoding.UTF8.GetBytes(EncrptKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(str);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }

        public string Decrypt(string str)
        {
            str = str.Replace(" ", "+");
            string DecryptKey = "2013;[pnuLIT)WebCodeExpert";
            byte[] byKey = { };
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
            byte[] inputByteArray = new byte[str.Length];

            byKey = Encoding.UTF8.GetBytes(DecryptKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(str.Replace(" ", "+"));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            Encoding encoding = Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

    }
}
