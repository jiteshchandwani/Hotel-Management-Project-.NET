using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using chesterfields.Models;
using chesterfieldsBAL;
using chesterfieldsDAL;

namespace chesterfields.Controllers
{
    [HandleError()]
    public class chesterfieldsController : Controller
    {
        ChesterfieldsEntities db = new ChesterfieldsEntities();

        classBAL objBAL = new classBAL();

        //Error Page

            public ActionResult Error()
        {

            return View();
        }
        // GET: chesterfields

        //This Method return the Index Page
        public ActionResult Index()
        {
            try
            {
              
                ViewBag.roomsnotavaible = TempData["roomsnotavaible"];

                return View();
            }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "Index"));
            }

        }
        //This method gets the Location from the View and checks if any User has 
        // already logged in to the website or not, by checking the boolean 
        //variable checkloginstatus

        [HttpPost]
        public ActionResult Loginfirst(FormCollection form)
        {
            try
            {
                string UserName = form["UserName"];
                string password = form["password"];
                //Now I have to Check in the Database if the Username already exists 
                //For that i will write a method in the DAL class.
                if (UserName == "Admin" && password == "ADmin@12")
                {
                    return RedirectToAction("../Admin/Index");
                }
                else
                {
                    bool does_user_exist = objBAL.DoesUserExist(UserName);
                    if (!does_user_exist)
                    {
                        ViewBag.Errorlogin = "visible";
                        return View("index");
                    }
                    else
                    {
                        CustomerInfo userDetails = objBAL.checklogincredentials(UserName, password);
                        if (userDetails == null)
                        {
                            ViewBag.Errorlogin = "visible";
                            return View("index");
                        }
                        else
                        {
                            //session ids can also be added to track or save the information of the user and to sho it call that in the view that is being passed.
                            Session["UserName"] = userDetails.UserName;
                            Session["CustomerName"] = userDetails.CustomerName;
                            Session["CustomerId"] = userDetails.CustomerId;
                            //Sets the LoginStatus to true if the login credentials are verified.
                            classBAL.loginstatus = true;
                            ViewBag.Tq = "visible";
                            ViewBag.url1 = "~/Index";
                            return View("index");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "Loginfirst"));
            }

        }

        //This is the Method which returns the PopUp which contains Login part,
        //New User part and the Forgot Password Part 


        //[HttpPost]
        //public ActionResult ModalPopUp(FormCollection form)
        //{
        //    string username = form["username"];
        //    string password = form["password"];
        //    //Now I have to Check in the Database if the Username already exists 
        //    //For that i will write a method in the DAL class.
        //    bool does_user_exist = objBAL.DoesUserExist(username);
        //    if (!does_user_exist)
        //    {
        //        //Return the Same View along with an Error Message
        //        return View("ModalPopUp", objBAL.ErrorMessage = "Username does not Exist");
        //    }
        //    else
        //    {

        //        CustomerInfo userDetails = objBAL.checklogincredentials(username, password);
        //        if (userDetails == null)
        //        {

        //            return View("ModalPopUp", objBAL.ErrorMessage = "Wrong credentials !!");
        //        }
        //        else
        //        {
        //            //session ids can also be added to track or save the information of the user and to sho it call that in the view that is being passed.
        //            Session["User"] = userDetails.UserName;
        //            //Sets the LoginStatus to true if the login credentials are verified.
        //            classBAL.loginstatus = true;
        //            return RedirectToAction("index");
        //        }
        //    }
        //}
        public ActionResult Logout()
        {
            try
            { 
            Session.Abandon();
            return RedirectToAction("index");
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "Logout"));
            }

        }

        public ActionResult displayHotelDetails(FormCollection locfrm)
        {
            try { 
            string loc = locfrm["location"];
            int Hotel_Id;
            if(string.IsNullOrEmpty(loc))
            {
                ModelState.AddModelError("Ename", "please enter your name");
            }
            HotelDetails objHD = new HotelDetails();
            List<HotelInfo> hotelInfoList = objBAL.SelectHotelInfo();
            List<HotelImage> hotelImageList = objBAL.SelectHotelImage();

            objHD.hotelInfo = (from r in hotelInfoList where r.Hotel_Location == loc select r).FirstOrDefault();

            Hotel_Id = objHD.hotelInfo.Hotel_Id;

            objHD.hotelimageinfo = (from r in hotelImageList where r.Hotel_Id == Hotel_Id select r).FirstOrDefault();
            return View(objHD);
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "displayHotelDetails"));
            }

        }
        public ActionResult displayRoomDetails(FormCollection roomfrm)
        {
            try
            { 
            /*
            
                        
           
            int roomtypeid=objRD.roomdetailinfo.
            objRD.roomimageinfo = (from r in roomimagelist where r.RoomTypeId == roomtypeid select r).FirstOrDefault();
            */
            //int Hotel_Id=form["Hotel_Id"];
            string HotelIdstr = roomfrm["hotelid"];
            int Hotel_Id = Convert.ToInt32(HotelIdstr);
            RoomDetails objRD = new RoomDetails();
            List<RoomDetail> roomDetailList = objBAL.SelectRoomDetail();
            List<RoomImage> roomimagelist = objBAL.SelectRoomImage();

            objRD.roomdetailinfo = (from r in roomDetailList where r.Hotel_Id == Hotel_Id select r).ToList();

            //List<int> roomTypeId = new List<int>();
            //roomTypeId = (from r in roomDetailList where r.Hotel_Id == Hotel_Id select r.RoomTypeId).ToList();


            //foreach(var item in roomTypeId)
            //{
            //    objRD.roomimageinfo =(from r in roomimagelist where r.RoomTypeId ==item select r).ToList();
            //}

            return View(objRD);
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "displayRoomDetails"));
            }

        }


        //This returns the View for The New User Registration Page.
        //Called from ModalPopUp
        //This is a PopUp in itself.
        //public ActionResult registercustomer()
        //{
        //    return View();
        //}

        //Customer Details from the Registration page are taken in the 
        //CustomerInfo Model Type Object. These values are inserted into the table. 

        [HttpPost]
        public ActionResult registercustomer(FormCollection frm)
        {
            try
            { 
            CustomerInfo obj = new CustomerInfo();
            obj.CustomerName = frm["CustomerName"];
            obj.Date_of_Birth = Convert.ToDateTime(frm["Date_of_Birth"]);
            obj.Gender = frm["Gender"];
            obj.Customer_Address = frm["Customer_Address"];
            obj.City = frm["City"];
            obj.Pin_Code = frm["Pin_Code"];
            obj.Country = frm["Country"];
            obj.Phone_Number = frm["Phone_Number"];
            obj.Email = frm["Email"];
            obj.UserName = frm["UserName"];
            obj.Passwordd = frm["Passwordd"];
            objBAL.InsertCustomerInfo(obj);
            //Redirecting to Login PopUp with a Thanks for Registering Message in between
            ViewBag.Tq2 = "visible";
            ViewBag.url1 = "~/Index";
            return View("index");
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "registercustomer"));
            }

        }

        //public ActionResult GetLocation(FormCollection locfrm)
        //{

        //    objho.Hotel_Location = locfrm["location"];
        //    return RedirectToAction("displayHotelDetails");
        //}
        //This is the View for the Forgot Password PopUp
        //public ActionResult forgotPassword()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult forgotPassword(FormCollection form)
        {
            try
            { 
            string emailId = form["emailId"];
            string UserName = form["UserName"];
            //Function for Mailing the New Password on the EmailId provided by the user.
            bool isemailverified = objBAL.verifyemail(UserName, emailId);

            if (isemailverified)
            {
                string newPassword = objBAL.getNewPassword(emailId);
                //This function adds the newly generated password to the Database
                objBAL.AddToRegister(objBAL.getPhoneNumber(emailId), newPassword);
                //This function sends the newly generated password to the Customer Email Address
                semail(emailId, newPassword);


                    //Redirects to Login PopUp after Displaying message that a new password is sent to the customer's mail
                    ViewBag.checkmail = "visible";
                    return View("index");
            }
            else
            {
                    ViewBag.errforgot = "visible";
                    return View("index");
                }
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "forgotPassword"));
            }

        }

        public ActionResult semail(string emailId, string newPassword)
        {
            try
            { 
            bool result = objBAL.SendMail(emailId, "NewPassWord", newPassword);
            if (result == true)
            {
                    return View("index");
                    //Response.Write("Mail Sent");
                    // RedirectToAction("OTP_Generation");
                }
            else
                Response.Write("Mail not Sent");
            return Json(result, JsonRequestBehavior.AllowGet);
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "semail"));
            }

        }





        

        public ActionResult RoomAvailabilityView(FormCollection Hotel_Room_Id)
        {
            try
            { 
            string HotelIdstr = Hotel_Room_Id["HotelId"];
            string RoomIDstr = Hotel_Room_Id["Roomid"];
            ViewBag.hid = HotelIdstr;
            ViewBag.rid = RoomIDstr;
            return View();
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "RoomAvailabilityView"));
            }

        }

        [HttpPost]
        public ActionResult displaystayDetails(FormCollection Avaifrm)
        {
            try
            { 
            int customerid = Convert.ToInt32(Avaifrm["customerid"]);
            DateTime checkinDate = Convert.ToDateTime(Avaifrm["checkindate"]);
            DateTime checkoutDate = Convert.ToDateTime(Avaifrm["checkoutdate"]);
            int hotelid = Convert.ToInt32(Avaifrm["hotelid"]);
            int roomid = Convert.ToInt32(Avaifrm["roomid"]);
            ViewBag.hid = hotelid;
            ViewBag.rid = roomid;
            double noofdays = (checkoutDate - checkinDate).TotalDays;
            int number_of_rooms = Convert.ToInt32(Avaifrm["Number_of_rooms"]);
            int number_of_Guests = Convert.ToInt32(Avaifrm["Number_of_Guests"]);

            bool a= objBAL.checkroomAvailability(checkinDate, checkoutDate, number_of_rooms, number_of_Guests,roomid);

            if (a == false)
            {
                    TempData["roomsnotavaible"] = "visible";
                    return RedirectToAction("index");

                    //error popup that rooms are not available 
                }
            else
            {
                StayDetails obj1 = new StayDetails();
               
               
                
               
                obj1.checkin = checkinDate;
                obj1.checkout = checkoutDate;
                obj1.noofrooms = number_of_rooms;
                obj1.noofguests = number_of_Guests;
                obj1.hotellist = (from r in objBAL.SelectHotelInfo() where r.Hotel_Id == hotelid select r).FirstOrDefault();
                obj1.roomdetaillist = (from r in objBAL.SelectRoomDetail() where r.RoomTypeId == roomid && r.Hotel_Id == hotelid select r).FirstOrDefault();
                obj1.customerinfolist = (from r in objBAL.SelectCustomerInfo() where r.CustomerId == customerid select r).FirstOrDefault();
                double Amount = Convert.ToDouble(noofdays * number_of_rooms * obj1.roomdetaillist.Price);
                ViewBag.Amt = Amount;
                return View(obj1);
            }
            
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "displaystayDetails"));
            }

        }
        
        public ActionResult makePayment(FormCollection payfrm)
        {
            try
            { 
            ViewBag.customerid = payfrm["customerid"];
            ViewBag.hid = Convert.ToInt32(payfrm["hotelid"]);
            ViewBag.rid = Convert.ToInt32(payfrm["roomId"]);
            ViewBag.checkin = payfrm["checkin"];
            ViewBag.checkout = payfrm["checkout"];
            ViewBag.noofrooms = Convert.ToInt32(payfrm["noofrooms"]);
            ViewBag.noofguests = Convert.ToInt32( payfrm["noofguests"]);
            ViewBag.Amt = Convert.ToDouble(payfrm["Amount"]);

            return View();
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "makePayment"));
            }

        }
        [HttpPost]
        public ActionResult TqforBookingFromCard(FormCollection payfrm)
        {
            try { 
            string Customer_Card_Number = payfrm["Customer_Card_Number"];
            string mm = payfrm["mm"];
            string yy = payfrm["yy"];
            string NameonCard = payfrm["NameonCard"];
            string Customer_Cvv = payfrm["Customer_Cvv"];
            string ExpiryDate = mm +"/"+ yy;
            bool isExpiryDateValid = objBAL.isExpiryValid(ExpiryDate);
            string Normalized_Customer_Card_Number = objBAL.NormalizeCardNumber(Customer_Card_Number);
            bool isCardValid = objBAL.isCardValid(Normalized_Customer_Card_Number);

            if (isCardValid && isExpiryDateValid)
            {
                RoomBooking roomBooking = new RoomBooking();
               

                
                roomBooking.CustomerId = Convert.ToInt32(payfrm["customerid"]);
                roomBooking.Hotel_Id = Convert.ToInt32(payfrm["hotelid"]);
                roomBooking.RoomTypeId = Convert.ToInt32(payfrm["roomId"]);
                roomBooking.CheckIn = Convert.ToDateTime(payfrm["checkin"]);
                roomBooking.CheckOut = Convert.ToDateTime(payfrm["checkout"]);
                roomBooking.No_of_Rooms = Convert.ToInt32(payfrm["noofrooms"]);
                roomBooking.No_of_Guests = Convert.ToInt32(payfrm["noofguests"]);
                roomBooking.RoomType = objBAL.GetRoomType(Convert.ToInt32(roomBooking.RoomTypeId));
                objBAL.StoreBookingDetails(roomBooking);

                TempData["tq"] = "visible";
                return RedirectToAction("MyReservation");
            }
            else
            {
                Response.Write("Enter Correct Card Number and Valid Expiry Date");
                return RedirectToAction("makePayment");
            }
        }
        catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "TqforBookingFromCard"));
            }

}

