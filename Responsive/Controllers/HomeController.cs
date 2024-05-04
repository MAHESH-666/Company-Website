using Antlr.Runtime.Misc;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using static System.Web.Razor.Parser.SyntaxConstants;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Xml.Linq;

namespace Responsive.Controllers
{
    //[Authorize(Roles ="Domain//Windows")]
    public class HomeController : Controller
    {
       
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH7863I\\SQLEXPRESS; Initial Catalog=Login; Integrated Security=True");

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Clients()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OurServices()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Demo()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Issues()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
            public ActionResult Add_data(string name, string email, string password, int age, string gender, string city, string country, string pincode)
            {
            string msg = string.Empty;
                try
                {
                
                    SqlCommand command = new SqlCommand("InsertRegistrationData", con);
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Age", age);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@City", city);
                            command.Parameters.AddWithValue("@Country", country);
                            command.Parameters.AddWithValue("@Pincode", pincode);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        msg = "Data Inserted";
                
                return Json(msg, JsonRequestBehavior.AllowGet);
                        }
                        catch (Exception ex)
            {
                msg = "Error: " + ex.Message;
            }
            return Json(msg, JsonRequestBehavior.AllowGet);
        }

    }

                   
 }