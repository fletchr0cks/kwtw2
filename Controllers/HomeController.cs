using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kwtwsite.Models;
using System.Web.Mvc.Ajax;


namespace kwtwsite.Controllers
{
    public class HomeController : Controller
    {
        DataRepo datarepo = new DataRepo();
        private DataClasses1DataContext db = new DataClasses1DataContext();

      
        public ActionResult Thanks()
        {
            return View();
        }

        public ActionResult Here()
        {
            return View("Index");
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Social()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Beta()
        {
            ViewBag.Message = "Your application description page.";
            var DataContext = new DataClasses1DataContext();
            var data = from u in DataContext.Users
                       select u;

            return View("Beta", data);
        }

        public ActionResult Dash()
        {
            var DataContext = new DataClasses1DataContext();
            var data1 = from u in DataContext.Users
                        where u.PaymentID != null
                       select u;

            var data2 = from u in DataContext.Users
                        where u.PaymentID == null
                        select u;

            var data3 = from u in DataContext.Users
                        select u;

            var paid = data1.Count();
            var trial = data2.Count();
            var total = data3.Count();
            ViewData["paid"] = paid;
            ViewData["trial"] = trial;
            ViewData["total"] = total;
            ViewData["time"] = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            return View();
        }


        public JsonResult TopW()
        {
            var DataContext = new DataClasses1DataContext();
            var allw = from e in DataContext.TopWeathers
                       where e.Timestamp >= DateTime.Now.AddDays(-7) 
                       orderby e.Stars descending, e.Timestamp descending
                       select new
                       {
                           UserID = (from u in DataContext.Users where e.UserID == u.StravaID select u.Firstname.Substring(0, 1).ToLower()),
                           Wspd = e.Windspeed,
                           Name = e.SegName,
                           Points = e.Polyline,
                           SegID = e.SegID,
                           Stars = e.Stars,
                           TS_pretty = e.TS_pretty,
                           Location = e.latlng,
                           Timest = Convert.ToDateTime(e.Timestamp).ToLongDateString()//.ToShortTimeString()

                       };



            return Json(new { topw = allw.Take(10) }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Ustatus(int StravaID)
        {
            var DataContext = new DataClasses1DataContext();
            var pr = from e in DataContext.Users
                     where e.StravaID == StravaID
                     select new
                     {
                         FirstLogin = Convert.ToDateTime(e.FirstLogin).Day + "/" + Convert.ToDateTime(e.FirstLogin).Month + "/" + Convert.ToDateTime(e.FirstLogin).Year,
                         Credits = e.Credits

                     };

            return Json(new { ustatus = pr }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult AllSegs()
        {
            var DataContext = new DataClasses1DataContext();
            var allw = from e in DataContext.Segments
                       orderby e.SegmentName descending
                       select new
                       {
                           SegID = e.SegmentID,
                         //  Wspd = e.Windspeed,
                           Name = e.SegmentName

                       };

            return Json(new { allsegs = allw }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult AllUsers()
        {
            var DataContext = new DataClasses1DataContext();
            var allw = from e in DataContext.Users
                       orderby e.FirstLogin descending
                       select new
                       {
                           Name = e.Firstname + " " + e.Lastname,
                           //  Wspd = e.Windspeed,
                           Act = e.Activities,
                           Seg = e.Segments

                       };

            return Json(new { allusers = allw }, JsonRequestBehavior.AllowGet);

        }


        public JsonResult GetFavs(int ID)
        {
            var DataContext = new DataClasses1DataContext();
            var favs = from e in DataContext.Views
                       where e.UserID == ID
                       orderby e.Timestamp descending
                       select new
                       {
                           name = (from u in DataContext.Segments where e.SegID == u.SegmentID select u.SegmentName),
                           ID = e.SegID,
                           dist = "400m"
                       };

            return Json(new { segs = favs }, JsonRequestBehavior.AllowGet);

        }
        public void SavePmt(int StravaID, string payID)
        {

            var DataContext = new DataClasses1DataContext();

            //update
                var sc = db.Users
                .Where(s => s.StravaID == StravaID)
                .First();

                sc.PaymentID = payID;

            sc.PaymentDate = Convert.ToDateTime(DateTime.Now);
                db.SubmitChanges();


          
        }




        public void SaveUser(string firstname, string lastname, int StravaID, int NumAct, int NumSeg)
        {

            var DataContext = new DataClasses1DataContext();


            var userct = from u in DataContext.Users
                         where u.StravaID == StravaID
                         select u;

            if (userct.Count() > 0) {
                //update
                var sc = db.Users
                .Where(s => s.StravaID == StravaID)
                .First();

                sc.Activities = NumAct;
                sc.Segments = NumSeg;
                sc.LastRefresh = Convert.ToDateTime(DateTime.Now).ToShortDateString();
                db.SubmitChanges();


            }
            else
            {
                //save new
                User unew = new Models.User();
                unew.Firstname = firstname;
                unew.Lastname = lastname;
                unew.StravaID = StravaID;
                unew.Activities = NumAct;
                unew.Segments = NumSeg;
                unew.Credits = 15;
                unew.FirstLogin = DateTime.Now;
                datarepo.Add(unew);
                datarepo.Save();


            }
            

        }

        public void SaveCredit(int StravaID, int cred)
        {
          
            var DataContext = new DataClasses1DataContext();

            var user = from u in DataContext.Users
                         where u.StravaID == StravaID
                         select u;
            var credit = user.First().Credits;
            //Convert.ToInt32(credit.First());
            var newcredit = credit - cred;

            //update
            var sc = db.Users
                .Where(s => s.StravaID == StravaID)
                .First();

                sc.Credits = newcredit;
               
                db.SubmitChanges();


        }

        public void SaveTopWeather(int UserID, int segID, string segName, string poly, int wspd, string loc, int stars, string epoch, string timestamp)
        {

            var DataContext = new DataClasses1DataContext();

            var allw = from e in DataContext.TopWeathers
                       where e.SegID == segID
                       where e.Timestamp >= DateTime.Now.AddHours(-1)
                       select e;
            if (allw.Count() > 0)
            {

            }
            else {

                TopWeather wnew = new Models.TopWeather();
                wnew.UserID = UserID;
                wnew.SegID = segID;
                wnew.Stars = stars;
                wnew.latlng = loc;
                wnew.SegName = segName;
                wnew.Polyline = poly;
                wnew.Windspeed = wspd;
                wnew.epoch = epoch;
                wnew.Timestamp = DateTime.Now;
                wnew.TS_pretty = timestamp;
                datarepo.Add(wnew);
                datarepo.Save();

            }

        }

        public void SaveFav(int UserID, int segID)
        {

            var DataContext = new DataClasses1DataContext();


            var segct = from u in DataContext.Views
                        where u.UserID == UserID
                        where u.SegID == segID
                        select u;

            if (segct.Count() > 0)
            {
                var sc = db.Views
                 .Where(s => s.SegID == segID)
                 .First();

                datarepo.Delete(sc);
               

            }
            else
            {
                //save new
                View vnew = new Models.View();
                vnew.SegID = segID;
                vnew.UserID = UserID;
               // vnew.Timestamp = DateTime.Now
                datarepo.Add(vnew);
                datarepo.Save();


            }



        

    }

    public void SaveSegment(string segname, int segID, string array, string polyline, string latlng, int priv, string location)
        {

            var DataContext = new DataClasses1DataContext();


            var segct = from u in DataContext.Segments
                         where u.SegmentID == segID
                         select u;

            if (segct.Count() > 0 && priv != 1)
            {
                var sc = db.Segments
                 .Where(s => s.SegmentID == segID)
                 .First();

                sc.Location = location;
                db.SubmitChanges();


            }
            else
            {
                //save new
                Segment segnew = new Models.Segment();
                segnew.SegmentID = segID;
                segnew.SegmentName = segname;
                segnew.BearingArray = array;
                segnew.Polyline = polyline;
                segnew.latlng = latlng;
                segnew.PrivateSeg = priv;
                datarepo.Add(segnew);
                datarepo.Save();


            }



        }

    }
}