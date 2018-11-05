using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); //return a view (html page) called Index
        }

        public ActionResult MyBootcamp()
        {
            return View(); //will return a view (html page) called MyBootcamp
        }

        public ActionResult About()
        {
            //viewbag: data structuure to share info between the Controller and the view
            //does not work the other way
            ViewBag.Message = "Your application description page.";
            //Message - Key, " " - Value
            //is is also a variable.  It is dynamic, so it does not need to be instantiated ahead of time
            ViewBag.TodaysDate = DateTime.Now;


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JokeoftheDay()
        {
            string[] Jokes = { "!false (It's funny because it's true)}", "All programmers are playwrights, and all computers are lousy actors.", "The generation of random numbers is too important to be left to chance."};

            Random r = new Random();

            string Joke = Jokes[r.Next(Jokes.Length)];

            ViewBag.Joke = Joke;

            return View();
        }

        public ActionResult SearchByName(string searchName)
        {
            //connect to a database and search for the name
            string[] Names = { "James", "Paul", "Steven", "Mary", "Judy" };

            if (Names.Contains(searchName))
            {
                ViewBag.Message = "Name Found!";
            }
            else
            {
                ViewBag.Message = "Not in the DB!";
            }

            return View();
        }

        public ActionResult FindHoroscope(DateTime searchDate)
        {
            ViewBag.Zodiac = GetHoroName(searchDate);
            return View();
        }

        private string GetHoroName(DateTime dt)
        {
            int month = dt.Month;
            int day = dt.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn";
                    else
                        return "Aquarius";
                case 2:
                    if (day <= 18)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                    if (day <= 20)
                        return "Pisces";
                    else
                        return "Aries";
                case 4:
                    if (day <= 19)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (day <= 20)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (day <= 20)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (day <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (day <= 22)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (day <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (day <= 22)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (day <= 21)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (day <= 21)
                        return "Sagittarius";
                    else
                        return "Capricorn";
            }
            return "";
        }
    }
}