public ActionResult TqforBookingPayAtHotel(FormCollection payfrm)
        {
          try
            { 
                RoomBooking roomBooking = new RoomBooking();

                roomBooking.CustomerId = Convert.ToInt32(payfrm["customerid"]);
                roomBooking.Hotel_Id = Convert.ToInt32(payfrm["hotelid"]);
                roomBooking.RoomTypeId = Convert.ToInt32(payfrm["roomId"]);
                roomBooking.CheckIn = Convert.ToDateTime(payfrm["checkin"]);
                roomBooking.CheckOut = Convert.ToDateTime(payfrm["checkout"]);
                roomBooking.No_of_Rooms = Convert.ToInt32(payfrm["noofrooms"]);
                roomBooking.No_of_Guests = Convert.ToInt32(payfrm["noofguests"]);
                roomBooking.RoomType = objBAL.GetRoomType(Convert.ToInt32(roomBooking.RoomTypeId));
                objBAL.StoreBookingDetails(roomBooking);

                TempData["tq"] = "visible";
                return RedirectToAction("MyReservation");
           
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "TqforBookingPayAtHotel"));
            }

        }

        public ActionResult MyReservation()
        {
            try
            {

                ReservationSummary obj = new ReservationSummary();


            List<RoomBooking> RoomBookingList = objBAL.SelectRoomBooking();
                List<HotelInfo> HotelInfoList = objBAL.SelectHotelInfo();
                List<RoomDetail> RoomDetailList = objBAL.SelectRoomDetail();
                int customer_id = Convert.ToInt32(Session["CustomerId"]);
        
                obj.roombookinglist = (from r in RoomBookingList where customer_id == r.CustomerId select r).FirstOrDefault();
                if (obj.roombookinglist == null) {
                    ViewBag.nul= "visible";
                    return View("index");
                        }
                else
                {
                    obj.hotellist = (from r in HotelInfoList where obj.roombookinglist.Hotel_Id == r.Hotel_Id select r).FirstOrDefault();
                    obj.roomlist = (from r in RoomDetailList where obj.roombookinglist.RoomTypeId == r.RoomTypeId && obj.roombookinglist.Hotel_Id == r.Hotel_Id select r).FirstOrDefault();

                    ViewBag.tqforbooking = TempData["tq"];

                    return View(obj);

                }
        }
                catch (Exception e)
                {
                    return View("Error", new HandleErrorInfo(e, "chesterfields", "MyReservation"));
                }

}


        public ActionResult CancelBooking(FormCollection frm)
        {
            try
            {
                int roombookingid =Convert.ToInt32( frm["roombookingid"]);
            int customer_id = Convert.ToInt32(Session["CustomerId"]);
            objBAL.CancelBooking(customer_id, roombookingid);
            return View("index");
        }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "CancelBooking"));
            }

        }

        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult faqs()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult Jaipur()
        {
            return View();
        }

        public ActionResult Package2()
        {
            return View();
        }
        public ActionResult Package3()
        {
            return View();
        }
        public ActionResult Package4()
        {
            return View();
        }
        public ActionResult Package5()
        {
            return View();
        }

        public ActionResult Package6()
        {
            return View();
        }


        public ActionResult Package7()
        {
            return View();
        }

        public ActionResult Package8()
        {
            return View();
        }




        //public ActionResult MyReservation()
        //{
        //    try
        //    { 
        //    ReservationSummary obj = new ReservationSummary();
        //    List<RoomBooking> RoomBookingList = objBAL.SelectRoomBooking();
        //    List<HotelInfo> HotelInfoList = objBAL.SelectHotelInfo();
        //    List<RoomDetail> RoomDetailList = objBAL.SelectRoomDetail();
        //    int customer_id = Convert.ToInt32(Session["CustomerId"]);
        //    obj.roombookinglist= (from r in RoomBookingList where customer_id == r.CustomerId select r).FirstOrDefault();
        //    obj.hotellist= (from r in HotelInfoList where obj.roombookinglist.Hotel_Id == r.Hotel_Id select r).FirstOrDefault();
        //    obj.roomlist = (from r in RoomDetailList where obj.roombookinglist.RoomTypeId == r.RoomTypeId && obj.roombookinglist.Hotel_Id == r.Hotel_Id select r).FirstOrDefault();
        //    return View(obj);
        //}
        //    catch (Exception e)
        //    {
        //        return View("Error", new HandleErrorInfo(e, "chesterfields", "ReservationDetails"));
        //    }

        //}
    }
    
}