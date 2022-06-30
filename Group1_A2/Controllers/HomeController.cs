using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Group1_A2.Models;

namespace Group1_A2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BusinessList()
        {
            //To add all the businesses in a list. 
            List<Business> businessList = new List<Business>();

            Business business = new Business();
            business.Id = 1101;
            business.Name = "Cynthia's Chinese Restaurant";
            business.Description = "At Cynthia’s Chinese Restaurant, you'll enjoy delicious dishes served by staff dressed in traditional Imperial robes, in a beautiful dining room adorned with elegant Oriental decor. ";
            business.Address = "2460 Neyagawa Blvd, Oakville, ON L6H 7P4";
            business.PhoneNumber = "289-351-2289";
            business.Category = new Category(1, "Restaurant");
            business.Website = "https://www.cynthiaschinese.com/";
            business.Owner = "Cynthia";
            business.Rating = 7.9m;
            businessList.Add(business);

            business.Id = 1101;
            business.Name = "Cynthia's Chinese Restaurant";
            business.Description = "At Cynthia’s Chinese Restaurant, you'll enjoy delicious dishes served by staff dressed in traditional Imperial robes, in a beautiful dining room adorned with elegant Oriental decor. ";
            business.Address = "2460 Neyagawa Blvd, Oakville, ON L6H 7P4";
            business.PhoneNumber = "289-351-2289";
            business.Category = new Category(1, "Restaurant");
            business.Website = "https://www.cynthiaschinese.com/";
            business.Owner = "Cynthia";
            business.Rating = 7.9m;
            businessList.Add(business);

            business.Id = 1101;
            business.Name = "Cynthia's Chinese Restaurant";
            business.Description = "At Cynthia’s Chinese Restaurant, you'll enjoy delicious dishes served by staff dressed in traditional Imperial robes, in a beautiful dining room adorned with elegant Oriental decor. ";
            business.Address = "2460 Neyagawa Blvd, Oakville, ON L6H 7P4";
            business.PhoneNumber = "289-351-2289";
            business.Category = new Category(1, "Restaurant");
            business.Website = "https://www.cynthiaschinese.com/";
            business.Owner = "Cynthia";
            business.Rating = 7.9m;
            businessList.Add(business);

            business.Id = 1101;
            business.Name = "Cynthia's Chinese Restaurant";
            business.Description = "At Cynthia’s Chinese Restaurant, you'll enjoy delicious dishes served by staff dressed in traditional Imperial robes, in a beautiful dining room adorned with elegant Oriental decor. ";
            business.Address = "2460 Neyagawa Blvd, Oakville, ON L6H 7P4";
            business.PhoneNumber = "289-351-2289";
            business.Category = new Category(1, "Restaurant");
            business.Website = "https://www.cynthiaschinese.com/";
            business.Owner = "Cynthia";
            business.Rating = 7.9m;
            businessList.Add(business);

            //returning the business - list view
            return View(businessList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}