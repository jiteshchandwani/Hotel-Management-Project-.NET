using chesterfieldsDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chesterfields.Controllers
{
    public class AdminController : Controller
    {

        ChesterfieldsEntities db = new ChesterfieldsEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //FOR VIEWING HOTELINFO

        public ActionResult ViewHotelInfo()
        {

            //objBAL.GetHotelInfoById(Hotel_Id)
            return View(db.HotelInfoes.ToList());
        }


        // FOR ADDING A HOTEL
        public ActionResult AddHotel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHotel(HotelInfo hotelInfo)
        {

            //HotelInfo H_info = new HotelInfo();
            //H_info.Hotel_Id = Convert.ToInt32(form["Hotel_ID"]);
            //H_info.Hotel_Name = form["Hotel_Name"];
            //H_info.Hotel_Location = form["Hotel_Location"];
            //H_info.Hotel_Email = form["Hotel_Email"];
            //H_info.Hotel_Contact = form["Hotel_Contact"];
            //H_info.Hotel_Address = form["Hotel_Address"];
            //H_info.About_Hotel = form["About_Hotel"];
            //objBAL.InsertHotelInfo(H_info);
            db.HotelInfoes.Add(hotelInfo);
            db.SaveChanges();
            return RedirectToAction("ViewHotelInfo");
        }

        // FOR EDITING A HOTEL
        public ActionResult EditHotel(int Hotel_Id)
        {
            HotelInfo obj = new HotelInfo();
            obj = db.HotelInfoes.Find(Hotel_Id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult EditHotel(HotelInfo obj)
        {

            //HotelInfo hotelInfo = new HotelInfo();
            //hotelInfo.Hotel_Id = Convert.ToInt32(form["Hotel_ID"]);
            //hotelInfo.About_Hotel = form["About_Hotel"];
            //hotelInfo.Hotel_Name = form["Hotel_Name"];
            //hotelInfo.Hotel_Location = form["Hotel_Location "];
            //hotelInfo.Hotel_Email = form["Hotel_Email"];
            //hotelInfo.Hotel_Contact = form["Hotel_Contact"];
            //hotelInfo.Hotel_Address = form["Hotel_Address"];
            //objBAL.EditHotelInfo(hotelInfo);
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ViewHotelInfo");
        }

        // FOR DELETING A  HOTEL
        public ActionResult DeleteHotel(int Hotel_Id)
        {
            HotelInfo obj = new HotelInfo();
            obj = db.HotelInfoes.Find(Hotel_Id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("DeleteHotel")]
        public ActionResult DeleteHotel1(int Hotel_Id)
        {
            //hotelInfo.Hotel_Name = form["Hotel_Name"];
            //hotelInfo.Hotel_Location = form["Hotel_Location"];
            //hotelInfo.Hotel_Email = form["Hotel_Email"];
            //hotelInfo.Hotel_Contact = form["Hotel_Contact"];
            //hotelInfo.Hotel_Address = form["Hotel_Address"];
            //hotelInfo.About_Hotel = form["About_Hotel"];
            //objBAL.DeleteHotelInfo(Hotel_Id);



            HotelInfo obj = new HotelInfo();
            obj = db.HotelInfoes.Find(Hotel_Id);
            db.HotelInfoes.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("ViewHotelInfo");
        }



        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}

        // REPORTS (no post for this)
        //public ActionResult reports()
        //{
        //    list = new List<CustomerInfo>();
        //    list = SelectCustomerInfo();
        //CustomerInfo userDetails = list.Where(result => result.UserName == username).FirstOrDefault();
        //    return userDetails;

        //}

        //THESE ARE ADMIN CRUD OPERATIONS FOR ROOMS


        public ActionResult ViewRoomInfo()
        {

            //objBAL.GetRoomDetailById(Room_Id)
            return View(db.RoomDetails.ToList());
        }


        // FOR ADDING A HOTEL
        public ActionResult AddRoom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRoom(RoomDetail roomDetail)
        {
            db.RoomDetails.Add(roomDetail);
            db.SaveChanges();
            return RedirectToAction("ViewRoomInfo");
        }

        // FOR EDITING A HOTEL
        public ActionResult EditRoom(int RoomTypeId)
        {
            RoomDetail obj = new RoomDetail();
            obj = db.RoomDetails.Find(RoomTypeId);
            return View(obj);
        }

        [HttpPost]
        public ActionResult EditRoom(RoomDetail obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ViewRoomInfo");
        }

        //// FOR DELETING A  HOTEL
        public ActionResult DeleteRoom(int RoomTypeId)
        {
            RoomDetail obj = new RoomDetail();
            obj = db.RoomDetails.Find(RoomTypeId);
            return View(obj);
        }

        [HttpPost]
        [ActionName("DeleteRoom")]
        public ActionResult DeleteRoom1(int RoomTypeId)
        {
            RoomDetail obj = new RoomDetail();
            obj = db.RoomDetails.Find(RoomTypeId);
            db.RoomDetails.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("ViewRoomInfo");
        }

        public ActionResult ViewBookingInfo()
        {
            return View(db.RoomBookings.ToList());
        }

        public ActionResult DeleteBooking(int RoomBookingId)
        {
            RoomBooking obj = new RoomBooking();
            obj = db.RoomBookings.Find(RoomBookingId);
            return View(obj);
        }


        [HttpPost]
        [ActionName("DeleteBooking")]
        public ActionResult DeleteBooking1(int RoomBookingId)
        {
            RoomBooking obj = new RoomBooking();
            obj = db.RoomBookings.Find(RoomBookingId);
            db.RoomBookings.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("ViewBookingInfo");
        }












        //THERE ARE ADMIN CRUD OPERATIONS FOR REPORTS AND SHIZZ

        public ActionResult customerwise_reports()
        {
            return View();
        }

        public ActionResult hotelwise_reports()
        {
            return View();
        }

        public ActionResult feedbackwise_reports()
        {
            return View();
        }

        public ActionResult Logout()
        {
            try
            {
                Session.Abandon();
                return RedirectToAction("../chesterfields/Index");
            }
            catch (Exception e)
            {
                return View("Error", new HandleErrorInfo(e, "chesterfields", "Logout"));
            }

        }
    }
}